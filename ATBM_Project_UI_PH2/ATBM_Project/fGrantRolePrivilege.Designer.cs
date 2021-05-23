
namespace ATBM_Project
{
    partial class fGrantRolePrivilege
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
            this.btnGrantRolePrivilege = new System.Windows.Forms.Button();
            this.txbRole = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbPrivilege);
            this.panel1.Controls.Add(this.lbPrivilege);
            this.panel1.Location = new System.Drawing.Point(21, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 58);
            this.panel1.TabIndex = 1;
            // 
            // txbPrivilege
            // 
            this.txbPrivilege.Location = new System.Drawing.Point(117, 19);
            this.txbPrivilege.Name = "txbPrivilege";
            this.txbPrivilege.Size = new System.Drawing.Size(329, 20);
            this.txbPrivilege.TabIndex = 1;
            // 
            // lbPrivilege
            // 
            this.lbPrivilege.AutoSize = true;
            this.lbPrivilege.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrivilege.Location = new System.Drawing.Point(19, 20);
            this.lbPrivilege.Name = "lbPrivilege";
            this.lbPrivilege.Size = new System.Drawing.Size(75, 19);
            this.lbPrivilege.TabIndex = 0;
            this.lbPrivilege.Text = "Privilege";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbObject);
            this.panel2.Controls.Add(this.lbObjectname);
            this.panel2.Location = new System.Drawing.Point(21, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 58);
            this.panel2.TabIndex = 2;
            // 
            // txbObject
            // 
            this.txbObject.Location = new System.Drawing.Point(117, 19);
            this.txbObject.Name = "txbObject";
            this.txbObject.Size = new System.Drawing.Size(329, 20);
            this.txbObject.TabIndex = 1;
            // 
            // lbObjectname
            // 
            this.lbObjectname.AutoSize = true;
            this.lbObjectname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObjectname.Location = new System.Drawing.Point(19, 20);
            this.lbObjectname.Name = "lbObjectname";
            this.lbObjectname.Size = new System.Drawing.Size(58, 19);
            this.lbObjectname.TabIndex = 0;
            this.lbObjectname.Text = "Object";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbRole);
            this.panel3.Controls.Add(this.lbRole);
            this.panel3.Location = new System.Drawing.Point(21, 189);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(466, 58);
            this.panel3.TabIndex = 3;
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.Location = new System.Drawing.Point(19, 20);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(44, 19);
            this.lbRole.TabIndex = 0;
            this.lbRole.Text = "Role";
            // 
            // btnGrantRolePrivilege
            // 
            this.btnGrantRolePrivilege.Location = new System.Drawing.Point(162, 264);
            this.btnGrantRolePrivilege.Name = "btnGrantRolePrivilege";
            this.btnGrantRolePrivilege.Size = new System.Drawing.Size(157, 45);
            this.btnGrantRolePrivilege.TabIndex = 4;
            this.btnGrantRolePrivilege.Text = "Grant Role Privilege";
            this.btnGrantRolePrivilege.UseVisualStyleBackColor = true;
            this.btnGrantRolePrivilege.Click += new System.EventHandler(this.btnGrantRolePrivilege_Click);
            // 
            // txbRole
            // 
            this.txbRole.Location = new System.Drawing.Point(117, 19);
            this.txbRole.Name = "txbRole";
            this.txbRole.Size = new System.Drawing.Size(329, 20);
            this.txbRole.TabIndex = 5;
            // 
            // fGrantRolePrivilege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 321);
            this.Controls.Add(this.btnGrantRolePrivilege);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fGrantRolePrivilege";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fGrantRolePrivilege";
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
        private System.Windows.Forms.Button btnGrantRolePrivilege;
        private System.Windows.Forms.TextBox txbRole;
    }
}