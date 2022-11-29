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
namespace MobiusEditor.Controls
{
    partial class RulesSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RulesSettings));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRaRules = new System.Windows.Forms.Label();
            this.txtRules = new System.Windows.Forms.TextBox();
            this.lblDosContent = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblRaRules, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtRules, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDosContent, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 424);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblRaRules
            // 
            this.lblRaRules.AutoSize = true;
            this.lblRaRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRaRules.Location = new System.Drawing.Point(3, 67);
            this.lblRaRules.Name = "lblRaRules";
            this.lblRaRules.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.lblRaRules.Size = new System.Drawing.Size(394, 15);
            this.lblRaRules.TabIndex = 0;
            this.lblRaRules.Text = "Rule changes concerning bibs, power and silo storage will be applied in the edito" +
    "r.";
            // 
            // txtRules
            // 
            this.txtRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRules.Location = new System.Drawing.Point(2, 84);
            this.txtRules.Margin = new System.Windows.Forms.Padding(2);
            this.txtRules.Multiline = true;
            this.txtRules.Name = "txtRules";
            this.txtRules.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRules.Size = new System.Drawing.Size(396, 338);
            this.txtRules.TabIndex = 1;
            this.txtRules.Leave += new System.EventHandler(this.txtRules_Leave);
            // 
            // lblDosContent
            // 
            this.lblDosContent.AutoSize = true;
            this.lblDosContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDosContent.Location = new System.Drawing.Point(3, 0);
            this.lblDosContent.Name = "lblDosContent";
            this.lblDosContent.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.lblDosContent.Size = new System.Drawing.Size(394, 67);
            this.lblDosContent.TabIndex = 2;
            this.lblDosContent.Text = resources.GetString("lblDosContent.Text");
            // 
            // RulesSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RulesSettings";
            this.Size = new System.Drawing.Size(400, 424);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDosContent;
        private System.Windows.Forms.Label lblRaRules;
        private System.Windows.Forms.TextBox txtRules;
    }
}
