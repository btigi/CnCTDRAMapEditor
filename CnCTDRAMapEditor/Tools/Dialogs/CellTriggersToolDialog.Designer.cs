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
namespace MobiusEditor.Tools.Dialogs
{
    partial class CellTriggersToolDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.triggerComboBox = new System.Windows.Forms.ComboBox();
            this.lblTriggerInfo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnJumpTo = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Controls.Add(this.btnJumpTo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.triggerComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTriggerInfo, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 65);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trigger";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // triggerComboBox
            // 
            this.triggerComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.triggerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.triggerComboBox.FormattingEnabled = true;
            this.triggerComboBox.Location = new System.Drawing.Point(72, 3);
            this.triggerComboBox.Name = "triggerComboBox";
            this.triggerComboBox.Size = new System.Drawing.Size(146, 21);
            this.triggerComboBox.TabIndex = 1;
            // 
            // lblTriggerInfo
            // 
            this.lblTriggerInfo.AutoSize = true;
            this.lblTriggerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTriggerInfo.Location = new System.Drawing.Point(221, 0);
            this.lblTriggerInfo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTriggerInfo.Name = "lblTriggerInfo";
            this.lblTriggerInfo.Size = new System.Drawing.Size(29, 27);
            this.lblTriggerInfo.TabIndex = 10;
            this.lblTriggerInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTriggerInfo.MouseEnter += new System.EventHandler(this.LblTriggerInfo_MouseEnter);
            this.lblTriggerInfo.MouseLeave += new System.EventHandler(this.LblTriggerInfo_MouseLeave);
            // 
            // btnJumpTo
            // 
            this.btnJumpTo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJumpTo.Location = new System.Drawing.Point(72, 30);
            this.btnJumpTo.Name = "btnJumpTo";
            this.btnJumpTo.Size = new System.Drawing.Size(146, 23);
            this.btnJumpTo.TabIndex = 11;
            this.btnJumpTo.Text = "Jump to next usage";
            this.btnJumpTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJumpTo.UseVisualStyleBackColor = true;
            // 
            // CellTriggersToolDialog
            //
            this.AcceptButton = this.btnJumpTo;
            this.ClientSize = new System.Drawing.Size(250, 65);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(210, 30);
            this.Name = "CellTriggersToolDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cell Triggers";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox triggerComboBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblTriggerInfo;
        private System.Windows.Forms.Button btnJumpTo;
    }
}