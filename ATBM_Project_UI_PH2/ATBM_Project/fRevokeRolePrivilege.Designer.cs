
namespace ATBM_Project
{
    partial class fRevokeRolePrivilege
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
            this.txbObject = new System.Windows.Forms.TextBox();
            this.lbObjectname = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbRole = new System.Windows.Forms.Label();
            this.btnRevokePrivilegefromRole = new System.Windows.Forms.Button();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbPrivilege);
            this.panel1.Controls.Add(this.lbPrivilege);
            this.panel1.Location = new System.Drawing.Point(48, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 112);
            this.panel1.TabIndex = 2;
            // 
            // txbPrivilege
            // 
            this.txbPrivilege.Location = new System.Drawing.Point(234, 37);
            this.txbPrivilege.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbPrivilege.Name = "txbPrivilege";
            this.txbPrivilege.Size = new System.Drawing.Size(654, 31);
            this.txbPrivilege.TabIndex = 1;
            // 
            // lbPrivilege
            // 
            this.lbPrivilege.AutoSize = true;
            this.lbPrivilege.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrivilege.Location = new System.Drawing.Point(38, 35);
            this.lbPrivilege.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbPrivilege.Name = "lbPrivilege";
            this.lbPrivilege.Size = new System.Drawing.Size(152, 37);
            this.lbPrivilege.TabIndex = 0;
            this.lbPrivilege.Text = "Privilege";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbObject);
            this.panel2.Controls.Add(this.lbObjectname);
            this.panel2.Location = new System.Drawing.Point(48, 183);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(932, 112);
            this.panel2.TabIndex = 3;
            // 
            // txbObject
            // 
            this.txbObject.Location = new System.Drawing.Point(234, 37);
            this.txbObject.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbObject.Name = "txbObject";
            this.txbObject.Size = new System.Drawing.Size(654, 31);
            this.txbObject.TabIndex = 1;
            // 
            // lbObjectname
            // 
            this.lbObjectname.AutoSize = true;
            this.lbObjectname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObjectname.Location = new System.Drawing.Point(38, 38);
            this.lbObjectname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbObjectname.Name = "lbObjectname";
            this.lbObjectname.Size = new System.Drawing.Size(117, 37);
            this.lbObjectname.TabIndex = 0;
            this.lbObjectname.Text = "Object";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtRole);
            this.panel3.Controls.Add(this.lbRole);
            this.panel3.Location = new System.Drawing.Point(48, 327);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(932, 112);
            this.panel3.TabIndex = 4;
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.Location = new System.Drawing.Point(38, 38);
            this.lbRole.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(86, 37);
            this.lbRole.TabIndex = 0;
            this.lbRole.Text = "Role";
            // 
            // btnRevokePrivilegefromRole
            // 
            this.btnRevokePrivilegefromRole.Location = new System.Drawing.Point(220, 479);
            this.btnRevokePrivilegefromRole.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRevokePrivilegefromRole.Name = "btnRevokePrivilegefromRole";
            this.btnRevokePrivilegefromRole.Size = new System.Drawing.Size(544, 87);
            this.btnRevokePrivilegefromRole.TabIndex = 5;
            this.btnRevokePrivilegefromRole.Text = "Revoke Privilege on Object from Role";
            this.btnRevokePrivilegefromRole.UseVisualStyleBackColor = true;
            this.btnRevokePrivilegefromRole.Click += new System.EventHandler(this.btnRevokePrivilegefromRole_Click);
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(234, 45);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(654, 31);
            this.txtRole.TabIndex = 6;
            // 
            // fRevokeRolePrivilege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 602);
            this.Controls.Add(this.btnRevokePrivilegefromRole);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "fRevokeRolePrivilege";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fRevokeRolePrivilege";
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
        private System.Windows.Forms.TextBox txbPrivilege;
        private System.Windows.Forms.Label lbPrivilege;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbObject;
        private System.Windows.Forms.Label lbObjectname;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Button btnRevokePrivilegefromRole;
        private System.Windows.Forms.TextBox txtRole;
    }
}