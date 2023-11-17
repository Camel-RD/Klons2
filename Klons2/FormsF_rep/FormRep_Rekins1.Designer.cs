using KlonsLIB.Components;

namespace KlonsF.FormsReportParams
{
    partial class FormRep_Rekins1
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
            this.tbDescr = new KlonsLIB.Components.MyTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmDoIt = new System.Windows.Forms.Button();
            this.tbSigner = new KlonsLIB.Components.MyTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmCancel = new System.Windows.Forms.Button();
            this.chDigitalDoc = new KlonsLIB.Components.MyCheckBox();
            this.tbPayUntil = new KlonsLIB.Components.MyTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDescr
            // 
            this.tbDescr.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbDescr.Location = new System.Drawing.Point(12, 34);
            this.tbDescr.Margin = new System.Windows.Forms.Padding(2);
            this.tbDescr.Multiline = true;
            this.tbDescr.Name = "tbDescr";
            this.tbDescr.Size = new System.Drawing.Size(423, 104);
            this.tbDescr.TabIndex = 0;
            this.tbDescr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Apraksts:";
            // 
            // cmDoIt
            // 
            this.cmDoIt.Location = new System.Drawing.Point(188, 348);
            this.cmDoIt.Margin = new System.Windows.Forms.Padding(2);
            this.cmDoIt.Name = "cmDoIt";
            this.cmDoIt.Size = new System.Drawing.Size(115, 65);
            this.cmDoIt.TabIndex = 4;
            this.cmDoIt.Text = "Sagatavot rēķinu";
            this.cmDoIt.UseVisualStyleBackColor = true;
            this.cmDoIt.Click += new System.EventHandler(this.cmDoIt_Click);
            this.cmDoIt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // tbSigner
            // 
            this.tbSigner.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbSigner.Location = new System.Drawing.Point(12, 178);
            this.tbSigner.Margin = new System.Windows.Forms.Padding(2);
            this.tbSigner.Name = "tbSigner";
            this.tbSigner.Size = new System.Drawing.Size(423, 26);
            this.tbSigner.TabIndex = 1;
            this.tbSigner.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Izrakstītājs:";
            // 
            // cmCancel
            // 
            this.cmCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmCancel.Location = new System.Drawing.Point(321, 348);
            this.cmCancel.Margin = new System.Windows.Forms.Padding(2);
            this.cmCancel.Name = "cmCancel";
            this.cmCancel.Size = new System.Drawing.Size(115, 65);
            this.cmCancel.TabIndex = 5;
            this.cmCancel.Text = "Atcelt";
            this.cmCancel.UseVisualStyleBackColor = true;
            this.cmCancel.Click += new System.EventHandler(this.cmCancel_Click);
            this.cmCancel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // chDigitalDoc
            // 
            this.chDigitalDoc.AutoSize = true;
            this.chDigitalDoc.Location = new System.Drawing.Point(15, 295);
            this.chDigitalDoc.Name = "chDigitalDoc";
            this.chDigitalDoc.Size = new System.Drawing.Size(360, 21);
            this.chDigitalDoc.TabIndex = 3;
            this.chDigitalDoc.Text = "Rēķins sagatavots un apstiprināts elektroniski ";
            this.chDigitalDoc.UseVisualStyleBackColor = false;
            // 
            // tbPayUntil
            // 
            this.tbPayUntil.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbPayUntil.Location = new System.Drawing.Point(14, 245);
            this.tbPayUntil.Margin = new System.Windows.Forms.Padding(2);
            this.tbPayUntil.Name = "tbPayUntil";
            this.tbPayUntil.Size = new System.Drawing.Size(423, 26);
            this.tbPayUntil.TabIndex = 2;
            this.tbPayUntil.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 221);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apmaksas termiņš";
            // 
            // FormRep_Rekins1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 424);
            this.CloseOnEscape = true;
            this.Controls.Add(this.chDigitalDoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPayUntil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSigner);
            this.Controls.Add(this.cmCancel);
            this.Controls.Add(this.cmDoIt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDescr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRep_Rekins1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Izrakstam rēķinu";
            this.Load += new System.EventHandler(this.FormRep_Rekins1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyTextBox tbDescr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmDoIt;
        private MyTextBox tbSigner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmCancel;
        private MyCheckBox chDigitalDoc;
        private MyTextBox tbPayUntil;
        private System.Windows.Forms.Label label3;
    }
}