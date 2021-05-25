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
    public partial class fTaiVu : Form
    {
        public fTaiVu()
        {
            InitializeComponent();
        }

        private void fTaiVu_Load(object sender, EventArgs e)
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
            OracleCommand cmd = new OracleCommand("sec_mgr.sp_TaiVu", Function.Con);
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

                if (cmbTable.Text == "HOADON")
                {
                    btnThem.Visible = true;
                    btnSua.Visible = true;
                }
                else if (cmbTable.Text == "DICHVU")
                {
                    btnSua.Visible = true;
                    btnThem.Visible = false;
                }
                else
                {
                    btnSua.Visible = false;
                    btnThem.Visible = false;
                }
            }

        }
    }
}
