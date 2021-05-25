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
    public partial class fBanThuoc : Form
    {
        public fBanThuoc()
        {
            InitializeComponent();
        }

        private void load_cmbBang()
        {
            Function.Con.Open();

            OracleCommand cmd = new OracleCommand("sec_mgr.sp_Bang", Function.Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_Role", OracleDbType.Varchar2).Value = "BANTHUOC";
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            Function.Con.Close();

            cmbBang.DisplayMember = "TABLE_NAME";
            cmbBang.ValueMember = "TABLE_NAME";
            cmbBang.DataSource = dt;
        }

        private void fBanThuoc_Load(object sender, EventArgs e)
        {
            load_cmbBang();
        }

        private void cmbBang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBang.Text == "")
            {
            }
            else
            {
                string bang = cmbBang.Text;
                Function.Con.Open();
                string query = "select * from sec_mgr." + bang;

                OracleCommand cmd = new OracleCommand(query, Function.Con);
                cmd.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvBang.DataSource = dt;

                Function.Con.Close();
            }
        }
    }
}
