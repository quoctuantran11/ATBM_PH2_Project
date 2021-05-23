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
    public partial class fGrantRolePrivilege : Form
    {
        public fGrantRolePrivilege()
        {
            InitializeComponent();
        }

        private void btnGrantRolePrivilege_Click(object sender, EventArgs e)
        {
            Function.Con.Open();
            OracleCommand cmd = new OracleCommand("sp_GrantPrivs", Function.Con);
            cmd.CommandType = CommandType.StoredProcedure;

            string Privilege = txbPrivilege.Text;
            string Object = txbObject.Text;
            string Role = txbRole.Text;
            string adminopt = "";
            string col = "";


            cmd.Parameters.Add("Obj_name", OracleDbType.Varchar2).Value = Object;
            cmd.Parameters.Add("Actor_name", OracleDbType.Varchar2).Value = Role;
            cmd.Parameters.Add("priv_name", OracleDbType.Varchar2).Value = Privilege;
            cmd.Parameters.Add("admin_option", OracleDbType.Varchar2).Value = adminopt;
            cmd.Parameters.Add("col_name", OracleDbType.Varchar2).Value = col;


            
            string message;
            try
            {
                int data = cmd.ExecuteNonQuery();
                if (data != 0)
                {
                    message = "Grant " + Privilege + " on " + Object + " to role " + Role + " successfully";
                    MessageBox.Show(message);
                }
            }
            catch
            {
                message = "Fail to grant " + Privilege + " on " + Object + " to role " + Role;
                MessageBox.Show(message);
            }
            Function.Con.Close();
        }
    }
}
