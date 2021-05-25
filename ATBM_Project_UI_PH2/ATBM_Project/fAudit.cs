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
    public partial class fAudit : Form
    {
        public fAudit()
        {
            InitializeComponent();
        }

        private void btnStandard_Click(object sender, EventArgs e)
        {
            Function.Con.Open();

            OracleCommand cmd = new OracleCommand("sp_Audit", Function.Con);
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            dgvAudit.DataSource = dt;

            Function.Con.Close();
        }

        private void btnFGA_Click(object sender, EventArgs e)
        {
            Function.Con.Open();

            OracleCommand cmd = new OracleCommand("sp_FGA", Function.Con);
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            dgvAudit.DataSource = dt;

            Function.Con.Close();
        }
    }
}
