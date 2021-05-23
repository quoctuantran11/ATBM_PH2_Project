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
    public partial class fGrantUserObjectPrivilege : Form
    {
        public fGrantUserObjectPrivilege()
        {
            InitializeComponent();
        }

        private void btnGrantUserObjectPrivilege_Click(object sender, EventArgs e)
        {
            Function.Con.Open();

            OracleCommand cmd = new OracleCommand("sp_GrantPrivs", Function.Con);
            cmd.CommandType = CommandType.StoredProcedure;

            string priv = txtPrivilege.Text;
            string obj = txtObject.Text;
            string username = txbUName.Text;
            string admin_option;
            if (txtOption.Text == "Yes")
            {
                admin_option = "with grant option";
            }
            else
            {
                admin_option = "";
            }
            string col_name = "";

            cmd.Parameters.Add("Obj_name", OracleDbType.Varchar2).Value = obj;
            cmd.Parameters.Add("Actor_name", OracleDbType.Varchar2).Value = username;
            cmd.Parameters.Add("priv_name", OracleDbType.Varchar2).Value = priv;
            cmd.Parameters.Add("admin_option", OracleDbType.Varchar2).Value = admin_option;
            cmd.Parameters.Add("col_name", OracleDbType.Varchar2).Value = col_name;

            
            string message;
            try
            {
                int data = cmd.ExecuteNonQuery();
                if (data != 0)
                {
                    message = "Grant " + priv + " on " + obj + " to user " + username + " successfully";
                    MessageBox.Show(message);
                }
            }
            catch
            {
                message = "Fail to grant " + priv + " on " + obj + " to user " + username;
                MessageBox.Show(message);
            }
            Function.Con.Close();
        }
    }
}
