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
using Oracle.ManagedDataAccess.Types;
using WindowsFormsApp1;

namespace ATBM_Project
{
    public partial class fDropRole : Form
    {
        public fDropRole()
        {
            InitializeComponent();
        }

        private void btnDropRole_Click(object sender, EventArgs e)
        {
            Function.Con.Open();
            OracleCommand cmd = new OracleCommand("sp_DeleteRole", Function.Con);
            cmd.CommandType = CommandType.StoredProcedure;

            string role = txbRole.Text;

            cmd.Parameters.Add("p_role", OracleDbType.Varchar2).Value = role;

            
            string message;
            try
            {
                int data = cmd.ExecuteNonQuery();
                if (data != 0)
                {
                    message = "Drop role " + role + " Successfully";
                    MessageBox.Show(message);
                }
            }
            catch
            {
                message = "Fail to drop role " + role;
                MessageBox.Show(message);
            }
            Function.Con.Close();
        }
    }
}
