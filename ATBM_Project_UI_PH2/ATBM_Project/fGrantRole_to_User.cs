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
    public partial class fGrantRole_to_User : Form
    {
        public fGrantRole_to_User()
        {
            InitializeComponent();
        }

        private void btnGrantRole_Click(object sender, EventArgs e)
        {
            Function.Con.Open();
            OracleCommand cmd = new OracleCommand("sp_GrantRole", Function.Con);
            cmd.CommandType = CommandType.StoredProcedure;

            string role = txbRole.Text;
            string username = txbUsername.Text;
            string adminoption = txbAdminOption.Text;

            cmd.Parameters.Add("Role_name", OracleDbType.Varchar2).Value = role;
            cmd.Parameters.Add("User_name", OracleDbType.Varchar2).Value = username;
            cmd.Parameters.Add("admin_option", OracleDbType.Varchar2).Value = adminoption;

            
            string message;
            try
            {
                int data = cmd.ExecuteNonQuery();
                if (data != 0)
                {
                    message = "Grant role " + role + " to user " + username + " successfully";
                    MessageBox.Show(message);
                }
            }
            catch
            {
                message = "Fail to grant role " + role + " to user " + username;
                MessageBox.Show(message);
            }
            Function.Con.Close();
        }
    }
}
