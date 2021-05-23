
namespace ATBM_Project
{
    partial class fSystemPrivUser
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
            this.txbUser = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrivilege)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrivilege
            // 
            this.dgvPrivilege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrivilege.Location = new System.Drawing.Point(28, 102);
            this.dgvPrivilege.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPrivilege.Name = "dgvPrivilege";
            this.dgvPrivilege.RowHeadersWidth = 62;
            this.dgvPrivilege.RowTemplate.Height = 28;
            this.dgvPrivilege.Size = new System.Drawing.Size(1035, 450);
            this.dgvPrivilege.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(891, 26);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(136, 52);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbUser
            // 
            this.txbUser.Location = new System.Drawing.Point(28, 36);
            this.txbUser.Margin = new System.Windows.Forms.Padding(4);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(820, 31);
            this.txbUser.TabIndex = 3;
            // 
            // fSystemPrivUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 574);
            this.Controls.Add(this.dgvPrivilege);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txbUser);
            this.Name = "fSystemPrivUser";
            this.Text = "fSystemPrivUser";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrivilege)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrivilege;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbUser;
    }
}