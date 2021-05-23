
namespace ATBM_Project
{
    partial class fGrantUserObjectPrivilege
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
            this.txtPrivilege = new System.Windows.Forms.TextBox();
            this.lbPrivilege = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtObject = new System.Windows.Forms.TextBox();
            this.lbObjectname = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbUserName = new System.Windows.Forms.Label();
            this.btnGrantUserObjectPrivilege = new System.Windows.Forms.Button();
            this.txtOption = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbUName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPrivilege);
            this.panel1.Controls.Add(this.lbPrivilege);
            this.panel1.Location = new System.Drawing.Point(24, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 112);
            this.panel1.TabIndex = 0;
            // 
            // txtPrivilege
            // 
            this.txtPrivilege.Location = new System.Drawing.Point(275, 37);
            this.txtPrivilege.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPrivilege.Name = "txtPrivilege";
            this.txtPrivilege.Size = new System.Drawing.Size(613, 31);
            this.txtPrivilege.TabIndex = 1;
            // 
            // lbPrivilege
            // 
            this.lbPrivilege.AutoSize = true;
            this.lbPrivilege.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrivilege.Location = new System.Drawing.Point(38, 38);
            this.lbPrivilege.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbPrivilege.Name = "lbPrivilege";
            this.lbPrivilege.Size = new System.Drawing.Size(152, 37);
            this.lbPrivilege.TabIndex = 0;
            this.lbPrivilege.Text = "Privilege";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtObject);
            this.panel2.Controls.Add(this.lbObjectname);
            this.panel2.Location = new System.Drawing.Point(24, 181);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(932, 112);
            this.panel2.TabIndex = 1;
            // 
            // txtObject
            // 
            this.txtObject.Location = new System.Drawing.Point(275, 37);
            this.txtObject.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtObject.Name = "txtObject";
            this.txtObject.Size = new System.Drawing.Size(613, 31);
            this.txtObject.TabIndex = 1;
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
            this.panel3.Controls.Add(this.txbUName);
            this.panel3.Controls.Add(this.lbUserName);
            this.panel3.Location = new System.Drawing.Point(24, 327);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(932, 112);
            this.panel3.TabIndex = 2;
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
            this.btnGrantUserObjectPrivilege.Location = new System.Drawing.Point(202, 612);
            this.btnGrantUserObjectPrivilege.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGrantUserObjectPrivilege.Name = "btnGrantUserObjectPrivilege";
            this.btnGrantUserObjectPrivilege.Size = new System.Drawing.Size(544, 87);
            this.btnGrantUserObjectPrivilege.TabIndex = 3;
            this.btnGrantUserObjectPrivilege.Text = "Grant Privilege on Object to User";
            this.btnGrantUserObjectPrivilege.UseVisualStyleBackColor = true;
            this.btnGrantUserObjectPrivilege.Click += new System.EventHandler(this.btnGrantUserObjectPrivilege_Click);
            // 
            // txtOption
            // 
            this.txtOption.Location = new System.Drawing.Point(275, 39);
            this.txtOption.Name = "txtOption";
            this.txtOption.Size = new System.Drawing.Size(613, 31);
            this.txtOption.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Grant Option";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtOption);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(24, 483);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(932, 100);
            this.panel4.TabIndex = 6;
            // 
            // txbUName
            // 
            this.txbUName.Location = new System.Drawing.Point(275, 45);
            this.txbUName.Name = "txbUName";
            this.txbUName.Size = new System.Drawing.Size(613, 31);
            this.txbUName.TabIndex = 7;
            // 
            // fGrantUserObjectPrivilege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 727);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnGrantUserObjectPrivilege);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "fGrantUserObjectPrivilege";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fGrantUserObjectPrivilege";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPrivilege;
        private System.Windows.Forms.Label lbPrivilege;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtObject;
        private System.Windows.Forms.Label lbObjectname;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Button btnGrantUserObjectPrivilege;
        private System.Windows.Forms.TextBox txtOption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbUName;
    }
}