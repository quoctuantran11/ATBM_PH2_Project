
namespace ATBM_Project
{
    partial class fCreateRole
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
            this.lbRole = new System.Windows.Forms.Label();
            this.txbRole = new System.Windows.Forms.TextBox();
            this.btnCreateRole = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.Location = new System.Drawing.Point(30, 46);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(51, 22);
            this.lbRole.TabIndex = 0;
            this.lbRole.Text = "Role";
            // 
            // txbRole
            // 
            this.txbRole.Location = new System.Drawing.Point(110, 48);
            this.txbRole.Name = "txbRole";
            this.txbRole.Size = new System.Drawing.Size(267, 20);
            this.txbRole.TabIndex = 1;
            // 
            // btnCreateRole
            // 
            this.btnCreateRole.Location = new System.Drawing.Point(165, 84);
            this.btnCreateRole.Name = "btnCreateRole";
            this.btnCreateRole.Size = new System.Drawing.Size(75, 23);
            this.btnCreateRole.TabIndex = 2;
            this.btnCreateRole.Text = "Create Role";
            this.btnCreateRole.UseVisualStyleBackColor = true;
            this.btnCreateRole.Click += new System.EventHandler(this.btnCreateRole_Click);
            // 
            // fCreateRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 128);
            this.Controls.Add(this.btnCreateRole);
            this.Controls.Add(this.txbRole);
            this.Controls.Add(this.lbRole);
            this.Name = "fCreateRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fCreateRole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.TextBox txbRole;
        private System.Windows.Forms.Button btnCreateRole;
    }
}