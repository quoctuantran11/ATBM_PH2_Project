
namespace ATBM_Project
{
    partial class fObjectPrivRole
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
            this.dgvPrivilege = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbRole = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrivilege)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrivilege
            // 
            this.dgvPrivilege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrivilege.Location = new System.Drawing.Point(40, 98);
            this.dgvPrivilege.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPrivilege.Name = "dgvPrivilege";
            this.dgvPrivilege.RowHeadersWidth = 62;
            this.dgvPrivilege.RowTemplate.Height = 28;
            this.dgvPrivilege.Size = new System.Drawing.Size(1033, 461);
            this.dgvPrivilege.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(902, 21);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(172, 49);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbRole
            // 
            this.txbRole.Location = new System.Drawing.Point(40, 28);
            this.txbRole.Margin = new System.Windows.Forms.Padding(4);
            this.txbRole.Name = "txbRole";
            this.txbRole.Size = new System.Drawing.Size(827, 31);
            this.txbRole.TabIndex = 3;
            // 
            // fObjectPrivRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 581);
            this.Controls.Add(this.dgvPrivilege);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txbRole);
            this.Name = "fObjectPrivRole";
            this.Text = "fObjectPrivRole";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrivilege)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrivilege;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbRole;
    }
}