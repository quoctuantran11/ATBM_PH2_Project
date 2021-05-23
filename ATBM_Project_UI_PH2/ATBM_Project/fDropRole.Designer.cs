
namespace ATBM_Project
{
    partial class fDropRole
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDropRole = new System.Windows.Forms.Button();
            this.txbRole = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Role";
            // 
            // btnDropRole
            // 
            this.btnDropRole.Location = new System.Drawing.Point(154, 106);
            this.btnDropRole.Name = "btnDropRole";
            this.btnDropRole.Size = new System.Drawing.Size(91, 35);
            this.btnDropRole.TabIndex = 3;
            this.btnDropRole.Text = "Drop Role";
            this.btnDropRole.UseVisualStyleBackColor = true;
            this.btnDropRole.Click += new System.EventHandler(this.btnDropRole_Click);
            // 
            // txbRole
            // 
            this.txbRole.Location = new System.Drawing.Point(114, 58);
            this.txbRole.Name = "txbRole";
            this.txbRole.Size = new System.Drawing.Size(246, 20);
            this.txbRole.TabIndex = 4;
            // 
            // fDropRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 163);
            this.Controls.Add(this.txbRole);
            this.Controls.Add(this.btnDropRole);
            this.Controls.Add(this.label1);
            this.Name = "fDropRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fDropRole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDropRole;
        private System.Windows.Forms.TextBox txbRole;
    }
}