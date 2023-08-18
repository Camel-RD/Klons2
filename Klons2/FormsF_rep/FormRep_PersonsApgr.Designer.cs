
namespace KlonsF.FormsReportParams
{
    partial class FormRep_PersonsApgr
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRows = new KlonsLIB.Components.MyDataGridView();
            this.dgcCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcDeb0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcCred0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcDebChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcCredChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcDeb1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcCred1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRows)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRows
            // 
            this.dgvRows.AllowUserToAddRows = false;
            this.dgvRows.AllowUserToDeleteRows = false;
            this.dgvRows.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcCode,
            this.dgcName,
            this.dgcDeb0,
            this.dgcCred0,
            this.dgcDebChange,
            this.dgcCredChange,
            this.dgcDeb1,
            this.dgcCred1});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRows.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRows.Location = new System.Drawing.Point(5, 45);
            this.dgvRows.Name = "dgvRows";
            this.dgvRows.ReadOnly = true;
            this.dgvRows.RowHeadersWidth = 30;
            this.dgvRows.RowTemplate.Height = 28;
            this.dgvRows.ShowCellToolTips = false;
            this.dgvRows.Size = new System.Drawing.Size(985, 400);
            this.dgvRows.TabIndex = 1;
            this.dgvRows.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRows_CellFormatting);
            // 
            // dgcCode
            // 
            this.dgcCode.DataPropertyName = "Code";
            this.dgcCode.HeaderText = "kods";
            this.dgcCode.MinimumWidth = 8;
            this.dgcCode.Name = "dgcCode";
            this.dgcCode.ReadOnly = true;
            this.dgcCode.Width = 110;
            // 
            // dgcName
            // 
            this.dgcName.DataPropertyName = "Name";
            this.dgcName.HeaderText = "nosaukums";
            this.dgcName.MinimumWidth = 8;
            this.dgcName.Name = "dgcName";
            this.dgcName.ReadOnly = true;
            this.dgcName.Width = 240;
            // 
            // dgcDeb0
            // 
            this.dgcDeb0.DataPropertyName = "Deb0";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            this.dgcDeb0.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgcDeb0.HeaderText = "debets sākumā";
            this.dgcDeb0.MinimumWidth = 8;
            this.dgcDeb0.Name = "dgcDeb0";
            this.dgcDeb0.ReadOnly = true;
            this.dgcDeb0.Width = 95;
            // 
            // dgcCred0
            // 
            this.dgcCred0.DataPropertyName = "Cred0";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.dgcCred0.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgcCred0.HeaderText = "kredīts sākumā";
            this.dgcCred0.MinimumWidth = 8;
            this.dgcCred0.Name = "dgcCred0";
            this.dgcCred0.ReadOnly = true;
            this.dgcCred0.Width = 95;
            // 
            // dgcDebChange
            // 
            this.dgcDebChange.DataPropertyName = "DebCh";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.dgcDebChange.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgcDebChange.HeaderText = "debets +/-";
            this.dgcDebChange.MinimumWidth = 8;
            this.dgcDebChange.Name = "dgcDebChange";
            this.dgcDebChange.ReadOnly = true;
            this.dgcDebChange.Width = 95;
            // 
            // dgcCredChange
            // 
            this.dgcCredChange.DataPropertyName = "CredCh";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.dgcCredChange.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgcCredChange.HeaderText = "kredīts +/-";
            this.dgcCredChange.MinimumWidth = 8;
            this.dgcCredChange.Name = "dgcCredChange";
            this.dgcCredChange.ReadOnly = true;
            this.dgcCredChange.Width = 95;
            // 
            // dgcDeb1
            // 
            this.dgcDeb1.DataPropertyName = "Deb1";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.dgcDeb1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgcDeb1.HeaderText = "debets beigās";
            this.dgcDeb1.MinimumWidth = 8;
            this.dgcDeb1.Name = "dgcDeb1";
            this.dgcDeb1.ReadOnly = true;
            this.dgcDeb1.Width = 95;
            // 
            // dgcCred1
            // 
            this.dgcCred1.DataPropertyName = "Cred1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            this.dgcCred1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgcCred1.HeaderText = "kredīts beigās";
            this.dgcCred1.MinimumWidth = 8;
            this.dgcCred1.Name = "dgcCred1";
            this.dgcCred1.ReadOnly = true;
            this.dgcCred1.Width = 95;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Location = new System.Drawing.Point(5, 5);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(45, 40);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "hgfd\r\nfdsaf";
            // 
            // FormRep_PersonsApgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 450);
            this.Controls.Add(this.dgvRows);
            this.Controls.Add(this.lbTitle);
            this.Name = "FormRep_PersonsApgr";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personu apgrozijuma pārskatys";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private KlonsLIB.Components.MyDataGridView dgvRows;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDeb0;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCred0;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDebChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCredChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDeb1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCred1;
    }
}