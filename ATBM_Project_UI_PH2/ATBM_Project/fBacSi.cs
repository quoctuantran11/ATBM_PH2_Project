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
    public partial class fBacSi : Form
    {
        private object dgvSystemuser;

        public fBacSi()
        {
            InitializeComponent();
        }

        private void load_cmbBang()
        {
            Function.Con.Open();

            OracleCommand cmd = new OracleCommand("sec_mgr.sp_Bang_BacSi", Function.Con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            Function.Con.Close();
            
            cmbBang.DisplayMember = "TABLE_NAME";
            cmbBang.ValueMember = "TABLE_NAME";
            cmbBang.DataSource = dt;
        }

        private void fBacSi_Load(object sender, EventArgs e)
        {
            load_cmbBang();
        }

        private void cmbBang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBang.Text == "HOSOBENHAN")
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
            if (cmbBang.Text == "HOSOBENHAN")
            {
                string makb = dgvBang.CurrentRow.Cells["MAKB"].Value.ToString();
                string ngaykb = dgvBang.CurrentRow.Cells["NGAYKB"].Value.ToString();
                string[] ngaykb1 = ngaykb.Split(' ');
                string tinhtrangbandau = dgvBang.CurrentRow.Cells["TINHTRANGBANDAU"].Value.ToString();
                string ketluanbacsi = dgvBang.CurrentRow.Cells["KETLUANBACSI"].Value.ToString();
                string mabn = dgvBang.CurrentRow.Cells["MABN"].Value.ToString();
                string matt = dgvBang.CurrentRow.Cells["MATT"].Value.ToString();
                string mabs = dgvBang.CurrentRow.Cells["MABS"].Value.ToString();

                string query = "insert into sec_mgr." + cmbBang.Text + " values ("+ makb + ", to_date('" + ngaykb1[0] + "','mm/dd/yyyy'), '" + tinhtrangbandau + 
                    "', '" + ketluanbacsi + "'," + mabn + ", '" + matt + "', '" + mabs + "')";

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
            if (cmbBang.Text == "HOSOBENHAN")
            {
                string makb = dgvBang.CurrentRow.Cells["MAKB"].Value.ToString();
                string ngaykb = dgvBang.CurrentRow.Cells["NGAYKB"].Value.ToString();
                string[] ngaykb1 = ngaykb.Split(' ');
                string tinhtrangbandau = dgvBang.CurrentRow.Cells["TINHTRANGBANDAU"].Value.ToString();
                string ketluanbacsi = dgvBang.CurrentRow.Cells["KETLUANBACSI"].Value.ToString();
                string mabn = dgvBang.CurrentRow.Cells["MABN"].Value.ToString();
                string matt = dgvBang.CurrentRow.Cells["MATT"].Value.ToString();
                string mabs = dgvBang.CurrentRow.Cells["MABS"].Value.ToString();

                string query = "update sec_mgr." + cmbBang.Text + " set NGAYKB = to_date('" + ngaykb1[0] + "','mm/dd/yyyy'), TINHTRANGBANDAU = '"
                    + tinhtrangbandau + "', KETLUANBACSI = '" + ketluanbacsi + "', MABN = " + mabn + ", MATT = '" + matt + "', MABS = '" + mabs + 
                    "' where MAKB = " + makb;

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
                    MessageBox.Show("Bạn nhập sai trường hoặc nhập dữ liệu không tồn tại", "Thông báo");
                    Function.Con.Close();
                }
            }
        }
    }
}
