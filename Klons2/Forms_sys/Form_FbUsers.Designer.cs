
namespace KlonsF.Forms
{
    partial class Form_FbUsers
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
            this.dgvUserRoles = new KlonsLIB.Components.MyDataGridView();
            this.dgcUserRolesUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcUserRolesRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsUserRoles = new System.Windows.Forms.BindingSource(this.components);
            this.tbAdminName = new KlonsLIB.Components.MyTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAdminPassword = new KlonsLIB.Components.MyTextBox();
            this.cmConnect = new System.Windows.Forms.Button();
            this.tbUserName = new KlonsLIB.Components.MyTextBox();
            this.tbUserPassword = new KlonsLIB.Components.MyTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbRole = new KlonsLIB.Components.FlatComboBox();
            this.dgvUsers = new KlonsLIB.Components.MyDataGridView();
            this.dgcUsersUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcUsersAdmin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsUsers = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lietotājiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izveidotJaunuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dzēstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nomainītParoliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.piešķirtAdminLomuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atņemtAdminLomuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.nolasītLietotājuDatusNoJaunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parādītDBLietotājuSarakstuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lomasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.piešķirtLomuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atņemtLomuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUserRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUserRoles
            // 
            this.dgvUserRoles.AllowUserToAddRows = false;
            this.dgvUserRoles.AllowUserToDeleteRows = false;
            this.dgvUserRoles.AllowUserToResizeRows = false;
            this.dgvUserRoles.AutoGenerateColumns = false;
            this.dgvUserRoles.AutoSave = false;
            this.dgvUserRoles.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUserRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcUserRolesUser,
            this.dgcUserRolesRole});
            this.dgvUserRoles.DataSource = this.bsUserRoles;
            this.dgvUserRoles.Location = new System.Drawing.Point(260, 57);
            this.dgvUserRoles.Name = "dgvUserRoles";
            this.dgvUserRoles.ReadOnly = true;
            this.dgvUserRoles.RowHeadersVisible = false;
            this.dgvUserRoles.RowHeadersWidth = 62;
            this.dgvUserRoles.RowTemplate.Height = 28;
            this.dgvUserRoles.ShowCellToolTips = false;
            this.dgvUserRoles.Size = new System.Drawing.Size(339, 195);
            this.dgvUserRoles.TabIndex = 4;
            // 
            // dgcUserRolesUser
            // 
            this.dgcUserRolesUser.DataPropertyName = "User";
            this.dgcUserRolesUser.HeaderText = "Lietotājs";
            this.dgcUserRolesUser.MinimumWidth = 8;
            this.dgcUserRolesUser.Name = "dgcUserRolesUser";
            this.dgcUserRolesUser.ReadOnly = true;
            this.dgcUserRolesUser.Width = 150;
            // 
            // dgcUserRolesRole
            // 
            this.dgcUserRolesRole.DataPropertyName = "Role";
            this.dgcUserRolesRole.HeaderText = "Loma";
            this.dgcUserRolesRole.MinimumWidth = 8;
            this.dgcUserRolesRole.Name = "dgcUserRolesRole";
            this.dgcUserRolesRole.ReadOnly = true;
            this.dgcUserRolesRole.Width = 150;
            // 
            // tbAdminName
            // 
            this.tbAdminName.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbAdminName.Location = new System.Drawing.Point(175, 9);
            this.tbAdminName.Name = "tbAdminName";
            this.tbAdminName.Size = new System.Drawing.Size(100, 26);
            this.tbAdminName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Administratora vārds:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "parole:";
            // 
            // tbAdminPassword
            // 
            this.tbAdminPassword.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbAdminPassword.Location = new System.Drawing.Point(355, 9);
            this.tbAdminPassword.Name = "tbAdminPassword";
            this.tbAdminPassword.PasswordChar = '*';
            this.tbAdminPassword.Size = new System.Drawing.Size(100, 26);
            this.tbAdminPassword.TabIndex = 1;
            // 
            // cmConnect
            // 
            this.cmConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmConnect.Location = new System.Drawing.Point(486, 6);
            this.cmConnect.Name = "cmConnect";
            this.cmConnect.Size = new System.Drawing.Size(99, 31);
            this.cmConnect.TabIndex = 2;
            this.cmConnect.Text = "Pieslēgties";
            this.cmConnect.UseVisualStyleBackColor = true;
            this.cmConnect.Click += new System.EventHandler(this.cmConnect_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbUserName.Location = new System.Drawing.Point(128, 269);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(100, 26);
            this.tbUserName.TabIndex = 5;
            // 
            // tbUserPassword
            // 
            this.tbUserPassword.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbUserPassword.Location = new System.Drawing.Point(306, 269);
            this.tbUserPassword.Name = "tbUserPassword";
            this.tbUserPassword.Size = new System.Drawing.Size(100, 26);
            this.tbUserPassword.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lietotāja vārds:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "parole:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Loma";
            // 
            // cbRole
            // 
            this.cbRole.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "USERS",
            "ADMINS"});
            this.cbRole.Location = new System.Drawing.Point(64, 311);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(164, 28);
            this.cbRole.TabIndex = 7;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            this.dgvUsers.AutoGenerateColumns = false;
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcUsersUser,
            this.dgcUsersAdmin});
            this.dgvUsers.DataSource = this.bsUsers;
            this.dgvUsers.Location = new System.Drawing.Point(10, 57);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowHeadersWidth = 62;
            this.dgvUsers.RowTemplate.Height = 28;
            this.dgvUsers.ShowCellToolTips = false;
            this.dgvUsers.Size = new System.Drawing.Size(244, 195);
            this.dgvUsers.TabIndex = 3;
            // 
            // dgcUsersUser
            // 
            this.dgcUsersUser.DataPropertyName = "User";
            this.dgcUsersUser.HeaderText = "Lietotāja vārds";
            this.dgcUsersUser.MinimumWidth = 8;
            this.dgcUsersUser.Name = "dgcUsersUser";
            this.dgcUsersUser.ReadOnly = true;
            this.dgcUsersUser.Width = 150;
            // 
            // dgcUsersAdmin
            // 
            this.dgcUsersAdmin.DataPropertyName = "IsAdmin";
            this.dgcUsersAdmin.HeaderText = "Admin";
            this.dgcUsersAdmin.MinimumWidth = 8;
            this.dgcUsersAdmin.Name = "dgcUsersAdmin";
            this.dgcUsersAdmin.ReadOnly = true;
            this.dgcUsersAdmin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcUsersAdmin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgcUsersAdmin.Width = 60;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lietotājiToolStripMenuItem,
            this.lomasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(609, 38);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lietotājiToolStripMenuItem
            // 
            this.lietotājiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izveidotJaunuToolStripMenuItem,
            this.dzēstToolStripMenuItem,
            this.nomainītParoliToolStripMenuItem,
            this.toolStripSeparator1,
            this.piešķirtAdminLomuToolStripMenuItem,
            this.atņemtAdminLomuToolStripMenuItem,
            this.toolStripSeparator2,
            this.nolasītLietotājuDatusNoJaunaToolStripMenuItem,
            this.parādītDBLietotājuSarakstuToolStripMenuItem});
            this.lietotājiToolStripMenuItem.Name = "lietotājiToolStripMenuItem";
            this.lietotājiToolStripMenuItem.Size = new System.Drawing.Size(104, 34);
            this.lietotājiToolStripMenuItem.Text = "Lietotāji";
            // 
            // izveidotJaunuToolStripMenuItem
            // 
            this.izveidotJaunuToolStripMenuItem.Name = "izveidotJaunuToolStripMenuItem";
            this.izveidotJaunuToolStripMenuItem.Size = new System.Drawing.Size(411, 38);
            this.izveidotJaunuToolStripMenuItem.Text = "Izveidot jaunu";
            this.izveidotJaunuToolStripMenuItem.Click += new System.EventHandler(this.izveidotJaunuToolStripMenuItem_Click);
            // 
            // dzēstToolStripMenuItem
            // 
            this.dzēstToolStripMenuItem.Name = "dzēstToolStripMenuItem";
            this.dzēstToolStripMenuItem.Size = new System.Drawing.Size(411, 38);
            this.dzēstToolStripMenuItem.Text = "Dzēst";
            this.dzēstToolStripMenuItem.Click += new System.EventHandler(this.dzēstToolStripMenuItem_Click);
            // 
            // nomainītParoliToolStripMenuItem
            // 
            this.nomainītParoliToolStripMenuItem.Name = "nomainītParoliToolStripMenuItem";
            this.nomainītParoliToolStripMenuItem.Size = new System.Drawing.Size(411, 38);
            this.nomainītParoliToolStripMenuItem.Text = "Nomainīt paroli";
            this.nomainītParoliToolStripMenuItem.Click += new System.EventHandler(this.nomainītParoliToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(408, 6);
            // 
            // piešķirtAdminLomuToolStripMenuItem
            // 
            this.piešķirtAdminLomuToolStripMenuItem.Name = "piešķirtAdminLomuToolStripMenuItem";
            this.piešķirtAdminLomuToolStripMenuItem.Size = new System.Drawing.Size(411, 38);
            this.piešķirtAdminLomuToolStripMenuItem.Text = "Piešķirt Admin Lomu";
            this.piešķirtAdminLomuToolStripMenuItem.Click += new System.EventHandler(this.piešķirtAdminLomuToolStripMenuItem_Click);
            // 
            // atņemtAdminLomuToolStripMenuItem
            // 
            this.atņemtAdminLomuToolStripMenuItem.Name = "atņemtAdminLomuToolStripMenuItem";
            this.atņemtAdminLomuToolStripMenuItem.Size = new System.Drawing.Size(411, 38);
            this.atņemtAdminLomuToolStripMenuItem.Text = "Atņemt Admin lomu";
            this.atņemtAdminLomuToolStripMenuItem.Click += new System.EventHandler(this.atņemtAdminLomuToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(408, 6);
            // 
            // nolasītLietotājuDatusNoJaunaToolStripMenuItem
            // 
            this.nolasītLietotājuDatusNoJaunaToolStripMenuItem.Name = "nolasītLietotājuDatusNoJaunaToolStripMenuItem";
            this.nolasītLietotājuDatusNoJaunaToolStripMenuItem.Size = new System.Drawing.Size(411, 38);
            this.nolasītLietotājuDatusNoJaunaToolStripMenuItem.Text = "Nolasīt lietotāju datus no jauna";
            this.nolasītLietotājuDatusNoJaunaToolStripMenuItem.Click += new System.EventHandler(this.nolasītLietotājuDatusNoJaunaToolStripMenuItem_Click);
            // 
            // parādītDBLietotājuSarakstuToolStripMenuItem
            // 
            this.parādītDBLietotājuSarakstuToolStripMenuItem.Name = "parādītDBLietotājuSarakstuToolStripMenuItem";
            this.parādītDBLietotājuSarakstuToolStripMenuItem.Size = new System.Drawing.Size(411, 38);
            this.parādītDBLietotājuSarakstuToolStripMenuItem.Text = "Parādīt DB lietotāju sarakstu";
            this.parādītDBLietotājuSarakstuToolStripMenuItem.Click += new System.EventHandler(this.parādītDBLietotājuSarakstuToolStripMenuItem_Click);
            // 
            // lomasToolStripMenuItem
            // 
            this.lomasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.piešķirtLomuToolStripMenuItem,
            this.atņemtLomuToolStripMenuItem});
            this.lomasToolStripMenuItem.Name = "lomasToolStripMenuItem";
            this.lomasToolStripMenuItem.Size = new System.Drawing.Size(91, 34);
            this.lomasToolStripMenuItem.Text = "Lomas";
            // 
            // piešķirtLomuToolStripMenuItem
            // 
            this.piešķirtLomuToolStripMenuItem.Name = "piešķirtLomuToolStripMenuItem";
            this.piešķirtLomuToolStripMenuItem.Size = new System.Drawing.Size(242, 38);
            this.piešķirtLomuToolStripMenuItem.Text = "Piešķirt lomu";
            this.piešķirtLomuToolStripMenuItem.Click += new System.EventHandler(this.piešķirtLomuToolStripMenuItem_Click);
            // 
            // atņemtLomuToolStripMenuItem
            // 
            this.atņemtLomuToolStripMenuItem.Name = "atņemtLomuToolStripMenuItem";
            this.atņemtLomuToolStripMenuItem.Size = new System.Drawing.Size(242, 38);
            this.atņemtLomuToolStripMenuItem.Text = "Atņemt lomu";
            this.atņemtLomuToolStripMenuItem.Click += new System.EventHandler(this.atņemtLomuToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvUserRoles);
            this.panel1.Controls.Add(this.dgvUsers);
            this.panel1.Controls.Add(this.tbAdminName);
            this.panel1.Controls.Add(this.cbRole);
            this.panel1.Controls.Add(this.tbAdminPassword);
            this.panel1.Controls.Add(this.cmConnect);
            this.panel1.Controls.Add(this.tbUserName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbUserPassword);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 364);
            this.panel1.TabIndex = 13;
            // 
            // Form_FbUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 402);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_FbUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DB lietotāji";
            this.Load += new System.EventHandler(this.Form_FbUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUserRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private KlonsLIB.Components.MyDataGridView dgvUserRoles;
        private KlonsLIB.Components.MyTextBox tbAdminName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private KlonsLIB.Components.MyTextBox tbAdminPassword;
        private System.Windows.Forms.Button cmConnect;
        private KlonsLIB.Components.MyTextBox tbUserName;
        private KlonsLIB.Components.MyTextBox tbUserPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private KlonsLIB.Components.FlatComboBox cbRole;
        private KlonsLIB.Components.MyDataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcUserRolesUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcUserRolesRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcUsersUser;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgcUsersAdmin;
        private System.Windows.Forms.BindingSource bsUsers;
        private System.Windows.Forms.BindingSource bsUserRoles;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lietotājiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izveidotJaunuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dzēstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nomainītParoliToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem piešķirtAdminLomuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atņemtAdminLomuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem nolasītLietotājuDatusNoJaunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lomasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem piešķirtLomuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atņemtLomuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parādītDBLietotājuSarakstuToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}