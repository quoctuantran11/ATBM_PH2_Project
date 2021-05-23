
namespace ATBM_Project
{
    partial class fRevokeRole_from_User
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
            this.lbRole = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbUsername = new System.Windows.Forms.Label();
            this.btnRevokeRole = new System.Windows.Forms.Button();
            this.txbRole = new System.Windows.Forms.TextBox();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbRole);
            this.panel1.Controls.Add(this.lbRole);
            this.panel1.Location = new System.Drawing.Point(21, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 52);
            this.panel1.TabIndex = 1;
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.Location = new System.Drawing.Point(13, 18);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(44, 19);
            this.lbRole.TabIndex = 0;
            this.lbRole.Text = "Role";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbUsername);
            this.panel2.Controls.Add(this.lbUsername);
            this.panel2.Location = new System.Drawing.Point(21, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 52);
            this.panel2.TabIndex = 2;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(13, 18);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(87, 19);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Username";
            // 
            // btnRevokeRole
            // 
            this.btnRevokeRole.Location = new System.Drawing.Point(123, 170);
            this.btnRevokeRole.Name = "btnRevokeRole";
            this.btnRevokeRole.Size = new System.Drawing.Size(226, 43);
            this.btnRevokeRole.TabIndex = 3;
            this.btnRevokeRole.Text = "Revoke Role from User";
            this.btnRevokeRole.UseVisualStyleBackColor = true;
            this.btnRevokeRole.Click += new System.EventHandler(this.btnRevokeRole_Click);
            // 
            // txbRole
            // 
            this.txbRole.Location = new System.Drawing.Point(115, 16);
            this.txbRole.Name = "txbRole";
            this.txbRole.Size = new System.Drawing.Size(300, 20);
            this.txbRole.TabIndex = 1;
            // 
            // txbUsername
            // 
            this.txbUsername.Location = new System.Drawing.Point(115, 17);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(300, 20);
            this.txbUsername.TabIndex = 2;
            // 
            // fRevokeRole_from_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 233);
            this.Controls.Add(this.btnRevokeRole);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fRevokeRole_from_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fRevokeRole_from_User";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Button btnRevokeRole;
        private System.Windows.Forms.TextBox txbRole;
        private System.Windows.Forms.TextBox txbUsername;
    }
}