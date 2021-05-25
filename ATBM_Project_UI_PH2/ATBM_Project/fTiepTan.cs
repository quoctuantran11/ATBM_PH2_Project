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
        }

        private DataTable Load_combo()
        {
            Function.Con.Open();

            OracleCommand cmd = new OracleCommand("sec_mgr.sp_TiepTan", Function.Con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("tableowner", OracleDbType.Varchar2).Value = "sec_mgr";

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            Function.Con.Close();
            return dt;
        }

        private void cmbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTable.SelectedIndex != -1)
            {
                Function.Con.Open();

                string query = "select * from sec_mgr." + cmbTable.Text;

                OracleCommand cmd = new OracleCommand(query, Function.Con);


                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                dgvTable.DataSource = dt;
                Function.Con.Close();

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
            Function.Con.Open();

            OracleCommand cmd = new OracleCommand("sec_mgr.sp_TimBenhNhan", Function.Con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("patient", OracleDbType.Varchar2).Value = txbTen.Text;

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            dgvTable.DataSource = dt;
            Function.Con.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = dgvTable.CurrentRow.Cells["MaBN"].Value.ToString();
            string ten = dgvTable.CurrentRow.Cells["HoTenBN"].Value.ToString();
            string diachi = dgvTable.CurrentRow.Cells["DiaChi"].Value.ToString();
            string sdt = dgvTable.CurrentRow.Cells["SDT"].Value.ToString();
            string namsinh = dgvTable.CurrentRow.Cells["NamSinh"].Value.ToString();

            string query = "insert into sec_mgr." + cmbTable.Text + " values(" + ma + ",'" + ten + "'," +
                "'" + diachi + "','" + sdt + "'," + namsinh + ")";
            Function.Con.Open();

            OracleCommand cmd = new OracleCommand(query, Function.Con);

            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm hoàn tất!", "Thông báo", MessageBoxButtons.OK);

                query = "commit";

                cmd = new OracleCommand(query, Function.Con);
                cmd.ExecuteNonQuery();

                query = "select * from sec_mgr." + cmbTable.Text;

                cmd = new OracleCommand(query, Function.Con);

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                dgvTable.DataSource = dt;
                Function.Con.Close();
            }
            catch
            {
                MessageBox.Show("Dữ liệu đã có sẵn hoặc có lỗi xảy ra!", "Thông báo");
                Function.Con.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Function.Con.Open();
            string ma = dgvTable.CurrentRow.Cells["MaBN"].Value.ToString();

            string query = "delete from sec_mgr." + cmbTable.Text + " where MaBN = " + ma;

            OracleCommand cmd = new OracleCommand(query, Function.Con);

            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);

                query = "select * from sec_mgr." + cmbTable.Text;

                cmd = new OracleCommand(query, Function.Con);

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                dgvTable.DataSource = dt;
                Function.Con.Close();
            }
            catch
            {
                MessageBox.Show("Dữ liệu này hiện thời không thể xóa!", "Thông báo");
                Function.Con.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Function.Con.Open();
            string ma = dgvTable.CurrentRow.Cells["MaBN"].Value.ToString();
            string ten = dgvTable.CurrentRow.Cells["HoTenBN"].Value.ToString();
            string diachi = dgvTable.CurrentRow.Cells["DiaChi"].Value.ToString();
            string sdt = dgvTable.CurrentRow.Cells["SDT"].Value.ToString();
            string namsinh = dgvTable.CurrentRow.Cells["NamSinh"].Value.ToString();

            string query = "update sec_mgr." + cmbTable.Text + " set HoTenBN = '" + ten + "'," +
                "DiaChi = '" + diachi + "', SDT = '" + sdt + "', NamSinh = '" + namsinh + "' where MaBN = " + ma;

            OracleCommand cmd = new OracleCommand(query, Function.Con);

            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Sửa hoàn tất!", "Thông báo", MessageBoxButtons.OK);

                query = "commit";

                cmd = new OracleCommand(query, Function.Con);
                cmd.ExecuteNonQuery();

                query = "select * from sec_mgr." + cmbTable.Text;

                cmd = new OracleCommand(query, Function.Con);

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                dgvTable.DataSource = dt;
                Function.Con.Close();
            }
            catch
            {
                MessageBox.Show("Dữ liệu đã có sẵn hoặc có lỗi xảy ra!", "Thông báo");
                Function.Con.Close();
            }
        }
    }
}
