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
using System;
using System.Windows.Forms;

namespace MobiusEditor.Dialogs
{
    partial class TeamTypesDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddTeamType = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.teamTypeTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTeams = new System.Windows.Forms.Panel();
            this.lblLine1 = new System.Windows.Forms.Label();
            this.lblTeams = new System.Windows.Forms.Label();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.pnlTeamsScroll = new System.Windows.Forms.Panel();
            this.tilTeams = new MobiusEditor.Controls.TeamItemsList();
            this.pnlOrders = new System.Windows.Forms.Panel();
            this.lblLine2 = new System.Windows.Forms.Label();
            this.lblOrders = new System.Windows.Forms.Label();
            this.btnAddMission = new System.Windows.Forms.Button();
            this.pnlMissionsScroll = new System.Windows.Forms.Panel();
            this.milMissions = new MobiusEditor.Controls.MissionItemsList();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHouse = new System.Windows.Forms.Label();
            this.cmbHouse = new System.Windows.Forms.ComboBox();
            this.chbRoundabout = new System.Windows.Forms.CheckBox();
            this.chbLearning = new System.Windows.Forms.CheckBox();
            this.chbSuicide = new System.Windows.Forms.CheckBox();
            this.chbAutocreate = new System.Windows.Forms.CheckBox();
            this.chbMercenary = new System.Windows.Forms.CheckBox();
            this.chbReinforcable = new System.Windows.Forms.CheckBox();
            this.chbPrebuilt = new System.Windows.Forms.CheckBox();
            this.lblInitNum = new System.Windows.Forms.Label();
            this.lblMaxAllowed = new System.Windows.Forms.Label();
            this.lblFear = new System.Windows.Forms.Label();
            this.nudInitNum = new MobiusEditor.Controls.EnhNumericUpDown();
            this.maxAllowedNud = new MobiusEditor.Controls.EnhNumericUpDown();
            this.nudFear = new MobiusEditor.Controls.EnhNumericUpDown();
            this.lblWaypoint = new System.Windows.Forms.Label();
            this.lblTrigger = new System.Windows.Forms.Label();
            this.cmbWaypoint = new System.Windows.Forms.ComboBox();
            this.cmbTrigger = new System.Windows.Forms.ComboBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.nudRecruitPriority = new MobiusEditor.Controls.EnhNumericUpDown();
            this.lblTriggerInfo = new System.Windows.Forms.Label();
            this.teamTypesListView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HouseColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teamTypesContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addTeamTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameTeamTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTeamTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.teamTypeTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.pnlTeams.SuspendLayout();
            this.pnlTeamsScroll.SuspendLayout();
            this.pnlOrders.SuspendLayout();
            this.pnlMissionsScroll.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxAllowedNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecruitPriority)).BeginInit();
            this.teamTypesContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.settingsPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.teamTypesListView, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(875, 416);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.btnAddTeamType);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 379);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(169, 34);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btnAddTeamType
            // 
            this.btnAddTeamType.AutoSize = true;
            this.btnAddTeamType.Location = new System.Drawing.Point(2, 2);
            this.btnAddTeamType.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTeamType.Name = "btnAddTeamType";
            this.btnAddTeamType.Size = new System.Drawing.Size(168, 30);
            this.btnAddTeamType.TabIndex = 1;
            this.btnAddTeamType.Text = "&Add Teamtype";
            this.btnAddTeamType.UseVisualStyleBackColor = true;
            this.btnAddTeamType.Click += new System.EventHandler(this.BtnAddTeamType_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnOK);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(178, 379);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(694, 34);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(624, 2);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 30);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.AutoSize = true;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(570, 2);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(50, 30);
            this.btnOK.TabIndex = 40;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.teamTypeTableLayoutPanel);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanel.Location = new System.Drawing.Point(185, 10);
            this.settingsPanel.Margin = new System.Windows.Forms.Padding(10);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(680, 356);
            this.settingsPanel.TabIndex = 2;
            // 
            // teamTypeTableLayoutPanel
            // 
            this.teamTypeTableLayoutPanel.ColumnCount = 2;
            this.teamTypeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.teamTypeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.teamTypeTableLayoutPanel.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.teamTypeTableLayoutPanel.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.teamTypeTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamTypeTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.teamTypeTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.teamTypeTableLayoutPanel.Name = "teamTypeTableLayoutPanel";
            this.teamTypeTableLayoutPanel.RowCount = 1;
            this.teamTypeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.teamTypeTableLayoutPanel.Size = new System.Drawing.Size(680, 356);
            this.teamTypeTableLayoutPanel.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel3.Controls.Add(this.pnlTeams, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pnlOrders, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(206, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(472, 352);
            this.tableLayoutPanel3.TabIndex = 24;
            // 
            // pnlTeams
            // 
            this.pnlTeams.Controls.Add(this.lblLine1);
            this.pnlTeams.Controls.Add(this.lblTeams);
            this.pnlTeams.Controls.Add(this.btnAddTeam);
            this.pnlTeams.Controls.Add(this.pnlTeamsScroll);
            this.pnlTeams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTeams.Location = new System.Drawing.Point(0, 0);
            this.pnlTeams.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTeams.Name = "pnlTeams";
            this.pnlTeams.Size = new System.Drawing.Size(212, 352);
            this.pnlTeams.TabIndex = 32;
            // 
            // lblLine1
            // 
            this.lblLine1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine1.Location = new System.Drawing.Point(3, 0);
            this.lblLine1.Name = "lblLine1";
            this.lblLine1.Size = new System.Drawing.Size(2, 352);
            this.lblLine1.TabIndex = 4;
            // 
            // lblTeams
            // 
            this.lblTeams.AutoSize = true;
            this.lblTeams.Location = new System.Drawing.Point(8, 8);
            this.lblTeams.Name = "lblTeams";
            this.lblTeams.Size = new System.Drawing.Size(39, 13);
            this.lblTeams.TabIndex = 3;
            this.lblTeams.Text = "Teams";
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTeam.AutoSize = true;
            this.btnAddTeam.Location = new System.Drawing.Point(147, 3);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(62, 23);
            this.btnAddTeam.TabIndex = 0;
            this.btnAddTeam.Text = "Add team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.BtnAddTeam_Click);
            // 
            // pnlTeamsScroll
            // 
            this.pnlTeamsScroll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTeamsScroll.AutoScroll = true;
            this.pnlTeamsScroll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTeamsScroll.Controls.Add(this.tilTeams);
            this.pnlTeamsScroll.Location = new System.Drawing.Point(11, 33);
            this.pnlTeamsScroll.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTeamsScroll.Name = "pnlTeamsScroll";
            this.pnlTeamsScroll.Size = new System.Drawing.Size(201, 319);
            this.pnlTeamsScroll.TabIndex = 1;
            // 
            // tilTeams
            // 
            this.tilTeams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tilTeams.Location = new System.Drawing.Point(0, 0);
            this.tilTeams.Margin = new System.Windows.Forms.Padding(0);
            this.tilTeams.Name = "tilTeams";
            this.tilTeams.Size = new System.Drawing.Size(201, 150);
            this.tilTeams.TabIndex = 1;
            // 
            // pnlOrders
            // 
            this.pnlOrders.Controls.Add(this.lblLine2);
            this.pnlOrders.Controls.Add(this.lblOrders);
            this.pnlOrders.Controls.Add(this.btnAddMission);
            this.pnlOrders.Controls.Add(this.pnlMissionsScroll);
            this.pnlOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrders.Location = new System.Drawing.Point(212, 0);
            this.pnlOrders.Margin = new System.Windows.Forms.Padding(0);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(260, 352);
            this.pnlOrders.TabIndex = 33;
            // 
            // lblLine2
            // 
            this.lblLine2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLine2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine2.Location = new System.Drawing.Point(3, 0);
            this.lblLine2.Name = "lblLine2";
            this.lblLine2.Size = new System.Drawing.Size(2, 352);
            this.lblLine2.TabIndex = 5;
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Location = new System.Drawing.Point(8, 8);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(38, 13);
            this.lblOrders.TabIndex = 3;
            this.lblOrders.Text = "Orders";
            // 
            // btnAddMission
            // 
            this.btnAddMission.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMission.AutoSize = true;
            this.btnAddMission.Location = new System.Drawing.Point(196, 2);
            this.btnAddMission.Name = "btnAddMission";
            this.btnAddMission.Size = new System.Drawing.Size(63, 23);
            this.btnAddMission.TabIndex = 0;
            this.btnAddMission.Text = "Add order";
            this.btnAddMission.UseVisualStyleBackColor = true;
            this.btnAddMission.Click += new System.EventHandler(this.BtnAddMission_Click);
            // 
            // pnlMissionsScroll
            // 
            this.pnlMissionsScroll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMissionsScroll.AutoScroll = true;
            this.pnlMissionsScroll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMissionsScroll.Controls.Add(this.milMissions);
            this.pnlMissionsScroll.Location = new System.Drawing.Point(11, 33);
            this.pnlMissionsScroll.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMissionsScroll.Name = "pnlMissionsScroll";
            this.pnlMissionsScroll.Size = new System.Drawing.Size(251, 321);
            this.pnlMissionsScroll.TabIndex = 0;
            // 
            // milMissions
            // 
            this.milMissions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.milMissions.Location = new System.Drawing.Point(0, 0);
            this.milMissions.Margin = new System.Windows.Forms.Padding(0);
            this.milMissions.Name = "milMissions";
            this.milMissions.Size = new System.Drawing.Size(251, 150);
            this.milMissions.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.Controls.Add(this.lblHouse, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbHouse, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.chbRoundabout, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.chbLearning, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.chbSuicide, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.chbAutocreate, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.chbMercenary, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.chbReinforcable, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.chbPrebuilt, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.lblInitNum, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.lblMaxAllowed, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.lblFear, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.nudInitNum, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.maxAllowedNud, 1, 10);
            this.tableLayoutPanel2.Controls.Add(this.nudFear, 1, 11);
            this.tableLayoutPanel2.Controls.Add(this.lblWaypoint, 0, 12);
            this.tableLayoutPanel2.Controls.Add(this.lblTrigger, 0, 13);
            this.tableLayoutPanel2.Controls.Add(this.cmbWaypoint, 1, 12);
            this.tableLayoutPanel2.Controls.Add(this.cmbTrigger, 1, 13);
            this.tableLayoutPanel2.Controls.Add(this.lblPriority, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.nudRecruitPriority, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.lblTriggerInfo, 2, 13);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 15;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 352);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblHouse
            // 
            this.lblHouse.AutoSize = true;
            this.lblHouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHouse.Location = new System.Drawing.Point(2, 0);
            this.lblHouse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHouse.Name = "lblHouse";
            this.lblHouse.Size = new System.Drawing.Size(79, 25);
            this.lblHouse.TabIndex = 0;
            this.lblHouse.Text = "House";
            this.lblHouse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.lblHouse, "Owner of this team.");
            // 
            // cmbHouse
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.cmbHouse, 2);
            this.cmbHouse.DisplayMember = "Name";
            this.cmbHouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHouse.FormattingEnabled = true;
            this.cmbHouse.Location = new System.Drawing.Point(85, 2);
            this.cmbHouse.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHouse.Name = "cmbHouse";
            this.cmbHouse.Size = new System.Drawing.Size(113, 21);
            this.cmbHouse.TabIndex = 10;
            this.cmbHouse.ValueMember = "Type";
            this.cmbHouse.SelectedValueChanged += new System.EventHandler(this.cmbHouse_SelectedValueChanged);
            // 
            // chbRoundabout
            // 
            this.chbRoundabout.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.chbRoundabout, 2);
            this.chbRoundabout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbRoundabout.Location = new System.Drawing.Point(85, 27);
            this.chbRoundabout.Margin = new System.Windows.Forms.Padding(2);
            this.chbRoundabout.Name = "chbRoundabout";
            this.chbRoundabout.Size = new System.Drawing.Size(113, 17);
            this.chbRoundabout.TabIndex = 11;
            this.chbRoundabout.Text = "Roundabout";
            this.toolTip1.SetToolTip(this.chbRoundabout, "Avoid high-threat areas.");
            this.chbRoundabout.UseVisualStyleBackColor = true;
            // 
            // chbLearning
            // 
            this.chbLearning.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.chbLearning, 2);
            this.chbLearning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbLearning.Location = new System.Drawing.Point(85, 48);
            this.chbLearning.Margin = new System.Windows.Forms.Padding(2);
            this.chbLearning.Name = "chbLearning";
            this.chbLearning.Size = new System.Drawing.Size(113, 17);
            this.chbLearning.TabIndex = 12;
            this.chbLearning.Text = "Learning";
            this.toolTip1.SetToolTip(this.chbLearning, "The team learns from mistakes.");
            this.chbLearning.UseVisualStyleBackColor = true;
            // 
            // chbSuicide
            // 
            this.chbSuicide.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.chbSuicide, 2);
            this.chbSuicide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbSuicide.Location = new System.Drawing.Point(85, 69);
            this.chbSuicide.Margin = new System.Windows.Forms.Padding(2);
            this.chbSuicide.Name = "chbSuicide";
            this.chbSuicide.Size = new System.Drawing.Size(113, 17);
            this.chbSuicide.TabIndex = 13;
            this.chbSuicide.Text = "Suicide";
            this.toolTip1.SetToolTip(this.chbSuicide, "The team won\'t stop until it achieves its mission or it\'s dead.");
            this.chbSuicide.UseVisualStyleBackColor = true;
            // 
            // chbAutocreate
            // 
            this.chbAutocreate.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.chbAutocreate, 2);
            this.chbAutocreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbAutocreate.Location = new System.Drawing.Point(85, 90);
            this.chbAutocreate.Margin = new System.Windows.Forms.Padding(2);
            this.chbAutocreate.Name = "chbAutocreate";
            this.chbAutocreate.Size = new System.Drawing.Size(113, 17);
            this.chbAutocreate.TabIndex = 14;
            this.chbAutocreate.Text = "Auto-create";
            this.toolTip1.SetToolTip(this.chbAutocreate, "Make this part of the pool of teams to be produced\r\nwhen enabling Autocreate for " +
        "this House.");
            this.chbAutocreate.UseVisualStyleBackColor = true;
            // 
            // chbMercenary
            // 
            this.chbMercenary.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.chbMercenary, 2);
            this.chbMercenary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbMercenary.Location = new System.Drawing.Point(85, 111);
            this.chbMercenary.Margin = new System.Windows.Forms.Padding(2);
            this.chbMercenary.Name = "chbMercenary";
            this.chbMercenary.Size = new System.Drawing.Size(113, 17);
            this.chbMercenary.TabIndex = 15;
            this.chbMercenary.Text = "Mercenary";
            this.toolTip1.SetToolTip(this.chbMercenary, "Will change sides if they start to lose.");
            this.chbMercenary.UseVisualStyleBackColor = true;
            // 
            // chbReinforcable
            // 
            this.chbReinforcable.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.chbReinforcable, 2);
            this.chbReinforcable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbReinforcable.Location = new System.Drawing.Point(85, 132);
            this.chbReinforcable.Margin = new System.Windows.Forms.Padding(2);
            this.chbReinforcable.Name = "chbReinforcable";
            this.chbReinforcable.Size = new System.Drawing.Size(113, 17);
            this.chbReinforcable.TabIndex = 16;
            this.chbReinforcable.Text = "Reinforcable";
            this.toolTip1.SetToolTip(this.chbReinforcable, "Allow recruitment of new members if some die.\r\nIf false, acts similar to Suicide," +
        " but they will defend themselves.");
            this.chbReinforcable.UseVisualStyleBackColor = true;
            // 
            // chbPrebuilt
            // 
            this.chbPrebuilt.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.chbPrebuilt, 2);
            this.chbPrebuilt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbPrebuilt.Location = new System.Drawing.Point(85, 153);
            this.chbPrebuilt.Margin = new System.Windows.Forms.Padding(2);
            this.chbPrebuilt.Name = "chbPrebuilt";
            this.chbPrebuilt.Size = new System.Drawing.Size(113, 17);
            this.chbPrebuilt.TabIndex = 17;
            this.chbPrebuilt.Text = "Prebuilt";
            this.toolTip1.SetToolTip(this.chbPrebuilt, "Computer should build members to fill a team of this type\r\nregardless of whether " +
        "there is a team of this type active.");
            this.chbPrebuilt.UseVisualStyleBackColor = true;
            // 
            // lblInitNum
            // 
            this.lblInitNum.AutoSize = true;
            this.lblInitNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInitNum.Location = new System.Drawing.Point(2, 196);
            this.lblInitNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInitNum.Name = "lblInitNum";
            this.lblInitNum.Size = new System.Drawing.Size(79, 24);
            this.lblInitNum.TabIndex = 9;
            this.lblInitNum.Text = "Init Num";
            this.lblInitNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.lblInitNum, "Initial amount of this type of team.");
            // 
            // lblMaxAllowed
            // 
            this.lblMaxAllowed.AutoSize = true;
            this.lblMaxAllowed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaxAllowed.Location = new System.Drawing.Point(2, 220);
            this.lblMaxAllowed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxAllowed.Name = "lblMaxAllowed";
            this.lblMaxAllowed.Size = new System.Drawing.Size(79, 24);
            this.lblMaxAllowed.TabIndex = 10;
            this.lblMaxAllowed.Text = "Max Allowed";
            this.lblMaxAllowed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.lblMaxAllowed, "Maximum amount of this type of team allowed at one time.");
            // 
            // lblFear
            // 
            this.lblFear.AutoSize = true;
            this.lblFear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFear.Location = new System.Drawing.Point(2, 244);
            this.lblFear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFear.Name = "lblFear";
            this.lblFear.Size = new System.Drawing.Size(79, 24);
            this.lblFear.TabIndex = 11;
            this.lblFear.Text = "Fear";
            this.lblFear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.lblFear, "Fear level of this team. No known effect.");
            // 
            // nudInitNum
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.nudInitNum, 2);
            this.nudInitNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudInitNum.EnteredValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudInitNum.Location = new System.Drawing.Point(85, 198);
            this.nudInitNum.Margin = new System.Windows.Forms.Padding(2);
            this.nudInitNum.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudInitNum.Name = "nudInitNum";
            this.nudInitNum.SelectedText = "";
            this.nudInitNum.SelectionLength = 0;
            this.nudInitNum.SelectionStart = 0;
            this.nudInitNum.Size = new System.Drawing.Size(113, 20);
            this.nudInitNum.TabIndex = 19;
            // 
            // maxAllowedNud
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.maxAllowedNud, 2);
            this.maxAllowedNud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxAllowedNud.EnteredValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.maxAllowedNud.Location = new System.Drawing.Point(85, 222);
            this.maxAllowedNud.Margin = new System.Windows.Forms.Padding(2);
            this.maxAllowedNud.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.maxAllowedNud.Name = "maxAllowedNud";
            this.maxAllowedNud.SelectedText = "";
            this.maxAllowedNud.SelectionLength = 0;
            this.maxAllowedNud.SelectionStart = 0;
            this.maxAllowedNud.Size = new System.Drawing.Size(113, 20);
            this.maxAllowedNud.TabIndex = 20;
            // 
            // nudFear
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.nudFear, 2);
            this.nudFear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudFear.EnteredValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudFear.Location = new System.Drawing.Point(85, 246);
            this.nudFear.Margin = new System.Windows.Forms.Padding(2);
            this.nudFear.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudFear.Name = "nudFear";
            this.nudFear.SelectedText = "";
            this.nudFear.SelectionLength = 0;
            this.nudFear.SelectionStart = 0;
            this.nudFear.Size = new System.Drawing.Size(113, 20);
            this.nudFear.TabIndex = 21;
            // 
            // lblWaypoint
            // 
            this.lblWaypoint.AutoSize = true;
            this.lblWaypoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWaypoint.Location = new System.Drawing.Point(2, 268);
            this.lblWaypoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWaypoint.Name = "lblWaypoint";
            this.lblWaypoint.Size = new System.Drawing.Size(79, 25);
            this.lblWaypoint.TabIndex = 15;
            this.lblWaypoint.Text = "Waypoint";
            this.lblWaypoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTrigger
            // 
            this.lblTrigger.AutoSize = true;
            this.lblTrigger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTrigger.Location = new System.Drawing.Point(2, 293);
            this.lblTrigger.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrigger.Name = "lblTrigger";
            this.lblTrigger.Size = new System.Drawing.Size(79, 27);
            this.lblTrigger.TabIndex = 16;
            this.lblTrigger.Text = "Trigger";
            this.lblTrigger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbWaypoint
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.cmbWaypoint, 2);
            this.cmbWaypoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbWaypoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWaypoint.FormattingEnabled = true;
            this.cmbWaypoint.Location = new System.Drawing.Point(85, 270);
            this.cmbWaypoint.Margin = new System.Windows.Forms.Padding(2);
            this.cmbWaypoint.Name = "cmbWaypoint";
            this.cmbWaypoint.Size = new System.Drawing.Size(113, 21);
            this.cmbWaypoint.TabIndex = 22;
            // 
            // cmbTrigger
            // 
            this.cmbTrigger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbTrigger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrigger.FormattingEnabled = true;
            this.cmbTrigger.Location = new System.Drawing.Point(85, 295);
            this.cmbTrigger.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTrigger.Name = "cmbTrigger";
            this.cmbTrigger.Size = new System.Drawing.Size(79, 21);
            this.cmbTrigger.TabIndex = 23;
            // 
            // lblPriority
            // 
            this.lblPriority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPriority.Location = new System.Drawing.Point(2, 172);
            this.lblPriority.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(79, 24);
            this.lblPriority.TabIndex = 19;
            this.lblPriority.Text = "Priority";
            this.lblPriority.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.lblPriority, "Priority given the team for recruiting purposes; higher\r\npriority means it can st" +
        "eal members from other teams.");
            // 
            // nudRecruitPriority
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.nudRecruitPriority, 2);
            this.nudRecruitPriority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudRecruitPriority.EnteredValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudRecruitPriority.Location = new System.Drawing.Point(85, 174);
            this.nudRecruitPriority.Margin = new System.Windows.Forms.Padding(2);
            this.nudRecruitPriority.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudRecruitPriority.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.nudRecruitPriority.Name = "nudRecruitPriority";
            this.nudRecruitPriority.SelectedText = "";
            this.nudRecruitPriority.SelectionLength = 0;
            this.nudRecruitPriority.SelectionStart = 0;
            this.nudRecruitPriority.Size = new System.Drawing.Size(113, 20);
            this.nudRecruitPriority.TabIndex = 18;
            // 
            // lblTriggerInfo
            // 
            this.lblTriggerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTriggerInfo.Location = new System.Drawing.Point(166, 293);
            this.lblTriggerInfo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTriggerInfo.Name = "lblTriggerInfo";
            this.lblTriggerInfo.Size = new System.Drawing.Size(34, 27);
            this.lblTriggerInfo.TabIndex = 24;
            this.lblTriggerInfo.MouseEnter += new System.EventHandler(this.LblTriggerInfo_MouseEnter);
            this.lblTriggerInfo.MouseLeave += new System.EventHandler(this.LblTriggerInfo_MouseLeave);
            // 
            // teamTypesListView
            // 
            this.teamTypesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.HouseColumnHeader});
            this.teamTypesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamTypesListView.FullRowSelect = true;
            this.teamTypesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.teamTypesListView.HideSelection = false;
            this.teamTypesListView.LabelEdit = true;
            this.teamTypesListView.LabelWrap = false;
            this.teamTypesListView.Location = new System.Drawing.Point(2, 2);
            this.teamTypesListView.Margin = new System.Windows.Forms.Padding(2);
            this.teamTypesListView.MultiSelect = false;
            this.teamTypesListView.Name = "teamTypesListView";
            this.teamTypesListView.ShowItemToolTips = true;
            this.teamTypesListView.Size = new System.Drawing.Size(171, 372);
            this.teamTypesListView.TabIndex = 0;
            this.teamTypesListView.UseCompatibleStateImageBehavior = false;
            this.teamTypesListView.View = System.Windows.Forms.View.Details;
            this.teamTypesListView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.TeamTypesListView_AfterLabelEdit);
            this.teamTypesListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.teamTypesListView_ColumnWidthChanging);
            this.teamTypesListView.SelectedIndexChanged += new System.EventHandler(this.TeamTypesListView_SelectedIndexChanged);
            this.teamTypesListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeamTypesListView_KeyDown);
            this.teamTypesListView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TeamTypesListView_MouseDown);
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Team";
            this.nameColumnHeader.Width = 84;
            // 
            // HouseColumnHeader
            // 
            this.HouseColumnHeader.Text = "House";
            this.HouseColumnHeader.Width = 83;
            // 
            // teamTypesContextMenuStrip
            // 
            this.teamTypesContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.teamTypesContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTeamTypeToolStripMenuItem,
            this.renameTeamTypeToolStripMenuItem,
            this.removeTeamTypeToolStripMenuItem});
            this.teamTypesContextMenuStrip.Name = "teamTypesContextMenuStrip";
            this.teamTypesContextMenuStrip.Size = new System.Drawing.Size(204, 70);
            // 
            // addTeamTypeToolStripMenuItem
            // 
            this.addTeamTypeToolStripMenuItem.Name = "addTeamTypeToolStripMenuItem";
            this.addTeamTypeToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.addTeamTypeToolStripMenuItem.Text = "&Add Team Type (Ctrl+A)";
            this.addTeamTypeToolStripMenuItem.Click += new System.EventHandler(this.AddTeamTypeToolStripMenuItem_Click);
            // 
            // renameTeamTypeToolStripMenuItem
            // 
            this.renameTeamTypeToolStripMenuItem.Name = "renameTeamTypeToolStripMenuItem";
            this.renameTeamTypeToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.renameTeamTypeToolStripMenuItem.Text = "Re&name Team Type (F2)";
            this.renameTeamTypeToolStripMenuItem.Click += new System.EventHandler(this.renameTeamTypeToolStripMenuItem_Click);
            // 
            // removeTeamTypeToolStripMenuItem
            // 
            this.removeTeamTypeToolStripMenuItem.Name = "removeTeamTypeToolStripMenuItem";
            this.removeTeamTypeToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.removeTeamTypeToolStripMenuItem.Text = "&Remove Team Type (Del)";
            this.removeTeamTypeToolStripMenuItem.Click += new System.EventHandler(this.RemoveTeamTypeToolStripMenuItem_Click);
            // 
            // TeamTypesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(875, 416);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 370);
            this.Name = "TeamTypesDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Team Types";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeamTypesDialog_FormClosing);
            this.Shown += new System.EventHandler(this.TeamTypesDialog_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeamTypesDialog_KeyDown);
            this.Resize += new System.EventHandler(this.TeamTypesDialog_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            this.teamTypeTableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.pnlTeams.ResumeLayout(false);
            this.pnlTeams.PerformLayout();
            this.pnlTeamsScroll.ResumeLayout(false);
            this.pnlOrders.ResumeLayout(false);
            this.pnlOrders.PerformLayout();
            this.pnlMissionsScroll.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxAllowedNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecruitPriority)).EndInit();
            this.teamTypesContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.ListView teamTypesListView;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ContextMenuStrip teamTypesContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addTeamTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeTeamTypeToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel teamTypeTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblHouse;
        private System.Windows.Forms.ComboBox cmbHouse;
        private System.Windows.Forms.CheckBox chbRoundabout;
        private System.Windows.Forms.CheckBox chbLearning;
        private System.Windows.Forms.CheckBox chbSuicide;
        private System.Windows.Forms.CheckBox chbAutocreate;
        private System.Windows.Forms.CheckBox chbMercenary;
        private System.Windows.Forms.CheckBox chbReinforcable;
        private System.Windows.Forms.CheckBox chbPrebuilt;
        private System.Windows.Forms.Label lblInitNum;
        private System.Windows.Forms.Label lblMaxAllowed;
        private System.Windows.Forms.Label lblFear;
        private MobiusEditor.Controls.EnhNumericUpDown nudInitNum;
        private MobiusEditor.Controls.EnhNumericUpDown maxAllowedNud;
        private MobiusEditor.Controls.EnhNumericUpDown nudFear;
        private System.Windows.Forms.Label lblWaypoint;
        private System.Windows.Forms.Label lblTrigger;
        private System.Windows.Forms.ComboBox cmbWaypoint;
        private System.Windows.Forms.ComboBox cmbTrigger;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblPriority;
        private MobiusEditor.Controls.EnhNumericUpDown nudRecruitPriority;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnAddTeamType;
        private ToolStripMenuItem renameTeamTypeToolStripMenuItem;
        private ToolTip toolTip1;
        private Panel pnlTeams;
        private Button btnAddTeam;
        private Panel pnlTeamsScroll;
        private Controls.TeamItemsList tilTeams;
        private Panel pnlOrders;
        private Button btnAddMission;
        private Panel pnlMissionsScroll;
        private Controls.MissionItemsList milMissions;
        private Label lblTeams;
        private Label lblOrders;
        private Label lblLine1;
        private Label lblLine2;
        private ColumnHeader HouseColumnHeader;
        private Label lblTriggerInfo;
    }
}