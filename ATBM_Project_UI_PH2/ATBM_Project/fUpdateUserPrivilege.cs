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

namespace ATBM_Project
{
    public partial class fUpdateUserPrivilege : Form
    {
        public fUpdateUserPrivilege()
        {
            InitializeComponent();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Function.Con.Open();

            OracleCommand cmd = new OracleCommand("update_priv", Function.Con);
            cmd.CommandType = CommandType.StoredProcedure;

            string table = TableTxb.Text;
            string old = OldTxb.Text;
            string newpriv = NewTxb.Text;
            string username = UserTxb.Text;

            cmd.Parameters.Add("old_priv", OracleDbType.Varchar2).Value = old;
            cmd.Parameters.Add("tab_name", OracleDbType.Varchar2).Value = table;
            cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = username;
            cmd.Parameters.Add("new_priv", OracleDbType.Varchar2).Value = newpriv;

            string message;
            try
            {
                int data = cmd.ExecuteNonQuery();
                if (data != 0)
                {
                    message = "Update " + username + " from " + old + " privilege to " + newpriv + " privilege on table " + table;
                    MessageBox.Show(message);
                }
            }
            catch
            {
                message = "Fail to update user " + username + "'s privileges";
                MessageBox.Show(message);
            }

            Function.Con.Close();
        }
    }
}
