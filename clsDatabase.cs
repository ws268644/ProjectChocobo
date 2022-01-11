using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace ProjectChocobo
{
    static class clsDatabase
    {
        static private string conString = "server=ws268644.remote.ac;user = ws268644_Admin;database = ws268644_ProjectChocobo;password =98U*z4rl;CharSet=utf8;SslMode=none;";

        static public void login(string strUser, string strPass) {
            MySqlConnection cnn = new MySqlConnection(conString); //Sets connection string as an actual SQL connection
            MySqlCommand mycom = new MySqlCommand("checkLogin", cnn);
            mycom.CommandType = System.Data.CommandType.StoredProcedure; //Tells C# to treat the command as a stored procedure


        }
    }
}
