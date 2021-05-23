using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;



namespace WindowsFormsApp1
{
    public class Function
    {
        public static string username;
        public static string password;

        // public static string constring = username + password;    // Sai.
        public static string constring;

        public static OracleConnection Con;

        public static void setConstring()
        {
            constring = "User ID =" + username + "; Password =" + password + ";Data Source = localhost:1521/XE";
        }

        public static void updateCon()
        {
            Con = new OracleConnection(constring);
        }
    }
}  
