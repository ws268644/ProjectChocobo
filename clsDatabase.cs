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

        static public Boolean login(string strUser, string strPass) { //Login function
            
            MySqlConnection cnn = new MySqlConnection(conString); //Sets connection string as an actual SQL connection
            MySqlCommand comLogin = new MySqlCommand("checkLogin", cnn);
            comLogin.CommandType = System.Data.CommandType.StoredProcedure; //Tells C# to treat the command as a stored procedure
            comLogin.Parameters.AddWithValue("@loginUsername", strUser);
            comLogin.Parameters.AddWithValue("@loginPassword", strPass);
            try
            {
                cnn.Open();
                int loginCheck  = Convert.ToInt32(comLogin.ExecuteScalar());
                if (loginCheck == 1)
                {
                 cnn.Close();
                 return true;
                }
                intUserID = Convert.ToInt32(comGetID.ExecuteScalar());
                int intSuccess = Convert.ToInt32(comApplyUserRole.ExecuteNonQuery());
                cnn.Close();

                if (intSuccess == 0)
                {
                    return false; //If something went wrong and the user wasn't added it will return a false.
                }
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            return false;

        }
    }
}
