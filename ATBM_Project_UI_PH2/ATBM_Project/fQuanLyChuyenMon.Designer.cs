namespace ATBM_Project
{
    partial class fQuanLyChuyenMon
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
            this.cmbBang = new System.Windows.Forms.ComboBox();
            this.dgvBang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbBang);
            this.panel1.Controls.Add(this.dgvBang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 543);
            this.panel1.TabIndex = 0;
            // 
            // cmbBang
            // 
            this.cmbBang.FormattingEnabled = true;
            this.cmbBang.Location = new System.Drawing.Point(683, 90);
            this.cmbBang.Name = "cmbBang";
            this.cmbBang.Size = new System.Drawing.Size(121, 28);
            this.cmbBang.TabIndex = 2;
            this.cmbBang.SelectedIndexChanged += new System.EventHandler(this.cmbBang_SelectedIndexChanged);
            // 
            // dgvBang
            // 
            this.dgvBang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBang.Location = new System.Drawing.Point(41, 133);
            this.dgvBang.Name = "dgvBang";
            this.dgvBang.RowHeadersWidth = 62;
            this.dgvBang.RowTemplate.Height = 28;
            this.dgvBang.Size = new System.Drawing.Size(763, 352);
            this.dgvBang.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(203, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ CHUYÊN MÔN";
            // 
            // fQuanLyChuyenMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 567);
            this.Controls.Add(this.panel1);
            this.Name = "fQuanLyChuyenMon";
            this.Text = "Quản lý chuyên môn";
            this.Load += new System.EventHandler(this.fQuanLyChuyenMon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBang;
        private System.Windows.Forms.DataGridView dgvBang;
    }
}