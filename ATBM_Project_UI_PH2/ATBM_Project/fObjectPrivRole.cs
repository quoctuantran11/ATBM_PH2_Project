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
    public partial class fObjectPrivRole : Form
    {
        public fObjectPrivRole()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Function.Con.Open();
            string username = txbRole.Text;

            OracleCommand cmd = new OracleCommand("sp_PrivilegeRole", Function.Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_Role", OracleDbType.Varchar2).Value = username;

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dgvPrivilege.DataSource = dt;

            Function.Con.Close();
        }
    }
}
