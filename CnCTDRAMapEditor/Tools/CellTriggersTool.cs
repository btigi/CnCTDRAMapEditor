﻿//
// Copyright 2020 Electronic Arts Inc.
//
// The Command & Conquer Map Editor and corresponding source code is free
// software: you can redistribute it and/or modify it under the terms of
// the GNU General Public License as published by the Free Software Foundation,
// either version 3 of the License, or (at your option) any later version.

// The Command & Conquer Map Editor and corresponding source code is distributed
// in the hope that it will be useful, but with permitted additional restrictions
// under Section 7 of the GPL. See the GNU General Public License in LICENSE.TXT
// distributed with this program. You should have received a copy of the
// GNU General Public License along with permitted additional restrictions
// with this program. If not, see https://github.com/electronicarts/CnC_Remastered_Collection
using MobiusEditor.Controls;
using MobiusEditor.Event;
using MobiusEditor.Interface;
using MobiusEditor.Model;
using MobiusEditor.Render;
using MobiusEditor.Utility;
using MobiusEditor.Widgets;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MobiusEditor.Tools
{
    public class CellTriggersTool : ViewTool
    {
        /// <summary>
        /// Layers that are not painted by the PostRenderMap function on ViewTool level because they are handled
        /// at a specific point in the PostRenderMap override by the implementing tool.
        /// </summary>
        protected override MapLayerFlag ManuallyHandledLayers => MapLayerFlag.CellTriggers | MapLayerFlag.TechnoTriggers;

        protected override void RefreshPreviewPanel()
        {
            // This tool has no panel.
        }

        private readonly ComboBox triggerComboBox;
        private readonly Button jumpToButton;

        private Dictionary<string, Rectangle[]> cellTrigBlobCenters = new Dictionary<string, Rectangle[]>();
        private string currentCellTrig;
        private int currentCellTrigIndex;

        private readonly Dictionary<int, CellTrigger> undoCellTriggers = new Dictionary<int, CellTrigger>();
        private readonly Dictionary<int, CellTrigger> redoCellTriggers = new Dictionary<int, CellTrigger>();

        private Map previewMap;
        protected override Map RenderMap => previewMap;

        private string currentObj;
        public override Object CurrentObject
        {
            get { return currentObj; }
            set
            {
                if (value is string trig)
                {
                    this.triggerComboBox.SelectedItem = trig;
                }
            }
        }

        private bool placementMode;

        protected override Boolean InPlacementMode
        {
            get { return placementMode; }
        }

        public string TriggerToolTip { get; set; }

        public CellTriggersTool(MapPanel mapPanel, MapLayerFlag layers, ToolStripStatusLabel statusLbl, ComboBox triggerCombo, Button jumpToButton,
            IGamePlugin plugin, UndoRedoList<UndoRedoEventArgs> url)
            : base(mapPanel, layers, statusLbl, plugin, url)
        {
            previewMap = map;
            this.jumpToButton = jumpToButton;
            this.triggerComboBox = triggerCombo;
            UpdateDataSource();
            this.triggerComboBox.SelectedIndexChanged += this.TriggerCombo_SelectedIndexChanged;
        }

        private void Triggers_CollectionChanged(object sender, EventArgs e)
        {
            UpdateDataSource();
        }

        private void UpdateDataSource()
        {
            string selected = triggerComboBox.SelectedItem as string;
            triggerComboBox.DataSource = null;
            triggerComboBox.Items.Clear();
            string[] filteredEvents = plugin.Map.EventTypes.Where(ev => plugin.Map.CellEventTypes.Contains(ev)).Distinct().ToArray();
            string[] filteredActions = plugin.Map.ActionTypes.Where(ev => plugin.Map.CellActionTypes.Contains(ev)).Distinct().ToArray();
            bool hasItems;
            string[] items = GetItems(out hasItems);
            UpdateBlobsList(items, null);
            int selectIndex = selected == null ? 0 : Enumerable.Range(0, items.Length).FirstOrDefault(x => String.Equals(items[x], selected, StringComparison.InvariantCultureIgnoreCase));
            triggerComboBox.DataSource = items;
            triggerComboBox.SelectedIndex = selectIndex;
            triggerComboBox.Enabled = hasItems;
            TriggerToolTip = Map.MakeAllowedTriggersToolTip(filteredEvents, filteredActions);
        }

        private String[] GetItems(out bool hasItems)
        {
            string[] items = plugin.Map.FilterCellTriggers().Select(t => t.Name).Distinct().ToArray();
            hasItems = items.Length > 0;
            if (!hasItems)
            {
                items = new[] { Trigger.None };
            }
            return items;
        }

        /// <summary>
        /// Upodates the blob lists. If items is not given, it takes the current map state. If updateItem is given, only that one will be updated in the list.
        /// </summary>
        /// <param name="items">Optional list of items, for optimisation to avoid an extra fetch action.</param>
        /// <param name="updateItem">Optional item to update. Leave empty to update all.</param>
        private void UpdateBlobsList(string[] items, string updateItem)
        {
            currentCellTrigIndex = 0;
            if (items == null)
            {
                bool hasItems;
                items = GetItems(out hasItems);
            }
            if (updateItem != null)
            {
                if (items.Where(t => t.Equals(updateItem, StringComparison.OrdinalIgnoreCase)).Count() == 0)
                {
                    // Item to update was not found; abort.
                    return;
                }
                // Only process the one item.
                items = new string[] { updateItem };
            }
            if (updateItem == null)
            {
                // No item given: refresh all.
                cellTrigBlobCenters.Clear();
            }
            int height = map.Metrics.Height;
            int width = map.Metrics.Width;
            foreach (String trig in items)
            {
                bool[,] cellTrigs = new bool[height, width];
                List<Point> points = new List<Point>();
                foreach ((int cell, CellTrigger value) in map.CellTriggers)
                {
                    if (trig.Equals(value.Trigger, StringComparison.OrdinalIgnoreCase) && map.Metrics.GetLocation(cell, out Point loc))
                    {
                        points.Add(loc);
                        cellTrigs[loc.Y, loc.X] = true;
                    }
                }
                Func<bool[,], int, int, bool> isCelltrigger = (mapdata, yVal, xVal) => mapdata[yVal, xVal];
                List<List<Point>> blobs = BlobDetection.FindBlobs(cellTrigs, width, height, points.ToArray(), isCelltrigger, true, true);
                List<Rectangle> curBlobBounds = blobs.Where(b => b.Count > 0).Select(BlobDetection.GetBlobBounds).ToList();
                if (updateItem != null)
                {
                    cellTrigBlobCenters[updateItem] = curBlobBounds.ToArray();
                    break;
                }
                cellTrigBlobCenters[trig] = curBlobBounds.ToArray();
            }
        }

        private void MapPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (placementMode)
            {
                if (e.Button == MouseButtons.Left)
                {
                    SetCellTrigger(navigationWidget.MouseCell);
                }
                else if (e.Button == MouseButtons.Right)
                {
                    RemoveCellTrigger(navigationWidget.MouseCell);
                }
            }
            else if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                PickCellTrigger(navigationWidget.MouseCell);
            }
        }

        private void MapPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (undoCellTriggers.Count > 0 || redoCellTriggers.Count > 0)
            {
                CommitChange();
            }
        }

        private void CellTriggersTool_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {
                EnterPlacementMode();
            }
            else if (triggerComboBox.Enabled)
            {
                int maxVal = triggerComboBox.Items.Count - 1;
                int curVal = triggerComboBox.SelectedIndex;
                int newVal = curVal;
                switch (e.KeyCode)
                {
                    case Keys.Home:
                        newVal = 0;
                        break;
                    case Keys.End:
                        newVal = maxVal;
                        break;
                    case Keys.PageDown:
                        newVal = Math.Min(curVal + 1, maxVal);
                        break;
                    case Keys.PageUp:
                        newVal = Math.Max(curVal - 1, 0);
                        break;
                    case Keys.Enter:
                        JumpToNextBlob();
                        break;
                }
                if (curVal != newVal)
                {
                    triggerComboBox.SelectedIndex = newVal;
                }
            }
        }

        private void CellTriggersTool_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {
                ExitPlacementMode();
            }
        }

        private void MapPanel_MouseLeave(object sender, EventArgs e)
        {
            ExitPlacementMode();
        }

        private void MapPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!placementMode && (Control.ModifierKeys == Keys.Shift))
            {
                EnterPlacementMode();
            }
            else if (placementMode && (Control.ModifierKeys == Keys.None))
            {
                ExitPlacementMode();
            }
        }

        private void MouseoverWidget_MouseCellChanged(object sender, MouseCellChangedEventArgs e)
        {
            if (placementMode)
            {
                if (Control.MouseButtons == MouseButtons.Left)
                {
                    SetCellTrigger(e.NewCell);
                }
                else if (Control.MouseButtons == MouseButtons.Right)
                {
                    RemoveCellTrigger(e.NewCell);
                }
                mapPanel.Invalidate(map, e.NewCell);
            }
            else if (e.MouseButtons == MouseButtons.Left || e.MouseButtons == MouseButtons.Right)
            {
                PickCellTrigger(e.NewCell);
            }
        }

        private void SetCellTrigger(Point location)
        {
            if (!(triggerComboBox.SelectedItem is string trigger) || Trigger.IsEmpty(trigger))
            {
                return;
            }
            if (!map.Metrics.GetCell(location, out int cell) || map.CellTriggers[cell] != null)
            {
                return;
            }
            if (!undoCellTriggers.ContainsKey(cell))
            {
                undoCellTriggers[cell] = map.CellTriggers[cell];
            }
            var cellTrigger = new CellTrigger(trigger);
            map.CellTriggers[cell] = cellTrigger;
            redoCellTriggers[cell] = cellTrigger;
            mapPanel.Invalidate(map, navigationWidget.MouseCell);
        }

        private void RemoveCellTrigger(Point location)
        {
            if (!map.Metrics.GetCell(location, out int cell))
            {
                return;
            }
            var cellTrigger = map.CellTriggers[cell];
            if (cellTrigger == null)
            {
                return;
            }
            if (!undoCellTriggers.ContainsKey(cell))
            {
                undoCellTriggers[cell] = map.CellTriggers[cell];
            }
            map.CellTriggers[cell] = null;
            redoCellTriggers[cell] = null;
            mapPanel.Invalidate(map, navigationWidget.MouseCell);
        }

        private void EnterPlacementMode()
        {
            if (placementMode)
            {
                return;
            }
            placementMode = true;
            mapPanel.Invalidate(map, navigationWidget.MouseCell);
            UpdateStatus();
        }

        private void ExitPlacementMode()
        {
            if (!placementMode)
            {
                return;
            }
            placementMode = false;
            mapPanel.Invalidate(map, navigationWidget.MouseCell);
            UpdateStatus();
        }

        private void PickCellTrigger(Point location)
        {
            if (map.Metrics.GetCell(location, out int cell))
            {
                var cellTrigger = map.CellTriggers[cell];
                if (cellTrigger != null)
                {
                    String trigger = cellTrigger.Trigger;
                    triggerComboBox.SelectedItem = trigger;
                    if (cellTrigBlobCenters.TryGetValue(trigger, out Rectangle[] locations))
                    {
                        currentCellTrig = trigger;
                        currentObj = trigger;
                        currentCellTrigIndex = 0;
                        // If found, make sure clicking the "jump to next use" button
                        // will go to the blob after the currently clicked one.
                        for (Int32 i = 0; i < locations.Length; ++i)
                        {
                            Rectangle triggerLocation = locations[i];
                            if (triggerLocation.Contains(location))
                            {
                                currentCellTrigIndex = i + 1;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void CommitChange()
        {
            bool origDirtyState = plugin.Dirty;
            plugin.Dirty = true;
            var undoCellTriggers2 = new Dictionary<int, CellTrigger>(undoCellTriggers);
            string selected = triggerComboBox.SelectedItem as string ?? String.Empty;
            UpdateBlobsList(null, selected);
            void undoAction(UndoRedoEventArgs e)
            {
                List<Trigger> valid = e.Map.FilterCellTriggers().ToList();
                foreach (var kv in undoCellTriggers2)
                {
                    CellTrigger cellTrig = kv.Value;
                    bool isValid = cellTrig == null || valid.Any(t => t.Name.Equals(cellTrig.Trigger, StringComparison.InvariantCultureIgnoreCase));
                    e.Map.CellTriggers[kv.Key] = isValid ? cellTrig : null;
                    e.MapPanel.Invalidate(map, kv.Key);
                }
                if (e.Plugin != null)
                {
                    e.Plugin.Dirty = origDirtyState;
                }
                if (selected != null)
                {
                    UpdateBlobsList(null, selected);
                }
            }
            var redoCellTriggers2 = new Dictionary<int, CellTrigger>(redoCellTriggers);
            void redoAction(UndoRedoEventArgs e)
            {
                List<Trigger> valid = e.Map.FilterCellTriggers().ToList();
                foreach (var kv in redoCellTriggers2)
                {
                    CellTrigger cellTrig = kv.Value;
                    bool isValid = cellTrig == null || valid.Any(t => t.Name.Equals(cellTrig.Trigger, StringComparison.InvariantCultureIgnoreCase));
                    e.Map.CellTriggers[kv.Key] = isValid ? cellTrig : null;
                    e.MapPanel.Invalidate(map, kv.Key);
                }
                if (e.Plugin != null)
                {
                    e.Plugin.Dirty = true;
                }
                if (selected != null)
                {
                    UpdateBlobsList(null, selected);
                }
            }
            undoCellTriggers.Clear();
            redoCellTriggers.Clear();
            url.Track(undoAction, redoAction);
        }

        private void TriggerCombo_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            string selected = triggerComboBox.SelectedItem as string;
            jumpToButton.Enabled = selected != null && cellTrigBlobCenters.TryGetValue(selected, out Rectangle[] locations) && locations != null && locations.Length > 0;
            currentObj = selected;
            if (placementMode)
            {
                // An invalidate without cells won't call PreRenderMap, and will thus
                // not add the dummy to the clone map. So we call it manually.
                PreRenderMap();
            }
            mapPanel.Invalidate();
        }

        private void JumpToButton_Click(Object sender, EventArgs e)
        {
            JumpToNextBlob();
        }

        private void JumpToNextBlob()
        {
            string selected = triggerComboBox.SelectedItem as string;
            if (!String.Equals(currentCellTrig, selected, StringComparison.OrdinalIgnoreCase))
            {
                currentCellTrigIndex = 0;
                currentCellTrig = selected;
            }
            if (cellTrigBlobCenters.TryGetValue(selected, out Rectangle[] locations))
            {
                if (locations == null || locations.Length == 0)
                {
                    return;
                }
                if (currentCellTrigIndex >= locations.Length)
                {
                    currentCellTrigIndex = 0;
                }
                Rectangle location = locations[currentCellTrigIndex];
                mapPanel.JumpToPosition(map.Metrics, location, false);
                currentCellTrigIndex++;
            }
        }

        protected override void PreRenderMap()
        {
            base.PreRenderMap();
            previewMap = map.Clone(true);
            if (!placementMode)
            {
                return;
            }
            string selected = triggerComboBox.SelectedItem as string;
            if (selected == null || Trigger.IsEmpty(selected))
            {
                return;
            }
            var location = navigationWidget.MouseCell;
            if (!previewMap.Metrics.GetCell(location, out int cell))
            {
                return;
            }
            CellTrigger celltr = previewMap.CellTriggers[location];
            if (celltr == null)
            {
                previewMap.CellTriggers[location] = new CellTrigger(selected);
                // Tint is not actually used; a lower alpha just indicates that it is a preview item.
                previewMap.CellTriggers[location].Tint = Color.FromArgb(128, Color.White);
            }
        }

        protected override void PostRenderMap(Graphics graphics, Rectangle visibleCells)
        {
            base.PostRenderMap(graphics, visibleCells);
            string selected = triggerComboBox.SelectedItem as string;
            if (selected != null && Trigger.IsEmpty(selected))
                selected = null;
            string[] selectedRange = selected != null ? new[] { selected } : new string[] { };
            // Normal techno triggers: under cell
            MapRenderer.RenderAllTechnoTriggers(graphics, map, visibleCells, Globals.MapTileSize, Layers, Color.LimeGreen, selected, true);
            MapRenderer.RenderCellTriggersHard(graphics, map, visibleCells, Globals.MapTileSize, selectedRange);
            if (selected != null)
            {
                // Only use preview map if in placement mode.
                MapRenderer.RenderCellTriggersSelected(graphics, placementMode ? previewMap : map, visibleCells, Globals.MapTileSize, selectedRange);
                // Selected technos: on top of cell
                MapRenderer.RenderAllTechnoTriggers(graphics, map, visibleCells, Globals.MapTileSize, Layers, Color.Yellow, selected, false);
            }
        }

        private void UpdateStatus()
        {
            if (placementMode)
            {
                statusLbl.Text = "Left-Click to set cell trigger, Right-Click to clear cell trigger";
            }
            else
            {
                statusLbl.Text = "Shift to enter placement mode, Left-Click or Right-Click to pick cell trigger";
            }
        }

        public override void Activate()
        {
            base.Activate();
            Deactivate(true);
            this.jumpToButton.Click += JumpToButton_Click;
            plugin.Map.TriggersUpdated += Triggers_CollectionChanged;
            this.mapPanel.MouseDown += MapPanel_MouseDown;
            this.mapPanel.MouseUp += MapPanel_MouseUp;
            this.mapPanel.MouseMove += MapPanel_MouseMove;
            this.mapPanel.MouseLeave += MapPanel_MouseLeave;
            (this.mapPanel as Control).KeyDown += CellTriggersTool_KeyDown;
            (this.mapPanel as Control).KeyUp += CellTriggersTool_KeyUp;
            navigationWidget.BoundsMouseCellChanged += MouseoverWidget_MouseCellChanged;
            UpdateStatus();
        }

        public override void Deactivate()
        {
            Deactivate(false);
        }

        public void Deactivate(bool forActivate)
        {
            if (!forActivate)
            {
                ExitPlacementMode();
                base.Deactivate();
            }
            this.jumpToButton.Click -= JumpToButton_Click;
            plugin.Map.TriggersUpdated -= Triggers_CollectionChanged;
            this.mapPanel.MouseDown -= MapPanel_MouseDown;
            this.mapPanel.MouseUp -= MapPanel_MouseUp;
            this.mapPanel.MouseMove -= MapPanel_MouseMove;
            this.mapPanel.MouseLeave -= MapPanel_MouseLeave;
            (mapPanel as Control).KeyDown -= CellTriggersTool_KeyDown;
            (mapPanel as Control).KeyUp -= CellTriggersTool_KeyUp;
            navigationWidget.BoundsMouseCellChanged -= MouseoverWidget_MouseCellChanged;
        }

        #region IDisposable Support
        private bool disposedValue = false;

        protected override void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this.triggerComboBox.SelectedIndexChanged -= this.TriggerCombo_SelectedIndexChanged;
                    Deactivate();
                }
                disposedValue = true;
            }
            base.Dispose(disposing);
        }
        #endregion
    }
}
