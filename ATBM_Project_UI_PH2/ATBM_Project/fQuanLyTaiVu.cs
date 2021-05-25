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
    public partial class fQuanLyTaiVu : Form
    {
        public fQuanLyTaiVu()
        {
            InitializeComponent();
        }

        private void load_cmbBang()
        {
            Function.Con.Open();

            OracleCommand cmd = new OracleCommand("sec_mgr.sp_Bang_QuanLyTaiVu", Function.Con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            Function.Con.Close();

            cmbBang.DisplayMember = "TABLE_NAME";
            cmbBang.ValueMember = "TABLE_NAME";
            cmbBang.DataSource = dt;
        }

        private void fQuanLyTaiVu_Load(object sender, EventArgs e)
        {
            load_cmbBang();
        }

        private void cmbBang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBang.Text == "THUOC" || cmbBang.Text == "DICHVU")
            {
                btnThem.Visible = true;
                btnSua.Visible = true;
            }
            else
            {
                btnThem.Visible = false;
                btnSua.Visible = false;
            }

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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cmbBang.Text == "THUOC")
            {
                string mathuoc = dgvBang.CurrentRow.Cells["MATHUOC"].Value.ToString();
                string tenthuoc = dgvBang.CurrentRow.Cells["TENTHUOC"].Value.ToString();
                string donvitinh = dgvBang.CurrentRow.Cells["DONVITINH"].Value.ToString();
                string dongia = dgvBang.CurrentRow.Cells["DONGIA"].Value.ToString();
                string luuy = dgvBang.CurrentRow.Cells["LUUY"].Value.ToString();

                string query = "insert into sec_mgr." + cmbBang.Text + " values (" + mathuoc + ", '" + tenthuoc + "', '" + donvitinh + "', " + dongia +
                    ", '" + luuy + "')";

                Function.Con.Open();
                OracleCommand cmd = new OracleCommand(query, Function.Con);

                try
                {
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm hoàn tất!", "Thông báo", MessageBoxButtons.OK);

                    query = "commit";

                    cmd = new OracleCommand(query, Function.Con);
                    cmd.ExecuteNonQuery();

                    query = "select * from sec_mgr." + cmbBang.Text;

                    cmd = new OracleCommand(query, Function.Con);

                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    dgvBang.DataSource = dt;
                    Function.Con.Close();
                }
                catch
                {
                    MessageBox.Show("Bạn nhập sai trường hoặc nhập dữ liệu đã có", "Thông báo");
                    Function.Con.Close();
                }
            }
            else if (cmbBang.Text == "DICHVU")
            {
                string madv = dgvBang.CurrentRow.Cells["MADV"].Value.ToString();
                string tendv = dgvBang.CurrentRow.Cells["TENDV"].Value.ToString();
                string dongia = dgvBang.CurrentRow.Cells["DONGIA"].Value.ToString();

                string query = "insert into sec_mgr." + cmbBang.Text + " values (" + madv + ", '" + tendv + "', " + dongia + ")";

                Function.Con.Open();
                OracleCommand cmd = new OracleCommand(query, Function.Con);

                try
                {
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm hoàn tất!", "Thông báo", MessageBoxButtons.OK);

                    query = "commit";

                    cmd = new OracleCommand(query, Function.Con);
                    cmd.ExecuteNonQuery();

                    query = "select * from sec_mgr." + cmbBang.Text;

                    cmd = new OracleCommand(query, Function.Con);

                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    dgvBang.DataSource = dt;
                    Function.Con.Close();
                }
                catch
                {
                    MessageBox.Show("Bạn nhập sai trường hoặc nhập dữ liệu đã có", "Thông báo");
                    Function.Con.Close();
                }
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cmbBang.Text == "THUOC")
            {
                string mathuoc = dgvBang.CurrentRow.Cells["MATHUOC"].Value.ToString();
                string tenthuoc = dgvBang.CurrentRow.Cells["TENTHUOC"].Value.ToString();
                string donvitinh = dgvBang.CurrentRow.Cells["DONVITINH"].Value.ToString();
                string dongia = dgvBang.CurrentRow.Cells["DONGIA"].Value.ToString();
                string luuy = dgvBang.CurrentRow.Cells["LUUY"].Value.ToString();

                string query = "update sec_mgr." + cmbBang.Text + " set TENTHUOC = '" + tenthuoc + "', DONVITINH = '" + donvitinh +
                    "', DONGIA = " + dongia + ", LUUY = '" + luuy + "' where MATHUOC = " + mathuoc;

                Function.Con.Open();
                OracleCommand cmd = new OracleCommand(query, Function.Con);

                try
                {
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK);

                    query = "commit";

                    cmd = new OracleCommand(query, Function.Con);
                    cmd.ExecuteNonQuery();

                    query = "select * from sec_mgr." + cmbBang.Text;

                    cmd = new OracleCommand(query, Function.Con);

                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    dgvBang.DataSource = dt;
                    Function.Con.Close();
                }
                catch
                {
                    MessageBox.Show("Bạn nhập sai trường hoặc sửa dữ liệu không tồn tại", "Thông báo");
                    Function.Con.Close();
                }
            }
            else if (cmbBang.Text == "DICHVU")
            {
                string madv = dgvBang.CurrentRow.Cells["MADV"].Value.ToString();
                string tendv = dgvBang.CurrentRow.Cells["TENDV"].Value.ToString();
                string dongia = dgvBang.CurrentRow.Cells["DONGIA"].Value.ToString();

                string query = "update sec_mgr." + cmbBang.Text + " set TENDV = '" + tendv + "', DONGIA = " + dongia +
                    " where MADV = " + madv ;

                Function.Con.Open();
                OracleCommand cmd = new OracleCommand(query, Function.Con);

                try
                {
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK);

                    query = "commit";

                    cmd = new OracleCommand(query, Function.Con);
                    cmd.ExecuteNonQuery();

                    query = "select * from sec_mgr." + cmbBang.Text;

                    cmd = new OracleCommand(query, Function.Con);

                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    dgvBang.DataSource = dt;
                    Function.Con.Close();
                }
                catch
                {
                    MessageBox.Show("Bạn nhập sai trường hoặc sửa dữ liệu không tồn tại", "Thông báo");
                    Function.Con.Close();
                }
            }
        }
    }
}
