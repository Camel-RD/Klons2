using KlonsLIB.Components;

namespace KlonsF.FormsReportParams
{
    partial class FormRep_Rekins2
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
            this.cmDoIt = new System.Windows.Forms.Button();
            this.tbSigner = new KlonsLIB.Components.MyTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chDigitalDoc = new KlonsLIB.Components.MyCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPayUntil = new KlonsLIB.Components.MyTextBox();
            this.SuspendLayout();
            // 
            // cmDoIt
            // 
            this.cmDoIt.Location = new System.Drawing.Point(189, 206);
            this.cmDoIt.Margin = new System.Windows.Forms.Padding(2);
            this.cmDoIt.Name = "cmDoIt";
            this.cmDoIt.Size = new System.Drawing.Size(115, 65);
            this.cmDoIt.TabIndex = 3;
            this.cmDoIt.Text = "Sagatavot rēķinu";
            this.cmDoIt.UseVisualStyleBackColor = true;
            this.cmDoIt.Click += new System.EventHandler(this.cmDoIt_Click);
            this.cmDoIt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // tbSigner
            // 
            this.tbSigner.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbSigner.Location = new System.Drawing.Point(12, 41);
            this.tbSigner.Margin = new System.Windows.Forms.Padding(2);
            this.tbSigner.Name = "tbSigner";
            this.tbSigner.Size = new System.Drawing.Size(423, 26);
            this.tbSigner.TabIndex = 0;
            this.tbSigner.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Izrakstītājs:";
            // 
            // cmCancel
            // 
            this.cmCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmCancel.Location = new System.Drawing.Point(322, 206);
            this.cmCancel.Margin = new System.Windows.Forms.Padding(2);
            this.cmCancel.Name = "cmCancel";
            this.cmCancel.Size = new System.Drawing.Size(115, 65);
            this.cmCancel.TabIndex = 4;
            this.cmCancel.Text = "Atcelt";
            this.cmCancel.UseVisualStyleBackColor = true;
            this.cmCancel.Click += new System.EventHandler(this.cmCancel_Click);
            this.cmCancel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 292);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 105);
            this.label1.TabIndex = 7;
            this.label1.Text = "  Lai rēķinā pie daudzumiem parādītos mērvienības, kontējuma parakstam jāsākas ar" +
    " atbilstošās mērvienības apzīmējumu un simbolu ~.\r\n  Piemēram: kg~Kartupeļi";
            // 
            // chDigitalDoc
            // 
            this.chDigitalDoc.AutoSize = true;
            this.chDigitalDoc.Location = new System.Drawing.Point(15, 161);
            this.chDigitalDoc.Name = "chDigitalDoc";
            this.chDigitalDoc.Size = new System.Drawing.Size(360, 21);
            this.chDigitalDoc.TabIndex = 2;
            this.chDigitalDoc.Text = "Rēķins sagatavots un apstiprināts elektroniski ";
            this.chDigitalDoc.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apmaksas termiņš";
            // 
            // tbPayUntil
            // 
            this.tbPayUntil.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbPayUntil.Location = new System.Drawing.Point(14, 111);
            this.tbPayUntil.Margin = new System.Windows.Forms.Padding(2);
            this.tbPayUntil.Name = "tbPayUntil";
            this.tbPayUntil.Size = new System.Drawing.Size(423, 26);
            this.tbPayUntil.TabIndex = 1;
            // 
            // FormRep_Rekins2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 416);
            this.CloseOnEscape = true;
            this.Controls.Add(this.chDigitalDoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPayUntil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSigner);
            this.Controls.Add(this.cmCancel);
            this.Controls.Add(this.cmDoIt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRep_Rekins2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Izrakstam rēķinu";
            this.Load += new System.EventHandler(this.FormRep_Rekins2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmDoIt;
        private MyTextBox tbSigner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmCancel;
        private System.Windows.Forms.Label label1;
        private MyCheckBox chDigitalDoc;
        private System.Windows.Forms.Label label3;
        private MyTextBox tbPayUntil;
    }
}