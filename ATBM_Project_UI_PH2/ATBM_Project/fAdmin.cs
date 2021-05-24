using Oracle.ManagedDataAccess.Client;
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

namespace ATBM_Project
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            
        }

        private void createToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void dropToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void grantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void revokeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void grantUserObjectPrivilegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void grantUserSystemPrivilegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void grantRolePrivilegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void revokeUserPrivilegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void revokeRolePrivilegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fAdmin_Load(object sender, EventArgs e)
        {

            OracleCommand cmd = new OracleCommand("sp_ViewUser", Function.Con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dgvSystemuser.DataSource = dt;


            Function.Con.Close();
        }

        private void btnTableList_Click(object sender, EventArgs e)
        {
            Function.Con.Open();
            OracleCommand cmd = new OracleCommand("sp_ViewTable", Function.Con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("tableowner", OracleDbType.Varchar2).Value = Function.username;

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dgvSystemuser.DataSource = dt;
            lbListUser.Text = "List of Table";
            Function.Con.Close();
        }

        private void btnUserList_Click(object sender, EventArgs e)
        {
            Function.Con.Open();

            OracleCommand cmd = new OracleCommand("sp_ViewUser", Function.Con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dgvSystemuser.DataSource = dt;

            lbListUser.Text = "List of User";
            Function.Con.Close();
        }

        private void btnDropUser_Click(object sender, EventArgs e)
        {
            Function.Con.Open();

            OracleCommand cmd = new OracleCommand("sp_DeleteUser", Function.Con);
            cmd.CommandType = CommandType.StoredProcedure;

            string username = dgvSystemuser.CurrentRow.Cells["USERNAME"].Value.ToString();

            cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;

            
            string message;
            try
            {
                int data = cmd.ExecuteNonQuery();
                if (data != 0)
                {
                    message = "Drop user " + username + "!!!";
                    MessageBox.Show(message);
                }
            }
            catch
            {
                message = "Fail to drop user " + username;
                MessageBox.Show(message);
            }

            Function.Con.Close();
        }

        private void systemPrivilegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void objectPrivilegeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void objectPrivilegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void updateUserPrivToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
