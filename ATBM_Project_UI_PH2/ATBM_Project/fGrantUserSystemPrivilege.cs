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
    public partial class fGrantUserSystemPrivilege : Form
    {
        public fGrantUserSystemPrivilege()
        {
            InitializeComponent();
        }

        private void btnGrantPrivilegetoUser_Click(object sender, EventArgs e)
        {
            Function.Con.Open();

            OracleCommand cmd = new OracleCommand("sp_GrantSysPrivs", Function.Con);
            cmd.CommandType = CommandType.StoredProcedure;

            string priv = txbPrivilege.Text;
            string username = txtUsername.Text;
            string admin_option;
            if (tbbAdminOption.Text == "Yes")
            {
                admin_option = " with grant option";
            }
            else
            {
                admin_option = "";
            }

            cmd.Parameters.Add("Actor_name", OracleDbType.Varchar2).Value = username;
            cmd.Parameters.Add("admin_option", OracleDbType.Varchar2).Value = admin_option;
            cmd.Parameters.Add("priv_name", OracleDbType.Varchar2).Value = priv;

            
            string message;
            try
            {
                int data = cmd.ExecuteNonQuery();
                if (data != 0)
                {
                    message = "Grant " + priv + " to user " + username + " successfully";
                    MessageBox.Show(message);
                }
            }
            catch
            {
                message = "Fail to grant " + priv + " to user " + username;
                MessageBox.Show(message);
            }
            Function.Con.Close();
        }
    }
}
