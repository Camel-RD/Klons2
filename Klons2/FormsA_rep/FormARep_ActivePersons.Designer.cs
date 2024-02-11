namespace KlonsA.Forms
{
    partial class FormARep_ActivePersons
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmTable = new System.Windows.Forms.Button();
            this.tbDate1 = new KlonsLIB.Components.MyTextBox();
            this.tbDate2 = new KlonsLIB.Components.MyTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRows = new KlonsLIB.Components.MyDataGridView();
            this.bsRows = new System.Windows.Forms.BindingSource(this.components);
            this.dgcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcHired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcFired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcHiredDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcVacDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcSickDaysA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcSickDaysB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcVacDaysOther = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcSickDaysInVac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRows)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmTable);
            this.panel1.Controls.Add(this.tbDate1);
            this.panel1.Controls.Add(this.tbDate2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 39);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "-";
            // 
            // cmTable
            // 
            this.cmTable.Location = new System.Drawing.Point(377, 2);
            this.cmTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmTable.Name = "cmTable";
            this.cmTable.Size = new System.Drawing.Size(75, 35);
            this.cmTable.TabIndex = 2;
            this.cmTable.Text = "Atlasīt";
            this.cmTable.UseVisualStyleBackColor = true;
            this.cmTable.Click += new System.EventHandler(this.cmTable_Click);
            // 
            // tbDate1
            // 
            this.tbDate1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbDate1.IsDate = true;
            this.tbDate1.Location = new System.Drawing.Point(151, 7);
            this.tbDate1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDate1.Name = "tbDate1";
            this.tbDate1.Size = new System.Drawing.Size(101, 26);
            this.tbDate1.TabIndex = 0;
            // 
            // tbDate2
            // 
            this.tbDate2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbDate2.IsDate = true;
            this.tbDate2.Location = new System.Drawing.Point(270, 7);
            this.tbDate2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDate2.Name = "tbDate2";
            this.tbDate2.Size = new System.Drawing.Size(101, 26);
            this.tbDate2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datums, no - līdz:";
            // 
            // dgvRows
            // 
            this.dgvRows.AutoGenerateColumns = false;
            this.dgvRows.AutoSave = false;
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
            this.dgcName,
            this.dgcHired,
            this.dgcFired,
            this.dgcHiredDays,
            this.dgcVacDays,
            this.dgcSickDaysA,
            this.dgcSickDaysB,
            this.dgcVacDaysOther,
            this.dgcSickDaysInVac});
            this.dgvRows.DataSource = this.bsRows;
            this.dgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRows.Location = new System.Drawing.Point(0, 39);
            this.dgvRows.Name = "dgvRows";
            this.dgvRows.ReadOnly = true;
            this.dgvRows.RowHeadersWidth = 30;
            this.dgvRows.RowTemplate.Height = 28;
            this.dgvRows.Size = new System.Drawing.Size(1213, 481);
            this.dgvRows.TabIndex = 1;
            // 
            // dgcName
            // 
            this.dgcName.DataPropertyName = "Name";
            this.dgcName.Frozen = true;
            this.dgcName.HeaderText = "darbinieks";
            this.dgcName.MinimumWidth = 8;
            this.dgcName.Name = "dgcName";
            this.dgcName.ReadOnly = true;
            this.dgcName.Width = 250;
            // 
            // dgcHired
            // 
            this.dgcHired.DataPropertyName = "Hired";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "dd.MM.yyyy";
            this.dgcHired.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgcHired.HeaderText = "pieņemts";
            this.dgcHired.MinimumWidth = 8;
            this.dgcHired.Name = "dgcHired";
            this.dgcHired.ReadOnly = true;
            this.dgcHired.Width = 101;
            // 
            // dgcFired
            // 
            this.dgcFired.DataPropertyName = "FIred";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "dd.MM.yyyy";
            this.dgcFired.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgcFired.HeaderText = "atlaists";
            this.dgcFired.MinimumWidth = 8;
            this.dgcFired.Name = "dgcFired";
            this.dgcFired.ReadOnly = true;
            this.dgcFired.Width = 101;
            // 
            // dgcHiredDays
            // 
            this.dgcHiredDays.DataPropertyName = "HiredDays";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "0;-0;\"\"";
            this.dgcHiredDays.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgcHiredDays.HeaderText = "līguma dienas";
            this.dgcHiredDays.MinimumWidth = 8;
            this.dgcHiredDays.Name = "dgcHiredDays";
            this.dgcHiredDays.ReadOnly = true;
            this.dgcHiredDays.Width = 90;
            // 
            // dgcVacDays
            // 
            this.dgcVacDays.DataPropertyName = "VacDays";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "0;-0;\"\"";
            this.dgcVacDays.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgcVacDays.HeaderText = "ikgadējais atvaļinājums - slimības";
            this.dgcVacDays.MinimumWidth = 8;
            this.dgcVacDays.Name = "dgcVacDays";
            this.dgcVacDays.ReadOnly = true;
            this.dgcVacDays.Width = 120;
            // 
            // dgcSickDaysA
            // 
            this.dgcSickDaysA.DataPropertyName = "SickDaysA";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "0;-0;\"\"";
            this.dgcSickDaysA.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgcSickDaysA.HeaderText = "slimības lapa A";
            this.dgcSickDaysA.MinimumWidth = 8;
            this.dgcSickDaysA.Name = "dgcSickDaysA";
            this.dgcSickDaysA.ReadOnly = true;
            this.dgcSickDaysA.Width = 120;
            // 
            // dgcSickDaysB
            // 
            this.dgcSickDaysB.DataPropertyName = "SickDaysB";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "0;-0;\"\"";
            this.dgcSickDaysB.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgcSickDaysB.HeaderText = "slimības lapa B";
            this.dgcSickDaysB.MinimumWidth = 8;
            this.dgcSickDaysB.Name = "dgcSickDaysB";
            this.dgcSickDaysB.ReadOnly = true;
            this.dgcSickDaysB.Width = 120;
            // 
            // dgcVacDaysOther
            // 
            this.dgcVacDaysOther.DataPropertyName = "OtherVacDays";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Format = "0;-0;\"\"";
            this.dgcVacDaysOther.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgcVacDaysOther.HeaderText = "citi atvaļinājumi";
            this.dgcVacDaysOther.MinimumWidth = 8;
            this.dgcVacDaysOther.Name = "dgcVacDaysOther";
            this.dgcVacDaysOther.ReadOnly = true;
            this.dgcVacDaysOther.Width = 120;
            // 
            // dgcSickDaysInVac
            // 
            this.dgcSickDaysInVac.DataPropertyName = "SickDaysInVac";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Format = "0;-0;\"\"";
            this.dgcSickDaysInVac.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgcSickDaysInVac.HeaderText = "slimo atvaļinājumā";
            this.dgcSickDaysInVac.MinimumWidth = 8;
            this.dgcSickDaysInVac.Name = "dgcSickDaysInVac";
            this.dgcSickDaysInVac.ReadOnly = true;
            this.dgcSickDaysInVac.Width = 120;
            // 
            // FormARep_ActivePersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 520);
            this.Controls.Add(this.dgvRows);
            this.Controls.Add(this.panel1);
            this.Name = "FormARep_ActivePersons";
            this.Text = "Strādājošo pārskats";
            this.Load += new System.EventHandler(this.FormARep_ActivePersons_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRows)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private KlonsLIB.Components.MyTextBox tbDate1;
        private KlonsLIB.Components.MyTextBox tbDate2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmTable;
        private System.Windows.Forms.Label label2;
        private KlonsLIB.Components.MyDataGridView dgvRows;
        private System.Windows.Forms.BindingSource bsRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcHired;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcFired;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcHiredDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcVacDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSickDaysA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSickDaysB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcVacDaysOther;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSickDaysInVac;
    }
}