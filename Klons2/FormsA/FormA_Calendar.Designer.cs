﻿namespace KlonsA.Forms
{
    partial class FormA_Calendar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btYR3 = new System.Windows.Forms.Button();
            this.btYR2 = new System.Windows.Forms.Button();
            this.btYR1 = new System.Windows.Forms.Button();
            this.lbDates = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbYR = new KlonsLIB.Components.MyMcFlatComboBox();
            this.grid = new KlonsF.Classes.SourceGridA();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btYR3);
            this.panel1.Controls.Add(this.btYR2);
            this.panel1.Controls.Add(this.btYR1);
            this.panel1.Controls.Add(this.lbDates);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbYR);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 34);
            this.panel1.TabIndex = 0;
            // 
            // btYR3
            // 
            this.btYR3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btYR3.Location = new System.Drawing.Point(190, 3);
            this.btYR3.Margin = new System.Windows.Forms.Padding(0);
            this.btYR3.Name = "btYR3";
            this.btYR3.Size = new System.Drawing.Size(55, 27);
            this.btYR3.TabIndex = 4;
            this.btYR3.Text = "2024";
            this.btYR3.UseVisualStyleBackColor = true;
            this.btYR3.Click += new System.EventHandler(this.btYR3_Click);
            // 
            // btYR2
            // 
            this.btYR2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btYR2.Location = new System.Drawing.Point(133, 3);
            this.btYR2.Margin = new System.Windows.Forms.Padding(0);
            this.btYR2.Name = "btYR2";
            this.btYR2.Size = new System.Drawing.Size(55, 27);
            this.btYR2.TabIndex = 4;
            this.btYR2.Text = "2023";
            this.btYR2.UseVisualStyleBackColor = true;
            this.btYR2.Click += new System.EventHandler(this.btYR2_Click);
            // 
            // btYR1
            // 
            this.btYR1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btYR1.Location = new System.Drawing.Point(76, 3);
            this.btYR1.Margin = new System.Windows.Forms.Padding(0);
            this.btYR1.Name = "btYR1";
            this.btYR1.Size = new System.Drawing.Size(55, 27);
            this.btYR1.TabIndex = 4;
            this.btYR1.Text = "2022";
            this.btYR1.UseVisualStyleBackColor = true;
            this.btYR1.Click += new System.EventHandler(this.btYR1_Click);
            // 
            // lbDates
            // 
            this.lbDates.AutoSize = true;
            this.lbDates.Location = new System.Drawing.Point(375, 6);
            this.lbDates.Name = "lbDates";
            this.lbDates.Size = new System.Drawing.Size(150, 20);
            this.lbDates.TabIndex = 3;
            this.lbDates.Text = "[ peles kreisais klik. ]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gads:";
            // 
            // cbYR
            // 
            this.cbYR.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbYR.ColumnNames = new string[] {
        "Key",
        "Val"};
            this.cbYR.ColumnWidths = "0;62";
            this.cbYR.DisplayMember = "Val";
            this.cbYR.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbYR.DropDownHeight = 210;
            this.cbYR.DropDownWidth = 90;
            this.cbYR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbYR.FormattingEnabled = true;
            this.cbYR.GridLineColor = System.Drawing.Color.LightGray;
            this.cbYR.GridLineHorizontal = false;
            this.cbYR.GridLineVertical = false;
            this.cbYR.IntegralHeight = false;
            this.cbYR.Location = new System.Drawing.Point(256, 4);
            this.cbYR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbYR.MaxDropDownItems = 10;
            this.cbYR.Name = "cbYR";
            this.cbYR.Size = new System.Drawing.Size(90, 27);
            this.cbYR.TabIndex = 1;
            this.cbYR.ValueMember = "Key";
            this.cbYR.SelectedIndexChanged += new System.EventHandler(this.cbYR_SelectedIndexChanged);
            this.cbYR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbYR_KeyDown);
            // 
            // grid
            // 
            this.grid.DefaultHeight = 25;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EnableSort = true;
            this.grid.Location = new System.Drawing.Point(0, 34);
            this.grid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grid.Name = "grid";
            this.grid.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid.Size = new System.Drawing.Size(900, 528);
            this.grid.TabIndex = 1;
            this.grid.TabStop = true;
            this.grid.ToolTipText = "";
            // 
            // FormA_Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormA_Calendar";
            this.Text = "Kalendārs";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private KlonsLIB.Components.MyMcFlatComboBox cbYR;
        private KlonsF.Classes.SourceGridA grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDates;
        private System.Windows.Forms.Button btYR3;
        private System.Windows.Forms.Button btYR2;
        private System.Windows.Forms.Button btYR1;
    }
}