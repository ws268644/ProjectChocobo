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
        static public Boolean createNewUser(String strUsername, String strPassword)
        {
            MySqlConnection cnn = new MySqlConnection(conString); //Sets connection string as an actual SQL connection
            MySqlCommand comCreateUser = new MySqlCommand("createUser", cnn);
            MySqlCommand comCheckUser = new MySqlCommand("usernameTakenCheck", cnn);
            comCreateUser.CommandType = System.Data.CommandType.StoredProcedure; //Tells C# to treat the command as a stored procedure
            comCheckUser.CommandType = System.Data.CommandType.StoredProcedure;
            comCreateUser.Parameters.AddWithValue("@username", strUsername);
            comCreateUser.Parameters.AddWithValue("@username", strPassword);
            comCheckUser.Parameters.AddWithValue("@username", strUsername);
            try
            {
                cnn.Open();
                int userCheck = Convert.ToInt32(comCheckUser.ExecuteScalar()); //Checks if the users username already exists
                if (userCheck < 0)
                {
                    cnn.Close();
                    return false;
                }
                int intSuccess = Convert.ToInt32(comCreateUser.ExecuteNonQuery()); //Number represented is how many rows were affected. If it returns one, it worked fine.
                cnn.Close();
                if (intSuccess == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error:\n" + ex);
            }
            return false;
        }

    }

    }

