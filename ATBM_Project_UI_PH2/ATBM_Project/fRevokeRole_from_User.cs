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
    public partial class fRevokeRole_from_User : Form
    {
        public fRevokeRole_from_User()
        {
            InitializeComponent();
        }

        private void btnRevokeRole_Click(object sender, EventArgs e)
        {
            Function.Con.Open();
            OracleCommand cmd = new OracleCommand("sp_RevokeRole", Function.Con);
            cmd.CommandType = CommandType.StoredProcedure;

            string role = txbRole.Text;
            string username = txbUsername.Text;

            cmd.Parameters.Add("Role_name", OracleDbType.Varchar2).Value = role;
            cmd.Parameters.Add("User_name", OracleDbType.Varchar2).Value = username;

            
            string message;
            try
            {
                int data = cmd.ExecuteNonQuery();
                if (data != 0)
                {
                    message = "Revoke role " + role + " from user " + username + " successfully";
                    MessageBox.Show(message);
                }
            }
            catch
            {
                message = "Fail to revoke role " + role + " from user " + username;
                MessageBox.Show(message);
            }
            Function.Con.Close();
        }
    }
}
