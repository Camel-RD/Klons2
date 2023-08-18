
namespace KlonsF.FormsReportParams
{
    partial class FormRep_PersonsDocs
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.dgvRows = new KlonsLIB.Components.MyDataGridView();
            this.dgcCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcDocSr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcDocNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcDeb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcCred = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRows)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(21, 20);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "...";
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
            this.dgcDate,
            this.dgcDocSr,
            this.dgcDocNr,
            this.dgcDeb,
            this.dgcCred});
            this.dgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRows.Location = new System.Drawing.Point(0, 20);
            this.dgvRows.Name = "dgvRows";
            this.dgvRows.ReadOnly = true;
            this.dgvRows.RowHeadersWidth = 20;
            this.dgvRows.RowTemplate.Height = 28;
            this.dgvRows.ShowCellToolTips = false;
            this.dgvRows.Size = new System.Drawing.Size(941, 384);
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
            this.dgcCode.Width = 120;
            // 
            // dgcName
            // 
            this.dgcName.DataPropertyName = "Name";
            this.dgcName.HeaderText = "nosaukume";
            this.dgcName.MinimumWidth = 8;
            this.dgcName.Name = "dgcName";
            this.dgcName.ReadOnly = true;
            this.dgcName.Width = 300;
            // 
            // dgcDate
            // 
            this.dgcDate.DataPropertyName = "Dt";
            dataGridViewCellStyle1.Format = "dd.MM.yyyy";
            this.dgcDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgcDate.HeaderText = "datums";
            this.dgcDate.MinimumWidth = 8;
            this.dgcDate.Name = "dgcDate";
            this.dgcDate.ReadOnly = true;
            this.dgcDate.Width = 95;
            // 
            // dgcDocSr
            // 
            this.dgcDocSr.DataPropertyName = "DocSr";
            this.dgcDocSr.HeaderText = "sērija";
            this.dgcDocSr.MinimumWidth = 8;
            this.dgcDocSr.Name = "dgcDocSr";
            this.dgcDocSr.ReadOnly = true;
            this.dgcDocSr.Width = 60;
            // 
            // dgcDocNr
            // 
            this.dgcDocNr.DataPropertyName = "DocNr";
            this.dgcDocNr.HeaderText = "numurs";
            this.dgcDocNr.MinimumWidth = 8;
            this.dgcDocNr.Name = "dgcDocNr";
            this.dgcDocNr.ReadOnly = true;
            this.dgcDocNr.Width = 120;
            // 
            // dgcDeb
            // 
            this.dgcDeb.DataPropertyName = "Deb";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.dgcDeb.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgcDeb.HeaderText = "debetā";
            this.dgcDeb.MinimumWidth = 8;
            this.dgcDeb.Name = "dgcDeb";
            this.dgcDeb.ReadOnly = true;
            this.dgcDeb.Width = 95;
            // 
            // dgcCred
            // 
            this.dgcCred.DataPropertyName = "Cred";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.dgcCred.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgcCred.HeaderText = "kredītā";
            this.dgcCred.MinimumWidth = 8;
            this.dgcCred.Name = "dgcCred";
            this.dgcCred.ReadOnly = true;
            this.dgcCred.Width = 95;
            // 
            // FormRep_PersonsDocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 404);
            this.Controls.Add(this.dgvRows);
            this.Controls.Add(this.lbTitle);
            this.Name = "FormRep_PersonsDocs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rēķinu pārskats";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private KlonsLIB.Components.MyDataGridView dgvRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocSr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDeb;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCred;
    }
}