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
using WindowsFormsApp1;

namespace ATBM_Project
{
    public partial class fTiepTan : Form
    {
        public fTiepTan()
        {
            InitializeComponent();
        }

        private void fTiepTan_Load(object sender, EventArgs e)
        {
            cmbTable.DisplayMember = "table_name";
            cmbTable.DataSource = Load_combo();
            cmbTable.SelectedIndex = -1;
            if (cmbTable.SelectedIndex == -1)
            {
                cmbTable.Text = "Table";
            }
        }

        private DataTable Load_combo()
        {
            OracleCommand cmd = new OracleCommand("sec_mgr.sp_TiepTan", Function.Con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("tableowner", OracleDbType.Varchar2).Value = "sec_mgr";

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            return dt;
        }

        private void cmbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTable.SelectedIndex != -1)
            {
                string query = "select * from sec_mgr." + cmbTable.Text;

                OracleCommand cmd = new OracleCommand(query, Function.Con);


                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                dgvTable.DataSource = dt;

                if (cmbTable.Text == "BENHNHAN")
                {
                    btnThem.Visible = true;
                    btnXoa.Visible = true;
                    btnSua.Visible = true;
                    lblBenhNhan.Visible = true;
                    txbTen.Visible = true;
                    btnTimkiem.Visible = true;
                }
                else
                {
                    btnSua.Visible = false;
                    btnThem.Visible = false;
                    btnXoa.Visible = false;
                    lblBenhNhan.Visible = false;
                    txbTen.Visible = false;
                    btnTimkiem.Visible = false;
                }
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("sec_mgr.sp_TimBenhNhan", Function.Con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("patient", OracleDbType.Varchar2).Value = txbTen.Text;

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            dgvTable.DataSource = dt;
        }
    }
}
