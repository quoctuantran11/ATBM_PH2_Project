
namespace ATBM_Project
{
    partial class fAdmin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.roleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dropToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revokeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.privilegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grantUserObjectPrivilegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grantUserSystemPrivilegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grantRolePrivilegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revokeUserPrivilegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revokeRolePrivilegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateUserPrivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.privilegeOfUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objectPrivilegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemPrivilegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.privilegeOfRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objectPrivilegeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.systemPrivilegeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvSystemuser = new System.Windows.Forms.DataGridView();
            this.lbListUser = new System.Windows.Forms.Label();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnDropUser = new System.Windows.Forms.Button();
            this.btnTableList = new System.Windows.Forms.Button();
            this.btnUserList = new System.Windows.Forms.Button();
            this.auditingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAuditingRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystemuser)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roleToolStripMenuItem,
            this.privilegeToolStripMenuItem,
            this.checkInformationToolStripMenuItem,
            this.auditingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(630, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // roleToolStripMenuItem
            // 
            this.roleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem1,
            this.dropToolStripMenuItem1,
            this.grantToolStripMenuItem,
            this.revokeToolStripMenuItem});
            this.roleToolStripMenuItem.Name = "roleToolStripMenuItem";
            this.roleToolStripMenuItem.Size = new System.Drawing.Size(81, 36);
            this.roleToolStripMenuItem.Text = "Role";
            // 
            // createToolStripMenuItem1
            // 
            this.createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            this.createToolStripMenuItem1.Size = new System.Drawing.Size(226, 44);
            this.createToolStripMenuItem1.Text = "Create";
            this.createToolStripMenuItem1.Click += new System.EventHandler(this.createToolStripMenuItem1_Click);
            // 
            // dropToolStripMenuItem1
            // 
            this.dropToolStripMenuItem1.Name = "dropToolStripMenuItem1";
            this.dropToolStripMenuItem1.Size = new System.Drawing.Size(226, 44);
            this.dropToolStripMenuItem1.Text = "Drop";
            this.dropToolStripMenuItem1.Click += new System.EventHandler(this.dropToolStripMenuItem1_Click);
            // 
            // grantToolStripMenuItem
            // 
            this.grantToolStripMenuItem.Name = "grantToolStripMenuItem";
            this.grantToolStripMenuItem.Size = new System.Drawing.Size(226, 44);
            this.grantToolStripMenuItem.Text = "Grant";
            this.grantToolStripMenuItem.Click += new System.EventHandler(this.grantToolStripMenuItem_Click);
            // 
            // revokeToolStripMenuItem
            // 
            this.revokeToolStripMenuItem.Name = "revokeToolStripMenuItem";
            this.revokeToolStripMenuItem.Size = new System.Drawing.Size(226, 44);
            this.revokeToolStripMenuItem.Text = "Revoke";
            this.revokeToolStripMenuItem.Click += new System.EventHandler(this.revokeToolStripMenuItem_Click);
            // 
            // privilegeToolStripMenuItem
            // 
            this.privilegeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grantUserObjectPrivilegeToolStripMenuItem,
            this.grantUserSystemPrivilegeToolStripMenuItem,
            this.grantRolePrivilegeToolStripMenuItem,
            this.revokeUserPrivilegeToolStripMenuItem,
            this.revokeRolePrivilegeToolStripMenuItem,
            this.updateUserPrivToolStripMenuItem});
            this.privilegeToolStripMenuItem.Name = "privilegeToolStripMenuItem";
            this.privilegeToolStripMenuItem.Size = new System.Drawing.Size(136, 36);
            this.privilegeToolStripMenuItem.Text = "Privileges";
            // 
            // grantUserObjectPrivilegeToolStripMenuItem
            // 
            this.grantUserObjectPrivilegeToolStripMenuItem.Name = "grantUserObjectPrivilegeToolStripMenuItem";
            this.grantUserObjectPrivilegeToolStripMenuItem.Size = new System.Drawing.Size(455, 44);
            this.grantUserObjectPrivilegeToolStripMenuItem.Text = "Grant User Object Privilege";
            this.grantUserObjectPrivilegeToolStripMenuItem.Click += new System.EventHandler(this.grantUserObjectPrivilegeToolStripMenuItem_Click);
            // 
            // grantUserSystemPrivilegeToolStripMenuItem
            // 
            this.grantUserSystemPrivilegeToolStripMenuItem.Name = "grantUserSystemPrivilegeToolStripMenuItem";
            this.grantUserSystemPrivilegeToolStripMenuItem.Size = new System.Drawing.Size(455, 44);
            this.grantUserSystemPrivilegeToolStripMenuItem.Text = "Grant User System Privilege";
            this.grantUserSystemPrivilegeToolStripMenuItem.Click += new System.EventHandler(this.grantUserSystemPrivilegeToolStripMenuItem_Click);
            // 
            // grantRolePrivilegeToolStripMenuItem
            // 
            this.grantRolePrivilegeToolStripMenuItem.Name = "grantRolePrivilegeToolStripMenuItem";
            this.grantRolePrivilegeToolStripMenuItem.Size = new System.Drawing.Size(455, 44);
            this.grantRolePrivilegeToolStripMenuItem.Text = "Grant Role Object Privilege";
            this.grantRolePrivilegeToolStripMenuItem.Click += new System.EventHandler(this.grantRolePrivilegeToolStripMenuItem_Click);
            // 
            // revokeUserPrivilegeToolStripMenuItem
            // 
            this.revokeUserPrivilegeToolStripMenuItem.Name = "revokeUserPrivilegeToolStripMenuItem";
            this.revokeUserPrivilegeToolStripMenuItem.Size = new System.Drawing.Size(455, 44);
            this.revokeUserPrivilegeToolStripMenuItem.Text = "Revoke User Privilege";
            this.revokeUserPrivilegeToolStripMenuItem.Click += new System.EventHandler(this.revokeUserPrivilegeToolStripMenuItem_Click);
            // 
            // revokeRolePrivilegeToolStripMenuItem
            // 
            this.revokeRolePrivilegeToolStripMenuItem.Name = "revokeRolePrivilegeToolStripMenuItem";
            this.revokeRolePrivilegeToolStripMenuItem.Size = new System.Drawing.Size(455, 44);
            this.revokeRolePrivilegeToolStripMenuItem.Text = "Revoke Role Privilege";
            this.revokeRolePrivilegeToolStripMenuItem.Click += new System.EventHandler(this.revokeRolePrivilegeToolStripMenuItem_Click);
            // 
            // updateUserPrivToolStripMenuItem
            // 
            this.updateUserPrivToolStripMenuItem.Name = "updateUserPrivToolStripMenuItem";
            this.updateUserPrivToolStripMenuItem.Size = new System.Drawing.Size(455, 44);
            this.updateUserPrivToolStripMenuItem.Text = "Update User Object Privilege";
            this.updateUserPrivToolStripMenuItem.Click += new System.EventHandler(this.updateUserPrivToolStripMenuItem_Click);
            // 
            // checkInformationToolStripMenuItem
            // 
            this.checkInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.privilegeOfUserToolStripMenuItem,
            this.privilegeOfRoleToolStripMenuItem});
            this.checkInformationToolStripMenuItem.Name = "checkInformationToolStripMenuItem";
            this.checkInformationToolStripMenuItem.Size = new System.Drawing.Size(232, 36);
            this.checkInformationToolStripMenuItem.Text = "Check Information";
            // 
            // privilegeOfUserToolStripMenuItem
            // 
            this.privilegeOfUserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.objectPrivilegeToolStripMenuItem,
            this.systemPrivilegeToolStripMenuItem});
            this.privilegeOfUserToolStripMenuItem.Name = "privilegeOfUserToolStripMenuItem";
            this.privilegeOfUserToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.privilegeOfUserToolStripMenuItem.Text = "Privilege of User";
            // 
            // objectPrivilegeToolStripMenuItem
            // 
            this.objectPrivilegeToolStripMenuItem.Name = "objectPrivilegeToolStripMenuItem";
            this.objectPrivilegeToolStripMenuItem.Size = new System.Drawing.Size(323, 44);
            this.objectPrivilegeToolStripMenuItem.Text = "Object Privilege";
            this.objectPrivilegeToolStripMenuItem.Click += new System.EventHandler(this.objectPrivilegeToolStripMenuItem_Click);
            // 
            // systemPrivilegeToolStripMenuItem
            // 
            this.systemPrivilegeToolStripMenuItem.Name = "systemPrivilegeToolStripMenuItem";
            this.systemPrivilegeToolStripMenuItem.Size = new System.Drawing.Size(323, 44);
            this.systemPrivilegeToolStripMenuItem.Text = "System Privilege";
            this.systemPrivilegeToolStripMenuItem.Click += new System.EventHandler(this.systemPrivilegeToolStripMenuItem_Click);
            // 
            // privilegeOfRoleToolStripMenuItem
            // 
            this.privilegeOfRoleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.objectPrivilegeToolStripMenuItem1,
            this.systemPrivilegeToolStripMenuItem1});
            this.privilegeOfRoleToolStripMenuItem.Name = "privilegeOfRoleToolStripMenuItem";
            this.privilegeOfRoleToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.privilegeOfRoleToolStripMenuItem.Text = "Privilege of Role";
            // 
            // objectPrivilegeToolStripMenuItem1
            // 
            this.objectPrivilegeToolStripMenuItem1.Name = "objectPrivilegeToolStripMenuItem1";
            this.objectPrivilegeToolStripMenuItem1.Size = new System.Drawing.Size(323, 44);
            this.objectPrivilegeToolStripMenuItem1.Text = "Object Privilege";
            this.objectPrivilegeToolStripMenuItem1.Click += new System.EventHandler(this.objectPrivilegeToolStripMenuItem1_Click);
            // 
            // systemPrivilegeToolStripMenuItem1
            // 
            this.systemPrivilegeToolStripMenuItem1.Name = "systemPrivilegeToolStripMenuItem1";
            this.systemPrivilegeToolStripMenuItem1.Size = new System.Drawing.Size(323, 44);
            this.systemPrivilegeToolStripMenuItem1.Text = "System Privilege";
            // 
            // dgvSystemuser
            // 
            this.dgvSystemuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSystemuser.Location = new System.Drawing.Point(24, 160);
            this.dgvSystemuser.Margin = new System.Windows.Forms.Padding(6);
            this.dgvSystemuser.Name = "dgvSystemuser";
            this.dgvSystemuser.RowHeadersWidth = 62;
            this.dgvSystemuser.Size = new System.Drawing.Size(582, 567);
            this.dgvSystemuser.TabIndex = 1;
            // 
            // lbListUser
            // 
            this.lbListUser.AutoSize = true;
            this.lbListUser.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListUser.Location = new System.Drawing.Point(24, 104);
            this.lbListUser.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbListUser.Name = "lbListUser";
            this.lbListUser.Size = new System.Drawing.Size(170, 30);
            this.lbListUser.TabIndex = 2;
            this.lbListUser.Text = "List of Users";
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(266, 98);
            this.btnCreateUser.Margin = new System.Windows.Forms.Padding(6);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(150, 44);
            this.btnCreateUser.TabIndex = 3;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnDropUser
            // 
            this.btnDropUser.Location = new System.Drawing.Point(428, 98);
            this.btnDropUser.Margin = new System.Windows.Forms.Padding(6);
            this.btnDropUser.Name = "btnDropUser";
            this.btnDropUser.Size = new System.Drawing.Size(150, 44);
            this.btnDropUser.TabIndex = 4;
            this.btnDropUser.Text = "Drop User";
            this.btnDropUser.UseVisualStyleBackColor = true;
            this.btnDropUser.Click += new System.EventHandler(this.btnDropUser_Click);
            // 
            // btnTableList
            // 
            this.btnTableList.Location = new System.Drawing.Point(126, 748);
            this.btnTableList.Margin = new System.Windows.Forms.Padding(6);
            this.btnTableList.Name = "btnTableList";
            this.btnTableList.Size = new System.Drawing.Size(150, 44);
            this.btnTableList.TabIndex = 5;
            this.btnTableList.Text = "TableList";
            this.btnTableList.UseVisualStyleBackColor = true;
            this.btnTableList.Click += new System.EventHandler(this.btnTableList_Click);
            // 
            // btnUserList
            // 
            this.btnUserList.Location = new System.Drawing.Point(330, 748);
            this.btnUserList.Margin = new System.Windows.Forms.Padding(6);
            this.btnUserList.Name = "btnUserList";
            this.btnUserList.Size = new System.Drawing.Size(150, 44);
            this.btnUserList.TabIndex = 6;
            this.btnUserList.Text = "UserList";
            this.btnUserList.UseVisualStyleBackColor = true;
            this.btnUserList.Click += new System.EventHandler(this.btnUserList_Click);
            // 
            // auditingToolStripMenuItem
            // 
            this.auditingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAuditingRecordToolStripMenuItem});
            this.auditingToolStripMenuItem.Name = "auditingToolStripMenuItem";
            this.auditingToolStripMenuItem.Size = new System.Drawing.Size(126, 36);
            this.auditingToolStripMenuItem.Text = "Auditing";
            // 
            // showAuditingRecordToolStripMenuItem
            // 
            this.showAuditingRecordToolStripMenuItem.Name = "showAuditingRecordToolStripMenuItem";
            this.showAuditingRecordToolStripMenuItem.Size = new System.Drawing.Size(377, 44);
            this.showAuditingRecordToolStripMenuItem.Text = "Show auditing record";
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(630, 815);
            this.Controls.Add(this.btnUserList);
            this.Controls.Add(this.btnTableList);
            this.Controls.Add(this.btnDropUser);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.lbListUser);
            this.Controls.Add(this.dgvSystemuser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin UI";
            this.Load += new System.EventHandler(this.fAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystemuser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem roleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dropToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem grantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revokeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem privilegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkInformationToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvSystemuser;
        private System.Windows.Forms.Label lbListUser;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnDropUser;
        private System.Windows.Forms.ToolStripMenuItem grantUserObjectPrivilegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grantUserSystemPrivilegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grantRolePrivilegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revokeUserPrivilegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revokeRolePrivilegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem privilegeOfUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem privilegeOfRoleToolStripMenuItem;
        private System.Windows.Forms.Button btnTableList;
        private System.Windows.Forms.Button btnUserList;
        private System.Windows.Forms.ToolStripMenuItem objectPrivilegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemPrivilegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objectPrivilegeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem systemPrivilegeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateUserPrivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAuditingRecordToolStripMenuItem;
    }
}