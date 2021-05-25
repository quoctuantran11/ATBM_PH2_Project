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
    public partial class fNhanSu : Form
    {
        public fNhanSu()
        {
            InitializeComponent();
        }

        private void fNhanSu_Load(object sender, EventArgs e)
        {
            cmbTable.DisplayMember = "table_name";
            cmbTable.DataSource = Load_combo();
            
        }

        private DataTable Load_combo()
        {
            Function.Con.Open();

            OracleCommand cmd = new OracleCommand("sec_mgr.sp_ViewTable", Function.Con);
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
                string query = "select * from sec_mgr." + cmbTable.Text;

                OracleCommand cmd = new OracleCommand(query, Function.Con);
                Function.Con.Open();

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                dgvResult.DataSource = dt;
                Function.Con.Close();

                if (cmbTable.Text == "PHONGBAN" || cmbTable.Text == "NHANVIEN" || cmbTable.Text == "CHAMCONG")
                {
                    btnThem.Visible = true;
                    btnXoa.Visible = true;
                    btnSua.Visible = true;
                }
                else
                {
                    btnThem.Visible = false;
                    btnXoa.Visible = false;
                    btnSua.Visible = false;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cmbTable.Text == "PHONGBAN")
            {
                string ma = dgvResult.CurrentRow.Cells["MaPB"].Value.ToString();
                string ten = dgvResult.CurrentRow.Cells["TenPB"].Value.ToString();

                string query = "insert into sec_mgr." + cmbTable.Text + " values(" + ma + ",'" + ten + "')";
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

                    dgvResult.DataSource = dt;
                    Function.Con.Close();
                }
                catch
                {
                    MessageBox.Show("Dữ liệu đã có sẵn hoặc có lỗi xảy ra!", "Thông báo");
                    Function.Con.Close();
                }
            }
            else if (cmbTable.Text == "NHANVIEN")
            {
                Function.Con.Open();
                string query = "";
                string ma = dgvResult.CurrentRow.Cells["MaNV"].Value.ToString();
                string ten = dgvResult.CurrentRow.Cells["HoTenNV"].Value.ToString();
                string diachi = dgvResult.CurrentRow.Cells["DiaChi"].Value.ToString();
                string sdt = dgvResult.CurrentRow.Cells["SDT"].Value.ToString();
                string luong = dgvResult.CurrentRow.Cells["LuongCoBan"].Value.ToString();
                string khoa = dgvResult.CurrentRow.Cells["MaKhoa"].Value.ToString();
                string pb = dgvResult.CurrentRow.Cells["MaPB"].Value.ToString();

                if (khoa != "" && pb != "")
                {
                    query = "insert into sec_mgr." + cmbTable.Text + " values('" + ma + "','" +
                        ten + "','" + diachi + "','" + sdt + "','" + luong + "'," + khoa + "," + pb + ")";
                }
                else if (khoa == "" && pb != "")
                {
                    query = "insert into sec_mgr." + cmbTable.Text + " values('" + ma + "','" +
                        ten + "','" + diachi + "','" + sdt + "','" + luong + "',null," + pb + ")";
                }
                else if (pb == "" && khoa != "")
                {
                    query = "insert into sec_mgr." + cmbTable.Text + " values('" + ma + "','" +
                        ten + "','" + diachi + "','" + sdt + "','" + luong + "'," + khoa + ",null)";
                }
                else
                {
                    query = "insert into sec_mgr." + cmbTable.Text + " values('" + ma + "','" +
                        ten + "','" + diachi + "','" + sdt + "','" + luong + "',null,null)";
                }

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

                    dgvResult.DataSource = dt;
                    Function.Con.Close();
                }
                catch
                {
                    MessageBox.Show("Dữ liệu đã có sẵn hoặc có lỗi xảy ra!", "Thông báo");
                    Function.Con.Close();
                }
            }
            else if (cmbTable.Text == "CHAMCONG")
            {
                Function.Con.Open();
                string ma = dgvResult.CurrentRow.Cells["MaNV"].Value.ToString();
                string ten = dgvResult.CurrentRow.Cells["TenPK"].Value.ToString();
                string ngay = dgvResult.CurrentRow.Cells["NgayTruc"].Value.ToString();
                string[] ngay1 = ngay.Split(' ');

                string query = "insert into sec_mgr." + cmbTable.Text + " values('" + ma +
                    "','" + ten + "',to_date('" + ngay1[0] + "','mm/dd/yyyy'))";

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

                    dgvResult.DataSource = dt;
                    Function.Con.Close();
                }
                catch
                {
                    MessageBox.Show("Dữ liệu đã có sẵn hoặc có lỗi xảy ra!", "Thông báo");
                    Function.Con.Close();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cmbTable.Text == "PHONGBAN")
            {
                Function.Con.Open();
                string ma = dgvResult.CurrentRow.Cells["MaPB"].Value.ToString();

                string query = "delete from sec_mgr." + cmbTable.Text + " where MaPB = " + ma;

                OracleCommand cmd = new OracleCommand(query, Function.Con);

                try
                {
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);

                    query = "select * from sec_mgr." + cmbTable.Text;

                    cmd = new OracleCommand(query, Function.Con);

                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    dgvResult.DataSource = dt;
                    Function.Con.Close();
                }
                catch
                {
                    MessageBox.Show("Dữ liệu này hiện thời không thể xóa!", "Thông báo");
                    Function.Con.Close();
                }
            }
            else if (cmbTable.Text == "NHANVIEN")
            {
                Function.Con.Open();
                string ma = dgvResult.CurrentRow.Cells["MaNV"].Value.ToString();

                string query = "delete from sec_mgr." + cmbTable.Text + " where MaNV = '" + ma + "'";

                OracleCommand cmd = new OracleCommand(query, Function.Con);

                try
                {
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);

                    query = "select * from sec_mgr." + cmbTable.Text;

                    cmd = new OracleCommand(query, Function.Con);

                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    dgvResult.DataSource = dt;
                    Function.Con.Close();
                }
                catch
                {
                    MessageBox.Show("Dữ liệu này hiện thời không thể xóa!", "Thông báo");
                    Function.Con.Close();
                }
            }
            else if (cmbTable.Text == "CHAMCONG")
            {
                Function.Con.Open();
                string ma = dgvResult.CurrentRow.Cells["MaNV"].Value.ToString();
                string ten = dgvResult.CurrentRow.Cells["TenPK"].Value.ToString();

                string query = "delete from sec_mgr." + cmbTable.Text + " where MaNV = '" + ma + 
                    "' and TenPK = '" + ten + "'";

                OracleCommand cmd = new OracleCommand(query, Function.Con);

                try
                {
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);

                    query = "select * from sec_mgr." + cmbTable.Text;

                    cmd = new OracleCommand(query, Function.Con);

                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    dgvResult.DataSource = dt;
                    Function.Con.Close();
                }
                catch
                {
                    MessageBox.Show("Dữ liệu này hiện thời không thể xóa!", "Thông báo");
                    Function.Con.Close();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cmbTable.Text == "PHONGBAN")
            {
                Function.Con.Open();
                string ma = dgvResult.CurrentRow.Cells["MaPB"].Value.ToString();
                string ten = dgvResult.CurrentRow.Cells["TenPB"].Value.ToString();

                string query = "update sec_mgr." + cmbTable.Text + " set TenPB = '" + ten + "' where MaPB = " + ma;

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

                    dgvResult.DataSource = dt;
                    Function.Con.Close();
                }
                catch
                {
                    MessageBox.Show("Dữ liệu đã có sẵn hoặc có lỗi xảy ra!", "Thông báo");
                    Function.Con.Close();
                }
            }
            else if (cmbTable.Text == "NHANVIEN")
            {
                string query = "";
                Function.Con.Open();
                string ma = dgvResult.CurrentRow.Cells["MaNV"].Value.ToString();
                string ten = dgvResult.CurrentRow.Cells["HoTenNV"].Value.ToString();
                string diachi = dgvResult.CurrentRow.Cells["DiaChi"].Value.ToString();
                string sdt = dgvResult.CurrentRow.Cells["SDT"].Value.ToString();
                string luong = dgvResult.CurrentRow.Cells["LuongCoBan"].Value.ToString();
                string khoa = dgvResult.CurrentRow.Cells["MaKhoa"].Value.ToString();
                string pb = dgvResult.CurrentRow.Cells["MaPB"].Value.ToString();

                if (khoa == "" && pb == "")
                {
                    query = "update sec_mgr." + cmbTable.Text + " set HoTenNV = '" + ten + "', " +
                        "DiaChi = '" + diachi + "', SDT = '" + sdt + "', LuongCoBan = '" + luong + "', "
                        + "MaKhoa = '', MaPB = '' where MaNV = '" + ma + "'";
                }
                else if (khoa == "" && pb != "")
                {
                    query = "update sec_mgr." + cmbTable.Text + " set HoTenNV = '" + ten + "', " +
                        "DiaChi = '" + diachi + "', SDT = '" + sdt + "', LuongCoBan = '" + luong + "', "
                        + "MaKhoa = '', MaPB = " + pb + " where MaNV = '" + ma + "'";
                }
                else if (pb == "" && khoa != "")
                {
                    query = "update sec_mgr." + cmbTable.Text + " set HoTenNV = '" + ten + "', " +
                        "DiaChi = '" + diachi + "', SDT = '" + sdt + "', LuongCoBan = '" + luong + "', "
                        + "MaKhoa = " + khoa + ", MaPB = '' where MaNV = '" + ma + "'";
                }
                else
                {
                    query = "update sec_mgr." + cmbTable.Text + " set HoTenNV = '" + ten + "', " +
                        "DiaChi = '" + diachi + "', SDT = '" + sdt + "', LuongCoBan = '" + luong + "', "
                        + "MaKhoa = " + khoa + ", MaPB = " + pb + " where MaNV = '" + ma + "'";
                }

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

                    dgvResult.DataSource = dt;
                    Function.Con.Close();
                }
                catch
                {
                    MessageBox.Show("Dữ liệu đã có sẵn hoặc có lỗi xảy ra!", "Thông báo");
                    Function.Con.Close();
                }
            }
            else if (cmbTable.Text == "CHAMCONG")
            {
                Function.Con.Open();
                string ma = dgvResult.CurrentRow.Cells["MaNV"].Value.ToString();
                string ten = dgvResult.CurrentRow.Cells["TenPK"].Value.ToString();
                string ngay = dgvResult.CurrentRow.Cells["NgayTruc"].Value.ToString();
                string[] ngay1 = ngay.Split(' ');

                string query = "update sec_mgr." + cmbTable.Text + " set TenPK = '" + ten + "'," +
                    " NgayTruc = to_date('" + ngay1[0] + "','mm/dd/yyyy') where MaNV = '" + ma + "'";

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

                    dgvResult.DataSource = dt;
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
