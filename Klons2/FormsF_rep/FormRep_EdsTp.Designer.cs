
namespace KlonsF.FormsReportParams
{
    partial class FormRep_EdsTp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbReport = new KlonsLIB.Components.FlatComboBox();
            this.btImport = new System.Windows.Forms.Button();
            this.cbYear = new KlonsLIB.Components.FlatComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRows = new KlonsLIB.Components.MyDataGridView();
            this.dgcTitleShort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcMp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcM1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcM2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcM3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcM4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcM5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcM6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcM7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcM8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcM9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcM10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcM11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcM12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRows)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbReport);
            this.panel1.Controls.Add(this.btImport);
            this.panel1.Controls.Add(this.cbYear);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 39);
            this.panel1.TabIndex = 0;
            // 
            // cbReport
            // 
            this.cbReport.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbReport.FormattingEnabled = true;
            this.cbReport.Items.AddRange(new object[] {
            "Deklarēts",
            "Nokavējuma naudas aprēķins",
            "Iemaksāts",
            "Atmaksāts",
            "Savstarpējais ieskaits",
            "Cits"});
            this.cbReport.Location = new System.Drawing.Point(361, 5);
            this.cbReport.Name = "cbReport";
            this.cbReport.Size = new System.Drawing.Size(277, 28);
            this.cbReport.TabIndex = 3;
            this.cbReport.SelectedIndexChanged += new System.EventHandler(this.cbReport_SelectedIndexChanged);
            // 
            // btImport
            // 
            this.btImport.Location = new System.Drawing.Point(170, 3);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(176, 33);
            this.btImport.TabIndex = 2;
            this.btImport.Text = "Nolasīt mo XML faila";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // cbYear
            // 
            this.cbYear.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(70, 6);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(80, 28);
            this.cbYear.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gads:";
            // 
            // dgvRows
            // 
            this.dgvRows.AllowUserToAddRows = false;
            this.dgvRows.AllowUserToDeleteRows = false;
            this.dgvRows.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRows.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcTitleShort,
            this.dgcMp,
            this.dgcM1,
            this.dgcM2,
            this.dgcM3,
            this.dgcM4,
            this.dgcM5,
            this.dgcM6,
            this.dgcM7,
            this.dgcM8,
            this.dgcM9,
            this.dgcM10,
            this.dgcM11,
            this.dgcM12});
            this.dgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRows.Location = new System.Drawing.Point(0, 39);
            this.dgvRows.Name = "dgvRows";
            this.dgvRows.ReadOnly = true;
            this.dgvRows.RowHeadersWidth = 25;
            this.dgvRows.RowTemplate.Height = 28;
            this.dgvRows.ShowCellToolTips = false;
            this.dgvRows.Size = new System.Drawing.Size(1106, 411);
            this.dgvRows.TabIndex = 1;
            this.dgvRows.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRows_CellFormatting);
            // 
            // dgcTitleShort
            // 
            this.dgcTitleShort.DataPropertyName = "TitleShort";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcTitleShort.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgcTitleShort.Frozen = true;
            this.dgcTitleShort.HeaderText = "nosaukums";
            this.dgcTitleShort.MinimumWidth = 8;
            this.dgcTitleShort.Name = "dgcTitleShort";
            this.dgcTitleShort.ReadOnly = true;
            this.dgcTitleShort.Width = 120;
            // 
            // dgcMp
            // 
            this.dgcMp.DataPropertyName = "Mp";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.dgcMp.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgcMp.HeaderText = "iepriekš.";
            this.dgcMp.MinimumWidth = 8;
            this.dgcMp.Name = "dgcMp";
            this.dgcMp.ReadOnly = true;
            this.dgcMp.Width = 95;
            // 
            // dgcM1
            // 
            this.dgcM1.DataPropertyName = "M1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.dgcM1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgcM1.HeaderText = "01";
            this.dgcM1.MinimumWidth = 8;
            this.dgcM1.Name = "dgcM1";
            this.dgcM1.ReadOnly = true;
            this.dgcM1.Width = 95;
            // 
            // dgcM2
            // 
            this.dgcM2.DataPropertyName = "M2";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.dgcM2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgcM2.HeaderText = "02";
            this.dgcM2.MinimumWidth = 8;
            this.dgcM2.Name = "dgcM2";
            this.dgcM2.ReadOnly = true;
            this.dgcM2.Width = 95;
            // 
            // dgcM3
            // 
            this.dgcM3.DataPropertyName = "M3";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            this.dgcM3.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgcM3.HeaderText = "03";
            this.dgcM3.MinimumWidth = 8;
            this.dgcM3.Name = "dgcM3";
            this.dgcM3.ReadOnly = true;
            this.dgcM3.Width = 95;
            // 
            // dgcM4
            // 
            this.dgcM4.DataPropertyName = "M4";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            this.dgcM4.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgcM4.HeaderText = "04";
            this.dgcM4.MinimumWidth = 8;
            this.dgcM4.Name = "dgcM4";
            this.dgcM4.ReadOnly = true;
            this.dgcM4.Width = 95;
            // 
            // dgcM5
            // 
            this.dgcM5.DataPropertyName = "M5";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            this.dgcM5.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgcM5.HeaderText = "05";
            this.dgcM5.MinimumWidth = 8;
            this.dgcM5.Name = "dgcM5";
            this.dgcM5.ReadOnly = true;
            this.dgcM5.Width = 95;
            // 
            // dgcM6
            // 
            this.dgcM6.DataPropertyName = "M6";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            this.dgcM6.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgcM6.HeaderText = "06";
            this.dgcM6.MinimumWidth = 8;
            this.dgcM6.Name = "dgcM6";
            this.dgcM6.ReadOnly = true;
            this.dgcM6.Width = 95;
            // 
            // dgcM7
            // 
            this.dgcM7.DataPropertyName = "M7";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            this.dgcM7.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgcM7.HeaderText = "07";
            this.dgcM7.MinimumWidth = 8;
            this.dgcM7.Name = "dgcM7";
            this.dgcM7.ReadOnly = true;
            this.dgcM7.Width = 95;
            // 
            // dgcM8
            // 
            this.dgcM8.DataPropertyName = "M8";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N2";
            this.dgcM8.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgcM8.HeaderText = "08";
            this.dgcM8.MinimumWidth = 8;
            this.dgcM8.Name = "dgcM8";
            this.dgcM8.ReadOnly = true;
            this.dgcM8.Width = 95;
            // 
            // dgcM9
            // 
            this.dgcM9.DataPropertyName = "M9";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N2";
            this.dgcM9.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgcM9.HeaderText = "09";
            this.dgcM9.MinimumWidth = 8;
            this.dgcM9.Name = "dgcM9";
            this.dgcM9.ReadOnly = true;
            this.dgcM9.Width = 95;
            // 
            // dgcM10
            // 
            this.dgcM10.DataPropertyName = "M10";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "N2";
            this.dgcM10.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgcM10.HeaderText = "10";
            this.dgcM10.MinimumWidth = 8;
            this.dgcM10.Name = "dgcM10";
            this.dgcM10.ReadOnly = true;
            this.dgcM10.Width = 95;
            // 
            // dgcM11
            // 
            this.dgcM11.DataPropertyName = "M11";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "N2";
            this.dgcM11.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgcM11.HeaderText = "11";
            this.dgcM11.MinimumWidth = 8;
            this.dgcM11.Name = "dgcM11";
            this.dgcM11.ReadOnly = true;
            this.dgcM11.Width = 95;
            // 
            // dgcM12
            // 
            this.dgcM12.DataPropertyName = "M12";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "N2";
            this.dgcM12.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgcM12.HeaderText = "12";
            this.dgcM12.MinimumWidth = 8;
            this.dgcM12.Name = "dgcM12";
            this.dgcM12.ReadOnly = true;
            this.dgcM12.Width = 95;
            // 
            // FormRep_EdsTp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 450);
            this.Controls.Add(this.dgvRows);
            this.Controls.Add(this.panel1);
            this.Name = "FormRep_EdsTp";
            this.Text = "EDS transakciju pārskats";
            this.Load += new System.EventHandler(this.FormRep_EdsTp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRows)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btImport;
        private KlonsLIB.Components.FlatComboBox cbYear;
        private System.Windows.Forms.Label label1;
        private KlonsLIB.Components.MyDataGridView dgvRows;
        private KlonsLIB.Components.FlatComboBox cbReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTitleShort;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcMp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcM1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcM2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcM3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcM4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcM5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcM6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcM7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcM8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcM9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcM10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcM11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcM12;
    }
}