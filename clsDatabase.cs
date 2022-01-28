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
            MySqlCommand mycom = new MySqlCommand("@checkLogin", cnn);
            mycom.CommandType = System.Data.CommandType.StoredProcedure; //Tells C# to treat the command as a stored procedure


        }
        static public Boolean applyUserRole(string strUsername) {
            int intUserID = 0;
            MySqlConnection cnn = new MySqlConnection(conString); //Sets connection string as an actual SQL connection
            MySqlCommand comApplyUserRole = new MySqlCommand("applyUserRole", cnn);
            MySqlCommand comGetID = new MySqlCommand("getUserID", cnn);
            MySqlCommand checkUsername = new MySqlCommand("usernameTakenCheck", cnn);
            comApplyUserRole.CommandType = System.Data.CommandType.StoredProcedure; //Tells C# to treat the command as a stored procedure
            comGetID.CommandType = System.Data.CommandType.StoredProcedure;
            comGetID.Parameters.AddWithValue("@username", strUsername);
            checkUsername.Parameters.AddWithValue("@username", strUsername);
            comApplyUserRole.Parameters.AddWithValue("@userID", intUserID);
            try
            {
                cnn.Open();
                int usernameCheck = Convert.ToInt32(checkUsername.ExecuteScalar());
                if (usernameCheck == 0) {
                    cnn.Close();
                    return false; //If the username doesn't exist then it won't try to apply the user role
                }
                intUserID = Convert.ToInt32(comGetID.ExecuteScalar());
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
