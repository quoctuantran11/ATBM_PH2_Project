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

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = dgvTable.CurrentRow.Cells["MaHD"].Value.ToString();
            string ngay = dgvTable.CurrentRow.Cells["NgayLap"].Value.ToString();
            string[] ngaylap = ngay.Split(' ');
            string tongtien = dgvTable.CurrentRow.Cells["TongTien"].Value.ToString();
            string nguoilap = dgvTable.CurrentRow.Cells["NguoiLap"].Value.ToString();
            string kb = dgvTable.CurrentRow.Cells["MaKB"].Value.ToString();

            string query = "insert into sec_mgr." + cmbTable.Text + " values(" + ma + "," +
                "to_date('" + ngaylap[0] + "','mm/dd/yyyy')," + tongtien + ",'" + nguoilap +
                "'," + kb + ")";
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cmbTable.Text == "HOADON")
            {
                Function.Con.Open();
                string ma = dgvTable.CurrentRow.Cells["MaHD"].Value.ToString();
                string ngay = dgvTable.CurrentRow.Cells["NgayLap"].Value.ToString();
                string[] ngaylap = ngay.Split(' ');
                string tongtien = dgvTable.CurrentRow.Cells["TongTien"].Value.ToString();
                string nguoilap = dgvTable.CurrentRow.Cells["NguoiLap"].Value.ToString();
                string kb = dgvTable.CurrentRow.Cells["MaKB"].Value.ToString();

                string query = "update sec_mgr." + cmbTable.Text + " set NgayLap = " +
                    "to_date('" + ngaylap[0] + "','mm/dd/yyyy'), TongTien = " + tongtien +
                    ",NguoiLap = '" + nguoilap + "', MaKB = " + kb + " where MaPB = " + ma;

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
            else if (cmbTable.Text == "DICHVU")
            {

                Function.Con.Open();
                string ma = dgvTable.CurrentRow.Cells["MaDV"].Value.ToString();
                string ten = dgvTable.CurrentRow.Cells["TenDV"].Value.ToString();
                string dongia = dgvTable.CurrentRow.Cells["DonGia"].Value.ToString();

                string query = "update sec_mgr." + cmbTable.Text + " set TenDV = '" + ten + "', " +
                    "DonGia = " + dongia + " where MaDV = " + ma;

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
}
