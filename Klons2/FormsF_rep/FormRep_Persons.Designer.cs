﻿using KlonsLIB.Components;
using KlonsLIB.Data;

namespace KlonsF.FormsReportParams
{
    partial class FormRep_Persons
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRep_Persons));
            this.cbAC = new KlonsLIB.Components.MyMcFlatComboBox();
            this.bsAC = new KlonsLIB.Data.MyBindingSource(this.components);
            this.tbSD = new KlonsLIB.Components.MyTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbED = new KlonsLIB.Components.MyTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbACName = new System.Windows.Forms.Label();
            this.cmDoIt = new System.Windows.Forms.Button();
            this.cbClid = new KlonsLIB.Components.MyMcFlatComboBox();
            this.bsClid = new KlonsLIB.Data.MyBindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lbClName = new System.Windows.Forms.Label();
            this.lbCm = new System.Windows.Forms.ListBox();
            this.myLabel1 = new KlonsLIB.Components.MyLabel();
            this.cmShowTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsAC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClid)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAC
            // 
            this.cbAC.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbAC.ColumnNames = new string[] {
        "ac",
        "name"};
            this.cbAC.ColumnWidths = "80;300";
            this.cbAC.DataSource = this.bsAC;
            this.cbAC.DisplayMember = "AC";
            this.cbAC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAC.DropDownHeight = 315;
            this.cbAC.DropDownWidth = 408;
            this.cbAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAC.FormattingEnabled = true;
            this.cbAC.GridLineColor = System.Drawing.Color.LightGray;
            this.cbAC.GridLineHorizontal = false;
            this.cbAC.GridLineVertical = false;
            this.cbAC.IntegralHeight = false;
            this.cbAC.Location = new System.Drawing.Point(161, 51);
            this.cbAC.Margin = new System.Windows.Forms.Padding(2);
            this.cbAC.MaxDropDownItems = 15;
            this.cbAC.Name = "cbAC";
            this.cbAC.Size = new System.Drawing.Size(116, 27);
            this.cbAC.TabIndex = 2;
            this.cbAC.ValueMember = "AC";
            this.cbAC.SelectedIndexChanged += new System.EventHandler(this.cbAC_SelectedIndexChanged);
            this.cbAC.TextChanged += new System.EventHandler(this.cbAC_TextChanged);
            this.cbAC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            this.cbAC.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cbClid_MouseDoubleClick);
            // 
            // bsAC
            // 
            this.bsAC.DataMember = "AcP21";
            this.bsAC.MyDataSource = "KlonsData";
            this.bsAC.Name2 = "bsAC";
            // 
            // tbSD
            // 
            this.tbSD.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbSD.IsDate = true;
            this.tbSD.Location = new System.Drawing.Point(161, 9);
            this.tbSD.Margin = new System.Windows.Forms.Padding(2);
            this.tbSD.Name = "tbSD";
            this.tbSD.Size = new System.Drawing.Size(90, 26);
            this.tbSD.TabIndex = 0;
            this.tbSD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Datums (no - līdz):";
            // 
            // tbED
            // 
            this.tbED.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbED.IsDate = true;
            this.tbED.Location = new System.Drawing.Point(256, 9);
            this.tbED.Margin = new System.Windows.Forms.Padding(2);
            this.tbED.Name = "tbED";
            this.tbED.Size = new System.Drawing.Size(90, 26);
            this.tbED.TabIndex = 1;
            this.tbED.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Konts:";
            // 
            // lbACName
            // 
            this.lbACName.Location = new System.Drawing.Point(282, 54);
            this.lbACName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbACName.Name = "lbACName";
            this.lbACName.Size = new System.Drawing.Size(376, 22);
            this.lbACName.TabIndex = 11;
            this.lbACName.Text = "Konts:";
            // 
            // cmDoIt
            // 
            this.cmDoIt.Location = new System.Drawing.Point(421, 148);
            this.cmDoIt.Margin = new System.Windows.Forms.Padding(2);
            this.cmDoIt.Name = "cmDoIt";
            this.cmDoIt.Size = new System.Drawing.Size(150, 57);
            this.cmDoIt.TabIndex = 4;
            this.cmDoIt.Text = "Taisīt atskaiti";
            this.cmDoIt.UseVisualStyleBackColor = true;
            this.cmDoIt.Click += new System.EventHandler(this.cmDoIt_Click);
            this.cmDoIt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // cbClid
            // 
            this.cbClid.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbClid.ColumnNames = new string[] {
        "clid",
        "name"};
            this.cbClid.ColumnWidths = "120;300";
            this.cbClid.DataSource = this.bsClid;
            this.cbClid.DisplayMember = "clid";
            this.cbClid.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbClid.DropDownHeight = 315;
            this.cbClid.DropDownWidth = 448;
            this.cbClid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbClid.FormattingEnabled = true;
            this.cbClid.GridLineColor = System.Drawing.Color.LightGray;
            this.cbClid.GridLineHorizontal = false;
            this.cbClid.GridLineVertical = false;
            this.cbClid.IntegralHeight = false;
            this.cbClid.Location = new System.Drawing.Point(161, 94);
            this.cbClid.Margin = new System.Windows.Forms.Padding(2);
            this.cbClid.MaxDropDownItems = 15;
            this.cbClid.Name = "cbClid";
            this.cbClid.Size = new System.Drawing.Size(116, 27);
            this.cbClid.TabIndex = 3;
            this.cbClid.ValueMember = "clid";
            this.cbClid.SelectedIndexChanged += new System.EventHandler(this.cbClid_SelectedIndexChanged);
            this.cbClid.TextChanged += new System.EventHandler(this.cbClid_TextChanged);
            this.cbClid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            this.cbClid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cbClid_MouseDoubleClick);
            // 
            // bsClid
            // 
            this.bsClid.DataMember = "Persons";
            this.bsClid.MyDataSource = "KlonsData";
            this.bsClid.Name2 = "bsClid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Persona:";
            // 
            // lbClName
            // 
            this.lbClName.Location = new System.Drawing.Point(282, 98);
            this.lbClName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbClName.Name = "lbClName";
            this.lbClName.Size = new System.Drawing.Size(376, 22);
            this.lbClName.TabIndex = 12;
            this.lbClName.Text = "Konts:";
            // 
            // lbCm
            // 
            this.lbCm.BackColor = System.Drawing.SystemColors.Control;
            this.lbCm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCm.FormattingEnabled = true;
            this.lbCm.ItemHeight = 20;
            this.lbCm.Items.AddRange(new object[] {
            "Debitoru, kreditoru apgrozijumu pārskats",
            "Debitoru, kreditoru apgrozijumu pārskats pa kontiem",
            "Rēķinu saraksts",
            "Rēķinu un maksājumu saraksts",
            "Neapmaksātie rēķini",
            "Neapmaksātie rēķini - līdz norādītajam datumam"});
            this.lbCm.Location = new System.Drawing.Point(15, 148);
            this.lbCm.Margin = new System.Windows.Forms.Padding(2);
            this.lbCm.Name = "lbCm";
            this.lbCm.Size = new System.Drawing.Size(380, 122);
            this.lbCm.TabIndex = 6;
            this.lbCm.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbCm_MouseDoubleClick);
            // 
            // myLabel1
            // 
            this.myLabel1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.myLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myLabel1.Location = new System.Drawing.Point(11, 296);
            this.myLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Padding = new System.Windows.Forms.Padding(2);
            this.myLabel1.Size = new System.Drawing.Size(540, 98);
            this.myLabel1.TabIndex = 10;
            this.myLabel1.Text = resources.GetString("myLabel1.Text");
            // 
            // cmShowTable
            // 
            this.cmShowTable.Location = new System.Drawing.Point(421, 213);
            this.cmShowTable.Margin = new System.Windows.Forms.Padding(2);
            this.cmShowTable.Name = "cmShowTable";
            this.cmShowTable.Size = new System.Drawing.Size(150, 57);
            this.cmShowTable.TabIndex = 5;
            this.cmShowTable.Text = "Tabula";
            this.cmShowTable.UseVisualStyleBackColor = true;
            this.cmShowTable.Click += new System.EventHandler(this.cmShowTable_Click);
            this.cmShowTable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // FormRep_Persons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 405);
            this.CloseOnEscape = true;
            this.Controls.Add(this.myLabel1);
            this.Controls.Add(this.lbCm);
            this.Controls.Add(this.cmShowTable);
            this.Controls.Add(this.cmDoIt);
            this.Controls.Add(this.lbClName);
            this.Controls.Add(this.lbACName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbED);
            this.Controls.Add(this.tbSD);
            this.Controls.Add(this.cbClid);
            this.Controls.Add(this.cbAC);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormRep_Persons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Personu pārskati";
            this.Load += new System.EventHandler(this.FormRepKoresp1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsAC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyMcFlatComboBox cbAC;
        private MyBindingSource bsAC;
        private MyTextBox tbSD;
        private System.Windows.Forms.Label label1;
        private MyTextBox tbED;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbACName;
        private System.Windows.Forms.Button cmDoIt;
        private MyMcFlatComboBox cbClid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbClName;
        private MyBindingSource bsClid;
        private System.Windows.Forms.ListBox lbCm;
        private MyLabel myLabel1;
        private System.Windows.Forms.Button cmShowTable;
    }
}