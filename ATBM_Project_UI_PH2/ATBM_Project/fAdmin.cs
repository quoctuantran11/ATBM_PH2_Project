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
            fCreateUser admin = new fCreateUser();
            admin.ShowDialog();
            this.Show();
        }

        private void createToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fCreateRole admin = new fCreateRole();
            admin.ShowDialog();
            this.Show();
        }

        private void dropToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fDropRole admin = new fDropRole();
            admin.ShowDialog();
            this.Show();
        }

        private void grantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fGrantRole_to_User admin = new fGrantRole_to_User();
            admin.ShowDialog();
            this.Show();
        }

        private void revokeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fRevokeRole_from_User admin = new fRevokeRole_from_User();
            admin.ShowDialog();
            this.Show();
        }

        private void grantUserObjectPrivilegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fGrantUserObjectPrivilege admin = new fGrantUserObjectPrivilege();
            admin.ShowDialog();
            this.Show();
        }

        private void grantUserSystemPrivilegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fGrantUserSystemPrivilege admin = new fGrantUserSystemPrivilege();
            admin.ShowDialog();
            this.Show();
        }

        private void grantRolePrivilegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fGrantRolePrivilege admin = new fGrantRolePrivilege();
            admin.ShowDialog();
            this.Show();
        }

        private void revokeUserPrivilegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fRevokeUserPrivilege admin = new fRevokeUserPrivilege();
            admin.ShowDialog();
            this.Show();
        }

        private void revokeRolePrivilegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fRevokeRolePrivilege admin = new fRevokeRolePrivilege();
            admin.ShowDialog();
            this.Show();
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
            fSystemPrivUser sysUser = new fSystemPrivUser();
            sysUser.ShowDialog();
        }

        private void objectPrivilegeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fObjectPrivRole objRole = new fObjectPrivRole();
            objRole.ShowDialog();
        }

        private void objectPrivilegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fObjectPrivUser objUser = new fObjectPrivUser();
            objUser.ShowDialog();
        }

        private void updateUserPrivToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fUpdateUserPrivilege update = new fUpdateUserPrivilege();
            update.ShowDialog();
        }
    }
}
