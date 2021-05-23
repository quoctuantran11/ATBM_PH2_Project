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
                fAdmin formadmin = new fAdmin();
                this.Hide();
                formadmin.ShowDialog();
                this.Show();
            }

            catch(Exception)
            {
                MessageBox.Show("Can not connect to the Database");
            }
            
        }
    }
}
