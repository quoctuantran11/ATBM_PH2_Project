
namespace ATBM_Project
{
    partial class fUpdateUserPrivilege
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TableTxb = new System.Windows.Forms.TextBox();
            this.OldTxb = new System.Windows.Forms.TextBox();
            this.NewTxb = new System.Windows.Forms.TextBox();
            this.UserTxb = new System.Windows.Forms.TextBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(31, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old Privilege";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(65, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Table";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(31, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Privilege";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(65, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "User";
            // 
            // TableTxb
            // 
            this.TableTxb.Location = new System.Drawing.Point(313, 53);
            this.TableTxb.Name = "TableTxb";
            this.TableTxb.Size = new System.Drawing.Size(552, 31);
            this.TableTxb.TabIndex = 4;
            // 
            // OldTxb
            // 
            this.OldTxb.Location = new System.Drawing.Point(313, 130);
            this.OldTxb.Name = "OldTxb";
            this.OldTxb.Size = new System.Drawing.Size(552, 31);
            this.OldTxb.TabIndex = 5;
            // 
            // NewTxb
            // 
            this.NewTxb.Location = new System.Drawing.Point(313, 209);
            this.NewTxb.Name = "NewTxb";
            this.NewTxb.Size = new System.Drawing.Size(552, 31);
            this.NewTxb.TabIndex = 6;
            // 
            // UserTxb
            // 
            this.UserTxb.Location = new System.Drawing.Point(313, 289);
            this.UserTxb.Name = "UserTxb";
            this.UserTxb.Size = new System.Drawing.Size(552, 31);
            this.UserTxb.TabIndex = 7;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.UpdateBtn.Location = new System.Drawing.Point(412, 379);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(360, 59);
            this.UpdateBtn.TabIndex = 8;
            this.UpdateBtn.Text = "Update Privilege";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // fUpdateUserPrivilege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 472);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.UserTxb);
            this.Controls.Add(this.NewTxb);
            this.Controls.Add(this.OldTxb);
            this.Controls.Add(this.TableTxb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fUpdateUserPrivilege";
            this.Text = "fUpdateUserPrivilege";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TableTxb;
        private System.Windows.Forms.TextBox OldTxb;
        private System.Windows.Forms.TextBox NewTxb;
        private System.Windows.Forms.TextBox UserTxb;
        private System.Windows.Forms.Button UpdateBtn;
    }
}