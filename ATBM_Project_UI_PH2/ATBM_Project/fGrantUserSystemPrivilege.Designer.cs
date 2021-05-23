
namespace ATBM_Project
{
    partial class fGrantUserSystemPrivilege
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbPrivilege = new System.Windows.Forms.TextBox();
            this.lbPrivilege = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbUsername = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbbAdminOption = new System.Windows.Forms.TextBox();
            this.lbAdminOption = new System.Windows.Forms.Label();
            this.btnGrantPrivilegetoUser = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbPrivilege);
            this.panel1.Controls.Add(this.lbPrivilege);
            this.panel1.Location = new System.Drawing.Point(46, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 100);
            this.panel1.TabIndex = 1;
            // 
            // txbPrivilege
            // 
            this.txbPrivilege.Location = new System.Drawing.Point(264, 33);
            this.txbPrivilege.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbPrivilege.Name = "txbPrivilege";
            this.txbPrivilege.Size = new System.Drawing.Size(532, 31);
            this.txbPrivilege.TabIndex = 1;
            // 
            // lbPrivilege
            // 
            this.lbPrivilege.AutoSize = true;
            this.lbPrivilege.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrivilege.Location = new System.Drawing.Point(26, 35);
            this.lbPrivilege.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbPrivilege.Name = "lbPrivilege";
            this.lbPrivilege.Size = new System.Drawing.Size(152, 37);
            this.lbPrivilege.TabIndex = 0;
            this.lbPrivilege.Text = "Privilege";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.lbUsername);
            this.panel2.Location = new System.Drawing.Point(46, 190);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(828, 100);
            this.panel2.TabIndex = 2;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(26, 35);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(171, 37);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Username";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbbAdminOption);
            this.panel3.Controls.Add(this.lbAdminOption);
            this.panel3.Location = new System.Drawing.Point(46, 321);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(828, 100);
            this.panel3.TabIndex = 3;
            // 
            // tbbAdminOption
            // 
            this.tbbAdminOption.Location = new System.Drawing.Point(264, 33);
            this.tbbAdminOption.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbbAdminOption.Name = "tbbAdminOption";
            this.tbbAdminOption.Size = new System.Drawing.Size(532, 31);
            this.tbbAdminOption.TabIndex = 1;
            // 
            // lbAdminOption
            // 
            this.lbAdminOption.AutoSize = true;
            this.lbAdminOption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdminOption.Location = new System.Drawing.Point(26, 35);
            this.lbAdminOption.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbAdminOption.Name = "lbAdminOption";
            this.lbAdminOption.Size = new System.Drawing.Size(227, 37);
            this.lbAdminOption.TabIndex = 0;
            this.lbAdminOption.Text = "Admin Option";
            // 
            // btnGrantPrivilegetoUser
            // 
            this.btnGrantPrivilegetoUser.Location = new System.Drawing.Point(218, 458);
            this.btnGrantPrivilegetoUser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGrantPrivilegetoUser.Name = "btnGrantPrivilegetoUser";
            this.btnGrantPrivilegetoUser.Size = new System.Drawing.Size(444, 67);
            this.btnGrantPrivilegetoUser.TabIndex = 4;
            this.btnGrantPrivilegetoUser.Text = "Grant System Privilege to User";
            this.btnGrantPrivilegetoUser.UseVisualStyleBackColor = true;
            this.btnGrantPrivilegetoUser.Click += new System.EventHandler(this.btnGrantPrivilegetoUser_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(264, 35);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(532, 31);
            this.txtUsername.TabIndex = 1;
            // 
            // fGrantUserSystemPrivilege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 560);
            this.Controls.Add(this.btnGrantPrivilegetoUser);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "fGrantUserSystemPrivilege";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fGrantUserSystemPrivilege";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbPrivilege;
        private System.Windows.Forms.TextBox txbPrivilege;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbbAdminOption;
        private System.Windows.Forms.Label lbAdminOption;
        private System.Windows.Forms.Button btnGrantPrivilegetoUser;
        private System.Windows.Forms.TextBox txtUsername;
    }
}