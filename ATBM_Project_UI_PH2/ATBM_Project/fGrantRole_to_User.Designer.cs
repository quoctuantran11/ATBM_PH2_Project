
namespace ATBM_Project
{
    partial class fGrantRole_to_User
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
            this.btnGrantRole = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbOption = new System.Windows.Forms.Label();
            this.txbRole = new System.Windows.Forms.TextBox();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.txbAdminOption = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbRole);
            this.panel1.Controls.Add(this.lbRole);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 52);
            this.panel1.TabIndex = 0;
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
            this.panel2.Location = new System.Drawing.Point(12, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 52);
            this.panel2.TabIndex = 1;
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
            // btnGrantRole
            // 
            this.btnGrantRole.Location = new System.Drawing.Point(128, 251);
            this.btnGrantRole.Name = "btnGrantRole";
            this.btnGrantRole.Size = new System.Drawing.Size(226, 43);
            this.btnGrantRole.TabIndex = 2;
            this.btnGrantRole.Text = "Grant Role to User";
            this.btnGrantRole.UseVisualStyleBackColor = true;
            this.btnGrantRole.Click += new System.EventHandler(this.btnGrantRole_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbAdminOption);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lbOption);
            this.panel3.Location = new System.Drawing.Point(12, 145);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(438, 73);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "This textbox can be blank";
            // 
            // lbOption
            // 
            this.lbOption.AutoSize = true;
            this.lbOption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOption.Location = new System.Drawing.Point(13, 18);
            this.lbOption.Name = "lbOption";
            this.lbOption.Size = new System.Drawing.Size(113, 19);
            this.lbOption.TabIndex = 0;
            this.lbOption.Text = "Admin Option";
            // 
            // txbRole
            // 
            this.txbRole.Location = new System.Drawing.Point(147, 17);
            this.txbRole.Name = "txbRole";
            this.txbRole.Size = new System.Drawing.Size(271, 20);
            this.txbRole.TabIndex = 1;
            // 
            // txbUsername
            // 
            this.txbUsername.Location = new System.Drawing.Point(147, 17);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(271, 20);
            this.txbUsername.TabIndex = 2;
            // 
            // txbAdminOption
            // 
            this.txbAdminOption.Location = new System.Drawing.Point(147, 17);
            this.txbAdminOption.Name = "txbAdminOption";
            this.txbAdminOption.Size = new System.Drawing.Size(271, 20);
            this.txbAdminOption.TabIndex = 3;
            // 
            // fGrantRole_to_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 314);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnGrantRole);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fGrantRole_to_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fGrantRole_to_User";
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
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Button btnGrantRole;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbOption;
        private System.Windows.Forms.TextBox txbRole;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.TextBox txbAdminOption;
    }
}