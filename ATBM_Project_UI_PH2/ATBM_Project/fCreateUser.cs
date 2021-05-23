using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using WindowsFormsApp1;

namespace ATBM_Project
{
    public partial class fCreateUser : Form
    {
        public fCreateUser()
        {
            InitializeComponent();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            Function.Con.Open();
            OracleCommand cmd = new OracleCommand("sp_CreateUser", Function.Con);
            cmd.CommandType = CommandType.StoredProcedure;

            string username = txbUsername.Text;
            string password = txbPassword.Text;

            cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
            cmd.Parameters.Add("p_password", OracleDbType.Varchar2).Value = password;

            
            string message;
            try
            {
                int data = cmd.ExecuteNonQuery();
                if (data != 0)
                {
                    message = "Create user " + username + " Successfully";
                    MessageBox.Show(message);
                }
            }
            catch
            {
                message = "Fail to create user " + username;
                MessageBox.Show(message);
            }
            Function.Con.Close();
        }
    }
}
