
namespace KlonsM.FormsM
{
    partial class FormM_DocPricesAndDiscounts
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
            this.dgvRows = new KlonsLIB.Components.MyDataGridView();
            this.DgcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcIsUsed = new KlonsLIB.Components.MyDgvCheckBoxColumn();
            this.btApply = new System.Windows.Forms.Button();
            this.btCheck = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRows)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRows
            // 
            this.dgvRows.AllowUserToAddRows = false;
            this.dgvRows.AllowUserToDeleteRows = false;
            this.dgvRows.AllowUserToResizeRows = false;
            this.dgvRows.AutoSave = false;
            this.dgvRows.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgcName,
            this.dgcIsUsed});
            this.dgvRows.Location = new System.Drawing.Point(1, 2);
            this.dgvRows.Name = "dgvRows";
            this.dgvRows.RowHeadersVisible = false;
            this.dgvRows.RowHeadersWidth = 62;
            this.dgvRows.RowTemplate.Height = 28;
            this.dgvRows.ShowCellToolTips = false;
            this.dgvRows.Size = new System.Drawing.Size(417, 346);
            this.dgvRows.TabIndex = 0;
            this.dgvRows.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRows_CellFormatting);
            // 
            // DgcName
            // 
            this.DgcName.DataPropertyName = "Name";
            this.DgcName.HeaderText = "nosaukums";
            this.DgcName.MinimumWidth = 8;
            this.DgcName.Name = "DgcName";
            this.DgcName.ReadOnly = true;
            this.DgcName.Width = 300;
            // 
            // dgcIsUsed
            // 
            this.dgcIsUsed.DataPropertyName = "IsUsed";
            this.dgcIsUsed.FalseValue = "true";
            this.dgcIsUsed.HeaderText = "piemērot";
            this.dgcIsUsed.MinimumWidth = 8;
            this.dgcIsUsed.Name = "dgcIsUsed";
            this.dgcIsUsed.TrueValue = "false";
            this.dgcIsUsed.Width = 80;
            // 
            // btApply
            // 
            this.btApply.Location = new System.Drawing.Point(1, 354);
            this.btApply.Name = "btApply";
            this.btApply.Size = new System.Drawing.Size(201, 57);
            this.btApply.TabIndex = 1;
            this.btApply.Text = "Piemērot atzīmētās cenu un atlaižu lapas";
            this.btApply.UseVisualStyleBackColor = true;
            this.btApply.Click += new System.EventHandler(this.btApply_Click);
            // 
            // btCheck
            // 
            this.btCheck.Location = new System.Drawing.Point(208, 354);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(93, 57);
            this.btCheck.TabIndex = 1;
            this.btCheck.Text = "Pārbaudīt";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(307, 354);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(93, 57);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Atcelt";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // FormM_DocPricesAndDiscounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 415);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.btApply);
            this.Controls.Add(this.dgvRows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormM_DocPricesAndDiscounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Piemērot cenu un atlaižu lapas";
            this.Load += new System.EventHandler(this.FormM_DocPricesAndDiscounts_Load);
            this.Shown += new System.EventHandler(this.FormM_DocPricesAndDiscounts_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRows)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private KlonsLIB.Components.MyDataGridView dgvRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgcName;
        private KlonsLIB.Components.MyDgvCheckBoxColumn dgcIsUsed;
        private System.Windows.Forms.Button btApply;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.Button btCancel;
    }
}