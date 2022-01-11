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

        static public Boolean login(string strUser, string strPass) { 

            MySqlConnection cnn = new MySqlConnection(conString); //Sets connection string as an actual SQL connection
            MySqlCommand comLogin = new MySqlCommand("checkLogin", cnn);
            MySqlCommand comPass = new MySqlCommand("checkPassword", cnn);
            comLogin.CommandType = System.Data.CommandType.StoredProcedure; //Tells C# to treat the command as a stored procedure
            comLogin.Parameters.AddWithValue("@loginUsername", strUser);
            comPass.CommandType = System.Data.CommandType.StoredProcedure;
            comPass.Parameters.AddWithValue("@loginPassword", strPass);
            try
            {
                cnn.Open();
                int loginCheck = comLogin.ExecuteNonQuery();
                if (loginCheck == -1) { 
                    int passCheck = comPass.ExecuteNonQuery();
                    cnn.Close();
                    if (passCheck == -1) {
                        return true;
                        
                    }
                }
                cnn.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error:\n"+ex);
            }
            return false;
        }
    }
}
