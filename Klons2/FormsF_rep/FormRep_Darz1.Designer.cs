using KlonsLIB.Components;
using KlonsLIB.Data;

namespace KlonsF.FormsReportParams
{
    partial class FormRep_Darz1
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
            KlonsLIB.Components.MyMcComboBox.MyItem myItem17 = new KlonsLIB.Components.MyMcComboBox.MyItem();
            KlonsLIB.Components.MyMcComboBox.MyItem myItem18 = new KlonsLIB.Components.MyMcComboBox.MyItem();
            KlonsLIB.Components.MyMcComboBox.MyItem myItem19 = new KlonsLIB.Components.MyMcComboBox.MyItem();
            KlonsLIB.Components.MyMcComboBox.MyItem myItem20 = new KlonsLIB.Components.MyMcComboBox.MyItem();
            KlonsLIB.Components.MyMcComboBox.MyItem myItem21 = new KlonsLIB.Components.MyMcComboBox.MyItem();
            KlonsLIB.Components.MyMcComboBox.MyItem myItem22 = new KlonsLIB.Components.MyMcComboBox.MyItem();
            KlonsLIB.Components.MyMcComboBox.MyItem myItem23 = new KlonsLIB.Components.MyMcComboBox.MyItem();
            KlonsLIB.Components.MyMcComboBox.MyItem myItem24 = new KlonsLIB.Components.MyMcComboBox.MyItem();
            KlonsLIB.Components.MyMcComboBox.MyItem myItem25 = new KlonsLIB.Components.MyMcComboBox.MyItem();
            KlonsLIB.Components.MyMcComboBox.MyItem myItem26 = new KlonsLIB.Components.MyMcComboBox.MyItem();
            KlonsLIB.Components.MyMcComboBox.MyItem myItem27 = new KlonsLIB.Components.MyMcComboBox.MyItem();
            KlonsLIB.Components.MyMcComboBox.MyItem myItem28 = new KlonsLIB.Components.MyMcComboBox.MyItem();
            KlonsLIB.Components.MyMcComboBox.MyItem myItem29 = new KlonsLIB.Components.MyMcComboBox.MyItem();
            KlonsLIB.Components.MyMcComboBox.MyItem myItem30 = new KlonsLIB.Components.MyMcComboBox.MyItem();
            KlonsLIB.Components.MyMcComboBox.MyItem myItem31 = new KlonsLIB.Components.MyMcComboBox.MyItem();
            KlonsLIB.Components.MyMcComboBox.MyItem myItem32 = new KlonsLIB.Components.MyMcComboBox.MyItem();
            this.bsAC = new KlonsLIB.Data.MyBindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cmDoIt = new System.Windows.Forms.Button();
            this.cbYear = new KlonsLIB.Components.MyMcFlatComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMonth = new KlonsLIB.Components.MyMcFlatComboBox();
            this.lbCM = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFilter = new KlonsLIB.Components.MyMcFlatComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsAC)).BeginInit();
            this.SuspendLayout();
            // 
            // bsAC
            // 
            this.bsAC.DataMember = "AcP21";
            this.bsAC.MyDataSource = "KlonsData";
            this.bsAC.Name2 = "bsAC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gads:";
            // 
            // cmDoIt
            // 
            this.cmDoIt.Location = new System.Drawing.Point(306, 138);
            this.cmDoIt.Margin = new System.Windows.Forms.Padding(2);
            this.cmDoIt.Name = "cmDoIt";
            this.cmDoIt.Size = new System.Drawing.Size(150, 63);
            this.cmDoIt.TabIndex = 3;
            this.cmDoIt.Text = "Taisīt atskaiti";
            this.cmDoIt.UseVisualStyleBackColor = true;
            this.cmDoIt.Click += new System.EventHandler(this.cmDoIt_Click);
            this.cmDoIt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // cbYear
            // 
            this.cbYear.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbYear.ColumnNames = new string[] {
        "col1"};
            this.cbYear.ColumnWidths = "58";
            this.cbYear.DisplayMember = "col1";
            this.cbYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbYear.DropDownHeight = 315;
            this.cbYear.DropDownWidth = 86;
            this.cbYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.GridLineColor = System.Drawing.Color.LightGray;
            this.cbYear.GridLineHorizontal = false;
            this.cbYear.GridLineVertical = false;
            this.cbYear.IntegralHeight = false;
            myItem17.Col1 = "2014";
            myItem18.Col1 = "2015";
            this.cbYear.Items.AddRange(new object[] {
            myItem17,
            myItem18});
            this.cbYear.ItemStrings = new string[] {
        "2014",
        "2015"};
            this.cbYear.Location = new System.Drawing.Point(79, 45);
            this.cbYear.Margin = new System.Windows.Forms.Padding(2);
            this.cbYear.MaxDropDownItems = 15;
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(80, 27);
            this.cbYear.TabIndex = 0;
            this.cbYear.ValueMember = "col1";
            this.cbYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "mēnesis:";
            // 
            // cbMonth
            // 
            this.cbMonth.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbMonth.ColumnNames = new string[] {
        "col1"};
            this.cbMonth.ColumnWidths = "58";
            this.cbMonth.DisplayMember = "col1";
            this.cbMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMonth.DropDownHeight = 315;
            this.cbMonth.DropDownStyle = KlonsLIB.Components.MyMcComboBox.CustomDropDownStyle.DropDownListSimple;
            this.cbMonth.DropDownWidth = 86;
            this.cbMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.GridLineColor = System.Drawing.Color.LightGray;
            this.cbMonth.GridLineHorizontal = false;
            this.cbMonth.GridLineVertical = false;
            this.cbMonth.IntegralHeight = false;
            myItem19.Col1 = "01";
            myItem20.Col1 = "02";
            myItem21.Col1 = "03";
            myItem22.Col1 = "04";
            myItem23.Col1 = "05";
            myItem24.Col1 = "06";
            myItem25.Col1 = "07";
            myItem26.Col1 = "08";
            myItem27.Col1 = "09";
            myItem28.Col1 = "10";
            myItem29.Col1 = "11";
            myItem30.Col1 = "12";
            myItem31.Col1 = "Gads";
            this.cbMonth.Items.AddRange(new object[] {
            myItem19,
            myItem20,
            myItem21,
            myItem22,
            myItem23,
            myItem24,
            myItem25,
            myItem26,
            myItem27,
            myItem28,
            myItem29,
            myItem30,
            myItem31});
            this.cbMonth.ItemStrings = new string[] {
        "01",
        "02",
        "03",
        "04",
        "05",
        "06",
        "07",
        "08",
        "09",
        "10",
        "11",
        "12",
        "Gads"};
            this.cbMonth.Location = new System.Drawing.Point(266, 45);
            this.cbMonth.Margin = new System.Windows.Forms.Padding(2);
            this.cbMonth.MaxDropDownItems = 15;
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(80, 27);
            this.cbMonth.TabIndex = 1;
            this.cbMonth.ValueMember = "col1";
            this.cbMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // lbCM
            // 
            this.lbCM.BackColor = System.Drawing.SystemColors.Control;
            this.lbCM.FormattingEnabled = true;
            this.lbCM.ItemHeight = 20;
            this.lbCM.Items.AddRange(new object[] {
            "IIN maksātājam, no 01.06.2022",
            "IIN maksātājam, no 01.07.2018",
            "IIN maksātājam",
            "MUN maksātājam"});
            this.lbCM.Location = new System.Drawing.Point(20, 138);
            this.lbCM.Margin = new System.Windows.Forms.Padding(2);
            this.lbCM.Name = "lbCM";
            this.lbCM.Size = new System.Drawing.Size(268, 84);
            this.lbCM.TabIndex = 4;
            this.lbCM.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbCM_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filtrs";
            // 
            // cbFilter
            // 
            this.cbFilter.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbFilter.ColumnNames = new string[] {
        "col1"};
            this.cbFilter.ColumnWidths = "62";
            this.cbFilter.DisplayMember = "col1";
            this.cbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilter.DropDownHeight = 315;
            this.cbFilter.DropDownStyle = KlonsLIB.Components.MyMcComboBox.CustomDropDownStyle.DropDownListSimple;
            this.cbFilter.DropDownWidth = 90;
            this.cbFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.GridLineColor = System.Drawing.Color.LightGray;
            this.cbFilter.GridLineHorizontal = false;
            this.cbFilter.GridLineVertical = false;
            this.cbFilter.IntegralHeight = false;
            myItem32.Col1 = "*";
            this.cbFilter.Items.AddRange(new object[] {
            myItem32});
            this.cbFilter.ItemStrings = new string[] {
        "*"};
            this.cbFilter.Location = new System.Drawing.Point(79, 86);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cbFilter.MaxDropDownItems = 15;
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(90, 27);
            this.cbFilter.TabIndex = 2;
            this.cbFilter.ValueMember = "col1";
            this.cbFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // FormRep_Darz1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 268);
            this.CloseOnEscape = true;
            this.Controls.Add(this.lbCM);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.cmDoIt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormRep_Darz1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Saimniecisko darijumu uzskaites žurnāls";
            this.Load += new System.EventHandler(this.FormRepApgr1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsAC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyBindingSource bsAC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmDoIt;
        private MyMcFlatComboBox cbYear;
        private System.Windows.Forms.Label label2;
        private MyMcFlatComboBox cbMonth;
        private System.Windows.Forms.ListBox lbCM;
        private System.Windows.Forms.Label label3;
        private MyMcFlatComboBox cbFilter;
    }
}