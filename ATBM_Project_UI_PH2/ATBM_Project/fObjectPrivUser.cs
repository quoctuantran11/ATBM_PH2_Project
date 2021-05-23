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
    public partial class fObjectPrivUser : Form
    {
        public fObjectPrivUser()
        {
            InitializeComponent();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            Function.Con.Open();
            string username = Searchtxt.Text;

            OracleCommand cmd = new OracleCommand("sp_PrivilegeUser", Function.Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_User", OracleDbType.Varchar2).Value = username;

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            ResultDgv.DataSource = dt;

            Function.Con.Close();
        }
    }
}
