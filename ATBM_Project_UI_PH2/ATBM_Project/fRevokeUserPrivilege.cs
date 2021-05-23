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
    public partial class fRevokeUserPrivilege : Form
    {
        public fRevokeUserPrivilege()
        {
            InitializeComponent();
        }

        private void btnGrantUserObjectPrivilege_Click(object sender, EventArgs e)
        {
            Function.Con.Open();
            OracleCommand cmd = new OracleCommand("sp_RevokeUserPrivs", Function.Con);
            cmd.CommandType = CommandType.StoredProcedure;

            string Privilege = txbPrivilege.Text;
            string Object = txbObject.Text;
            string Username = tbUserName.Text;

            cmd.Parameters.Add("User_name", OracleDbType.Varchar2).Value = Username;
            cmd.Parameters.Add("Obj_name", OracleDbType.Varchar2).Value = Object;
            cmd.Parameters.Add("priv_name", OracleDbType.Varchar2).Value = Privilege;

            string message;
            try
            {
                int data = cmd.ExecuteNonQuery();
                
                if (data != 0)
                {
                    if (Object == "")
                    {
                        message = "Revoke " + Privilege + " from user " + Username + " successfully";
                    }
                    else
                    {
                        message = "Revoke " + Privilege + " on " + Object + " from user " + Username + " successfully";
                    }
                    MessageBox.Show(message);
                }
            }
            catch
            {
                if (Object == "")
                {
                    message = "Fail to revoke " + Privilege + " from user " + Username;
                }
                else
                {
                    message = "Fail to revoke " + Privilege + " on " + Object + " from user " + Username;
                }
                MessageBox.Show(message);
            }
            Function.Con.Close();
        }
    }
}
