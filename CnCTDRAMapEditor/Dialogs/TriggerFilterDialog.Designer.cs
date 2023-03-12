﻿namespace MobiusEditor.Dialogs
{
    partial class TriggerFilterDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.triggersTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.chkGlobal = new System.Windows.Forms.CheckBox();
            this.chkTeamType = new System.Windows.Forms.CheckBox();
            this.chkActionType = new System.Windows.Forms.CheckBox();
            this.cmbEventType = new MobiusEditor.Controls.ComboBoxSmartWidth();
            this.cmbActionType = new MobiusEditor.Controls.ComboBoxSmartWidth();
            this.nudGlobal = new MobiusEditor.Controls.EnhNumericUpDown();
            this.cmbTeamType = new MobiusEditor.Controls.ComboBoxSmartWidth();
            this.cmbHouse = new MobiusEditor.Controls.ComboBoxSmartWidth();
            this.cmbPersistenceType = new MobiusEditor.Controls.ComboBoxSmartWidth();
            this.cmbEventControl = new MobiusEditor.Controls.ComboBoxSmartWidth();
            this.chkHouse = new System.Windows.Forms.CheckBox();
            this.chkPersistenceType = new System.Windows.Forms.CheckBox();
            this.chkEventControl = new System.Windows.Forms.CheckBox();
            this.chkEventType = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.triggersTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGlobal)).BeginInit();
            this.SuspendLayout();
            // 
            // triggersTableLayoutPanel
            // 
            this.triggersTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.triggersTableLayoutPanel.AutoSize = true;
            this.triggersTableLayoutPanel.ColumnCount = 2;
            this.triggersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.triggersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.triggersTableLayoutPanel.Controls.Add(this.chkGlobal, 0, 13);
            this.triggersTableLayoutPanel.Controls.Add(this.chkTeamType, 0, 12);
            this.triggersTableLayoutPanel.Controls.Add(this.chkActionType, 0, 11);
            this.triggersTableLayoutPanel.Controls.Add(this.cmbEventType, 1, 10);
            this.triggersTableLayoutPanel.Controls.Add(this.cmbActionType, 1, 11);
            this.triggersTableLayoutPanel.Controls.Add(this.nudGlobal, 1, 13);
            this.triggersTableLayoutPanel.Controls.Add(this.cmbTeamType, 1, 12);
            this.triggersTableLayoutPanel.Controls.Add(this.cmbHouse, 1, 0);
            this.triggersTableLayoutPanel.Controls.Add(this.cmbPersistenceType, 1, 8);
            this.triggersTableLayoutPanel.Controls.Add(this.cmbEventControl, 1, 9);
            this.triggersTableLayoutPanel.Controls.Add(this.chkHouse, 0, 0);
            this.triggersTableLayoutPanel.Controls.Add(this.chkPersistenceType, 0, 8);
            this.triggersTableLayoutPanel.Controls.Add(this.chkEventControl, 0, 9);
            this.triggersTableLayoutPanel.Controls.Add(this.chkEventType, 0, 10);
            this.triggersTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.triggersTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.triggersTableLayoutPanel.Name = "triggersTableLayoutPanel";
            this.triggersTableLayoutPanel.RowCount = 14;
            this.triggersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.triggersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.triggersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.triggersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.triggersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.triggersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.triggersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.triggersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.triggersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.triggersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.triggersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.triggersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.triggersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.triggersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.triggersTableLayoutPanel.Size = new System.Drawing.Size(265, 175);
            this.triggersTableLayoutPanel.TabIndex = 2;
            // 
            // chkGlobal
            // 
            this.chkGlobal.AutoSize = true;
            this.chkGlobal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkGlobal.Location = new System.Drawing.Point(3, 153);
            this.chkGlobal.Name = "chkGlobal";
            this.chkGlobal.Size = new System.Drawing.Size(100, 19);
            this.chkGlobal.TabIndex = 12;
            this.chkGlobal.Text = "Global";
            this.chkGlobal.UseVisualStyleBackColor = true;
            this.chkGlobal.CheckedChanged += new System.EventHandler(this.ChkGlobal_CheckedChanged);
            // 
            // chkTeamType
            // 
            this.chkTeamType.AutoSize = true;
            this.chkTeamType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkTeamType.Location = new System.Drawing.Point(3, 128);
            this.chkTeamType.Name = "chkTeamType";
            this.chkTeamType.Size = new System.Drawing.Size(100, 19);
            this.chkTeamType.TabIndex = 10;
            this.chkTeamType.Text = "Team";
            this.chkTeamType.UseVisualStyleBackColor = true;
            this.chkTeamType.CheckedChanged += new System.EventHandler(this.ChkTeamType_CheckedChanged);
            // 
            // chkActionType
            // 
            this.chkActionType.AutoSize = true;
            this.chkActionType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkActionType.Location = new System.Drawing.Point(3, 103);
            this.chkActionType.Name = "chkActionType";
            this.chkActionType.Size = new System.Drawing.Size(100, 19);
            this.chkActionType.TabIndex = 8;
            this.chkActionType.Text = "Action";
            this.chkActionType.UseVisualStyleBackColor = true;
            this.chkActionType.CheckedChanged += new System.EventHandler(this.ChkActionType_CheckedChanged);
            // 
            // cmbEventType
            // 
            this.cmbEventType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbEventType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEventType.Enabled = false;
            this.cmbEventType.FormattingEnabled = true;
            this.cmbEventType.Location = new System.Drawing.Point(108, 77);
            this.cmbEventType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEventType.Name = "cmbEventType";
            this.cmbEventType.Size = new System.Drawing.Size(155, 21);
            this.cmbEventType.TabIndex = 7;
            // 
            // cmbActionType
            // 
            this.cmbActionType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbActionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActionType.Enabled = false;
            this.cmbActionType.FormattingEnabled = true;
            this.cmbActionType.Location = new System.Drawing.Point(108, 102);
            this.cmbActionType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbActionType.Name = "cmbActionType";
            this.cmbActionType.Size = new System.Drawing.Size(155, 21);
            this.cmbActionType.TabIndex = 9;
            // 
            // nudGlobal
            // 
            this.nudGlobal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudGlobal.Enabled = false;
            this.nudGlobal.EnteredValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudGlobal.IntValue = 0;
            this.nudGlobal.Location = new System.Drawing.Point(108, 152);
            this.nudGlobal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 3);
            this.nudGlobal.Maximum = new decimal(new int[] {
            29,
            0,
            0,
            0});
            this.nudGlobal.Name = "nudGlobal";
            this.nudGlobal.SelectedText = "";
            this.nudGlobal.SelectionLength = 0;
            this.nudGlobal.SelectionStart = 0;
            this.nudGlobal.Size = new System.Drawing.Size(155, 20);
            this.nudGlobal.TabIndex = 13;
            // 
            // cmbTeamType
            // 
            this.cmbTeamType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbTeamType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeamType.Enabled = false;
            this.cmbTeamType.FormattingEnabled = true;
            this.cmbTeamType.Location = new System.Drawing.Point(108, 127);
            this.cmbTeamType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTeamType.Name = "cmbTeamType";
            this.cmbTeamType.Size = new System.Drawing.Size(155, 21);
            this.cmbTeamType.TabIndex = 11;
            // 
            // cmbHouse
            // 
            this.cmbHouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHouse.Enabled = false;
            this.cmbHouse.FormattingEnabled = true;
            this.cmbHouse.Location = new System.Drawing.Point(108, 2);
            this.cmbHouse.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHouse.Name = "cmbHouse";
            this.cmbHouse.Size = new System.Drawing.Size(155, 21);
            this.cmbHouse.TabIndex = 1;
            // 
            // cmbPersistenceType
            // 
            this.cmbPersistenceType.DisplayMember = "Label";
            this.cmbPersistenceType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPersistenceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersistenceType.Enabled = false;
            this.cmbPersistenceType.FormattingEnabled = true;
            this.cmbPersistenceType.Location = new System.Drawing.Point(108, 27);
            this.cmbPersistenceType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPersistenceType.Name = "cmbPersistenceType";
            this.cmbPersistenceType.Size = new System.Drawing.Size(155, 21);
            this.cmbPersistenceType.TabIndex = 3;
            this.cmbPersistenceType.ValueMember = "Value";
            // 
            // cmbEventControl
            // 
            this.cmbEventControl.DisplayMember = "Label";
            this.cmbEventControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbEventControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEventControl.Enabled = false;
            this.cmbEventControl.FormattingEnabled = true;
            this.cmbEventControl.Location = new System.Drawing.Point(108, 52);
            this.cmbEventControl.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEventControl.Name = "cmbEventControl";
            this.cmbEventControl.Size = new System.Drawing.Size(155, 21);
            this.cmbEventControl.TabIndex = 5;
            this.cmbEventControl.ValueMember = "Value";
            // 
            // chkHouse
            // 
            this.chkHouse.AutoSize = true;
            this.chkHouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkHouse.Location = new System.Drawing.Point(3, 3);
            this.chkHouse.Name = "chkHouse";
            this.chkHouse.Size = new System.Drawing.Size(100, 19);
            this.chkHouse.TabIndex = 0;
            this.chkHouse.Text = "House";
            this.chkHouse.UseVisualStyleBackColor = true;
            this.chkHouse.CheckedChanged += new System.EventHandler(this.ChkHouse_CheckedChanged);
            // 
            // chkPersistenceType
            // 
            this.chkPersistenceType.AutoSize = true;
            this.chkPersistenceType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkPersistenceType.Location = new System.Drawing.Point(3, 28);
            this.chkPersistenceType.Name = "chkPersistenceType";
            this.chkPersistenceType.Size = new System.Drawing.Size(100, 19);
            this.chkPersistenceType.TabIndex = 2;
            this.chkPersistenceType.Text = "Persistence";
            this.chkPersistenceType.UseVisualStyleBackColor = true;
            this.chkPersistenceType.CheckedChanged += new System.EventHandler(this.ChkPersistenceType_CheckedChanged);
            // 
            // chkEventControl
            // 
            this.chkEventControl.AutoSize = true;
            this.chkEventControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkEventControl.Location = new System.Drawing.Point(3, 53);
            this.chkEventControl.Name = "chkEventControl";
            this.chkEventControl.Size = new System.Drawing.Size(100, 19);
            this.chkEventControl.TabIndex = 4;
            this.chkEventControl.Text = "Type";
            this.chkEventControl.UseVisualStyleBackColor = true;
            this.chkEventControl.CheckedChanged += new System.EventHandler(this.ChkEventControl_CheckedChanged);
            // 
            // chkEventType
            // 
            this.chkEventType.AutoSize = true;
            this.chkEventType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkEventType.Location = new System.Drawing.Point(3, 78);
            this.chkEventType.Name = "chkEventType";
            this.chkEventType.Size = new System.Drawing.Size(100, 19);
            this.chkEventType.TabIndex = 6;
            this.chkEventType.Text = "Event";
            this.chkEventType.UseVisualStyleBackColor = true;
            this.chkEventType.CheckedChanged += new System.EventHandler(this.ChkEventType_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(184, 182);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(103, 182);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 15;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReset.Location = new System.Drawing.Point(3, 182);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // TriggerFilterDialog
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(264, 211);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.triggersTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(280, 250);
            this.Name = "TriggerFilterDialog";
            this.Text = "Filter triggers";
            this.triggersTableLayoutPanel.ResumeLayout(false);
            this.triggersTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGlobal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel triggersTableLayoutPanel;
        private Controls.ComboBoxSmartWidth cmbHouse;
        private Controls.ComboBoxSmartWidth cmbPersistenceType;
        private Controls.ComboBoxSmartWidth cmbEventControl;
        private Controls.ComboBoxSmartWidth cmbTeamType;
        private Controls.ComboBoxSmartWidth cmbEventType;
        private Controls.ComboBoxSmartWidth cmbActionType;
        private Controls.EnhNumericUpDown nudGlobal;
        private System.Windows.Forms.CheckBox chkHouse;
        private System.Windows.Forms.CheckBox chkPersistenceType;
        private System.Windows.Forms.CheckBox chkTeamType;
        private System.Windows.Forms.CheckBox chkGlobal;
        private System.Windows.Forms.CheckBox chkEventControl;
        private System.Windows.Forms.CheckBox chkEventType;
        private System.Windows.Forms.CheckBox chkActionType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnReset;
    }
}