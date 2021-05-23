
namespace ATBM_Project
{
    partial class fRevokeUserPrivilege
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
            this.lbUserName = new System.Windows.Forms.Label();
            this.btnGrantUserObjectPrivilege = new System.Windows.Forms.Button();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbPrivilege);
            this.panel1.Controls.Add(this.lbPrivilege);
            this.panel1.Location = new System.Drawing.Point(54, 67);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 112);
            this.panel1.TabIndex = 1;
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
            this.panel2.Location = new System.Drawing.Point(54, 217);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(932, 112);
            this.panel2.TabIndex = 2;
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
            this.panel3.Controls.Add(this.tbUserName);
            this.panel3.Controls.Add(this.lbUserName);
            this.panel3.Location = new System.Drawing.Point(54, 367);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(932, 112);
            this.panel3.TabIndex = 3;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(38, 38);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(171, 37);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "Username";
            // 
            // btnGrantUserObjectPrivilege
            // 
            this.btnGrantUserObjectPrivilege.Location = new System.Drawing.Point(206, 538);
            this.btnGrantUserObjectPrivilege.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGrantUserObjectPrivilege.Name = "btnGrantUserObjectPrivilege";
            this.btnGrantUserObjectPrivilege.Size = new System.Drawing.Size(544, 87);
            this.btnGrantUserObjectPrivilege.TabIndex = 4;
            this.btnGrantUserObjectPrivilege.Text = "Revoke Privilege on Object from User";
            this.btnGrantUserObjectPrivilege.UseVisualStyleBackColor = true;
            this.btnGrantUserObjectPrivilege.Click += new System.EventHandler(this.btnGrantUserObjectPrivilege_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(234, 45);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(654, 31);
            this.tbUserName.TabIndex = 5;
            // 
            // fRevokeUserPrivilege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 658);
            this.Controls.Add(this.btnGrantUserObjectPrivilege);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "fRevokeUserPrivilege";
            this.Text = "fRevokeUserPrivilege";
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
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Button btnGrantUserObjectPrivilege;
        private System.Windows.Forms.TextBox tbUserName;
    }
}