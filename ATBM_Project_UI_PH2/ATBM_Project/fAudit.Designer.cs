
namespace ATBM_Project
{
    partial class fAudit
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
            this.dgvAudit = new System.Windows.Forms.DataGridView();
            this.btnStandard = new System.Windows.Forms.Button();
            this.btnFGA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(476, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auditing";
            // 
            // dgvAudit
            // 
            this.dgvAudit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAudit.Location = new System.Drawing.Point(48, 96);
            this.dgvAudit.Name = "dgvAudit";
            this.dgvAudit.RowHeadersWidth = 82;
            this.dgvAudit.RowTemplate.Height = 33;
            this.dgvAudit.Size = new System.Drawing.Size(1029, 441);
            this.dgvAudit.TabIndex = 1;
            // 
            // btnStandard
            // 
            this.btnStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStandard.Location = new System.Drawing.Point(48, 565);
            this.btnStandard.Name = "btnStandard";
            this.btnStandard.Size = new System.Drawing.Size(183, 54);
            this.btnStandard.TabIndex = 2;
            this.btnStandard.Text = "Tiêu chuẩn";
            this.btnStandard.UseVisualStyleBackColor = true;
            this.btnStandard.Click += new System.EventHandler(this.btnStandard_Click);
            // 
            // btnFGA
            // 
            this.btnFGA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFGA.Location = new System.Drawing.Point(894, 565);
            this.btnFGA.Name = "btnFGA";
            this.btnFGA.Size = new System.Drawing.Size(183, 54);
            this.btnFGA.TabIndex = 3;
            this.btnFGA.Text = "FGA";
            this.btnFGA.UseVisualStyleBackColor = true;
            this.btnFGA.Click += new System.EventHandler(this.btnFGA_Click);
            // 
            // fAudit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 631);
            this.Controls.Add(this.btnFGA);
            this.Controls.Add(this.btnStandard);
            this.Controls.Add(this.dgvAudit);
            this.Controls.Add(this.label1);
            this.Name = "fAudit";
            this.Text = "fAudit";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAudit;
        private System.Windows.Forms.Button btnStandard;
        private System.Windows.Forms.Button btnFGA;
    }
}