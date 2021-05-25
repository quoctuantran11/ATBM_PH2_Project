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

        

        
    }
}
