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
    public partial class fRevokeRolePrivilege : Form
    {
        public fRevokeRolePrivilege()
        {
            InitializeComponent();
        }

        private void btnRevokePrivilegefromRole_Click(object sender, EventArgs e)
        {
            Function.Con.Open();
            OracleCommand cmd = new OracleCommand("sp_RevokeRolePrivs", Function.Con);
            cmd.CommandType = CommandType.StoredProcedure;

            string Privilege = txbPrivilege.Text;
            string Object = txbObject.Text;
            string role = txtRole.Text;

            cmd.Parameters.Add("Role_name", OracleDbType.Varchar2).Value = role;
            cmd.Parameters.Add("Obj_name", OracleDbType.Varchar2).Value = Object;
            cmd.Parameters.Add("priv_name", OracleDbType.Varchar2).Value = Privilege;


            
            string message;
            try
            {
                int data = cmd.ExecuteNonQuery();
                if (data != 0)
                {
                    message = "Revoke " + Privilege + " on " + Object + " from role " + role + " successfully";
                    MessageBox.Show(message);
                }
            }
            catch
            {
                message = "Fail to revoke " + Privilege + " on " + Object + " from role " + role;
                MessageBox.Show(message);
            }
            Function.Con.Close();
        }
    }
}
