using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace ATBM_Project
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Set username password
            // Cập nhật username & password.
            Function.username = txbUsername.Text;
            Function.password = txbPassword.Text;

            // Cập nhật constring.
            Function.setConstring();

            // Cập nhật Con.
            Function.updateCon();

            try
            {
                Function.Con.Open();
                Function.Con.Close();
                if (txbUsername.Text == "sec_mgr" && txbPassword.Text == "mgr")
                {
                    fAdmin formadmin = new fAdmin();

                    this.Hide();
                    formadmin.ShowDialog();
                }
                else if(txbUsername.Text.Substring(0,2) == "BS" && txbPassword.Text.Substring(0,2) == "BS")
                {
                    fBacSi bacsi = new fBacSi();

                    this.Hide();
                    bacsi.ShowDialog();
                }
                else if(txbUsername.Text.Substring(0, 2) == "NS" && txbPassword.Text.Substring(0, 2) == "NS")
                {
                    fNhanSu nhansu = new fNhanSu();

                    this.Hide();
                    nhansu.ShowDialog();
                }
                else if(txbUsername.Text.Substring(0, 2) == "TV" && txbPassword.Text.Substring(0, 2) == "TV")
                {
                    fTaiVu taivu = new fTaiVu();

                    this.Hide();
                    taivu.ShowDialog();
                }
                else if(txbUsername.Text.Substring(0, 2) == "TT" && txbPassword.Text.Substring(0, 2) == "TT")
                {
                    fTiepTan tieptan = new fTiepTan();

                    this.Hide();
                    tieptan.ShowDialog();
                }
                else if(txbUsername.Text.Substring(0, 2) == "KT" && txbPassword.Text.Substring(0, 2) == "KT")
                {
                    fKeToan ketoan = new fKeToan();

                    this.Hide();
                    ketoan.ShowDialog();
                }    
                else if(txbUsername.Text.Substring(0, 4) == "QLTV" && txbPassword.Text.Substring(0, 4) == "QLTV")
                {
                    Function.Con.Close();
                    fQuanLyTaiVu qltv = new fQuanLyTaiVu();

                    this.Hide();
                    qltv.ShowDialog();
                }
                else if(txbUsername.Text.Substring(0, 4) == "QLCM" && txbPassword.Text.Substring(0, 4) == "QLCM")
                {
                    fQuanLyChuyenMon qlcm = new fQuanLyChuyenMon();

                    this.Hide();
                    qlcm.ShowDialog();
                }    
                else if(txbUsername.Text.Substring(0, 2) == "BT" && txbPassword.Text.Substring(0, 2) == "BT")
                {
                    fBanThuoc banthuoc = new fBanThuoc();

                    this.Hide();
                    banthuoc.ShowDialog();
                }

                
                this.Show();
            }

            catch(Exception)
            {
                MessageBox.Show("Can not connect to the Database");
            }
            
        }
    }
}
