using System;
using System.Collections.Generic;
using System.Data;
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
            MySqlCommand comLogin = new MySqlCommand("@checkLogin", cnn);
            comLogin.CommandType = System.Data.CommandType.StoredProcedure; //Tells C# to treat the command as a stored procedure
            comLogin.Parameters.AddWithValue("@loginUsername", strUser);
            comLogin.Parameters.AddWithValue("@loginPassword", strPass);
            try
            {
                cnn.Open();
                int loginCheck = Convert.ToInt32(comLogin.ExecuteScalar());
                if (loginCheck == 1)
                {
                    cnn.Close();
                    return true;
                }
                cnn.Close();    
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error:\n" + ex);
            }
            return false;
        }


        

        static public void createNewUser(String strUsername, String strPassword)
        {
            if (strUsername == "") {
                MessageBox.Show("Please enter a username");
            }
            if (strPassword == "") {
                MessageBox.Show("Please enter a password");
            }
            MySqlConnection cnn = new MySqlConnection(conString); //Sets connection string as an actual SQL connection
            MySqlCommand comCreateUser = new MySqlCommand("createNewUser", cnn);
            MySqlCommand comCheckUser = new MySqlCommand("usernameTakenCheck", cnn);
            comCreateUser.CommandType = System.Data.CommandType.StoredProcedure; //Tells C# to treat the command as a stored procedure
            comCheckUser.CommandType = System.Data.CommandType.StoredProcedure;
            comCreateUser.Parameters.AddWithValue("@username", strUsername);
            comCreateUser.Parameters.AddWithValue("@password", strPassword);
            comCheckUser.Parameters.AddWithValue("@username", strUsername);
            try
            {
                cnn.Open();
                int userCheck = Convert.ToInt32(comCheckUser.ExecuteScalar()); //Checks if the users username already exists

                if (userCheck > 0)
                {
                    cnn.Close();
                    MessageBox.Show("There is a user that already exists with this username");
                    return;
                }
                int intSuccess = Convert.ToInt32(comCreateUser.ExecuteNonQuery()); //Number represented is how many rows were affected. If it returns one, it worked fine.
                cnn.Close();
                if (intSuccess == 1)
                {
                    MessageBox.Show("User added successfully");
                }
                else
                {
                    MessageBox.Show("There was an error.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error:\n" + ex);
            }
            
        }
        static public Boolean applyUserRole(string strUsername)
        {
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
                if (usernameCheck == 0)
                {
                    cnn.Close();
                    return false; //If the username doesn't exist then it won't try to apply the user role
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
        }
        static public DataTable getAllUsers() {
            MySqlConnection cnn = new MySqlConnection(conString); //Sets connection string as an actual SQL connection
            MySqlCommand comGetUsers = new MySqlCommand("getAllUsers", cnn);
            comGetUsers.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            dataAdapter.SelectCommand = comGetUsers;
            DataTable dt = new DataTable();
            try
            {
                cnn.Open();
                dataAdapter.Fill(dt);
                cnn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error: \n" + ex.ToString());
            }
            return null;
            
        }
    }

    }
