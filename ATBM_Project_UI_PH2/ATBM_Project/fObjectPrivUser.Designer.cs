
namespace ATBM_Project
{
    partial class fObjectPrivUser
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
            this.Searchtxt = new System.Windows.Forms.TextBox();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.ResultDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Searchtxt
            // 
            this.Searchtxt.Location = new System.Drawing.Point(33, 28);
            this.Searchtxt.Name = "Searchtxt";
            this.Searchtxt.Size = new System.Drawing.Size(794, 31);
            this.Searchtxt.TabIndex = 0;
            // 
            // Searchbtn
            // 
            this.Searchbtn.Location = new System.Drawing.Point(865, 25);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(112, 36);
            this.Searchbtn.TabIndex = 1;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // ResultDgv
            // 
            this.ResultDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultDgv.Location = new System.Drawing.Point(33, 93);
            this.ResultDgv.Name = "ResultDgv";
            this.ResultDgv.RowHeadersWidth = 82;
            this.ResultDgv.RowTemplate.Height = 33;
            this.ResultDgv.Size = new System.Drawing.Size(944, 493);
            this.ResultDgv.TabIndex = 2;
            // 
            // fObjectPrivUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 615);
            this.Controls.Add(this.ResultDgv);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.Searchtxt);
            this.Name = "fObjectPrivUser";
            this.Text = "fObjectPrivUser";
            ((System.ComponentModel.ISupportInitialize)(this.ResultDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Searchtxt;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.DataGridView ResultDgv;
    }
}