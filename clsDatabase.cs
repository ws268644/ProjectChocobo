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
    static public class clsDatabase
    {
        static private string conString = "server=ws268644.remote.ac;user = ws268644_Admin;database = ws268644_ProjectChocobo;password =26?kyuT2;CharSet=utf8;SslMode=none;";

        // Save logged in person
        static public string sUsername;
        static public string sUserRole;

        static public Boolean login(string strUser, string strPass)
        {
            //Login function
            sUsername = strUser;
            
            switch(checkRole(strUser))
            {
                case "Admin": sUserRole = "Admin"; break;
                case "Steward": sUserRole = "Steward"; break;
                case "Racer": sUserRole = "Racer"; break;
            }


            MySqlConnection cnn = new MySqlConnection(conString); //Sets connection string as an actual SQL connection
            MySqlCommand comLogin = new MySqlCommand("checkLogin", cnn);
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


        static public void logout()
        {
            // log the user out of the database.
            sUsername = "";
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


        static public string checkRole(string strUserName)
        {
            

            int adminCheck = 0;
            int stewardCheck = 0;
            int racerCheck = 0;
            MySqlConnection cnn = new MySqlConnection(conString); //Sets connection string as an actual SQL connection
            MySqlCommand checkAdmin = new MySqlCommand("checkAdmin", cnn);
            MySqlCommand checkSteward = new MySqlCommand("checkSteward", cnn);
            MySqlCommand checkRacer = new MySqlCommand("checkRacer", cnn);
            checkAdmin.CommandType = System.Data.CommandType.StoredProcedure;
            checkSteward.CommandType = System.Data.CommandType.StoredProcedure;
            checkRacer.CommandType = System.Data.CommandType.StoredProcedure;
            checkAdmin.Parameters.AddWithValue("userName", strUserName);
            checkSteward.Parameters.AddWithValue("userName", strUserName);
            checkRacer.Parameters.AddWithValue("userName", strUserName);
            try
            {
                cnn.Open();
                adminCheck = Convert.ToInt32(checkAdmin.ExecuteScalar());

                stewardCheck = Convert.ToInt32(checkSteward.ExecuteScalar());

                racerCheck = Convert.ToInt32(checkRacer.ExecuteScalar());
                cnn.Close();
                if (adminCheck == 1) { return "Admin"; }
                if (stewardCheck == 1) { return "Steward"; }
                if (racerCheck == 1) { return "Racer"; }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return null;
        }


        static public Boolean applyUserRole(string strUsername, string strRole)
        {
            int intUserID = 0;
            string strCommand = "";
            if (strRole == "admin")
            {
                strCommand = "addAdmin";
            }
            else if (strRole == "steward")
            {
                strCommand = "addSteward";
            }
            else
            {
                MessageBox.Show("Something went wrong. The role was probably wrong");
                return false;
            }
            MySqlConnection cnn = new MySqlConnection(conString); //Sets connection string as an actual SQL connection
            MySqlCommand comApplyUserRole = new MySqlCommand(strCommand, cnn);
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

        static public Boolean addTrack(string strTrackName, int intLaps, string strTrackType, int intTrackCapacity, string strDriveTrain) {
            MySqlConnection cnn = new MySqlConnection(conString); //Sets connection string as an actual SQL connection
            MySqlCommand comAddTrack = new MySqlCommand("addTrack", cnn);
            comAddTrack.CommandType = System.Data.CommandType.StoredProcedure; //Tells C# to treat the command as a stored procedure

            comAddTrack.Parameters.AddWithValue("@trackName", strTrackName);
            comAddTrack.Parameters.AddWithValue("@trackLaps", intLaps);
            comAddTrack.Parameters.AddWithValue("@trackType", strTrackType);
            comAddTrack.Parameters.AddWithValue("@trackCapacity", intTrackCapacity);
            comAddTrack.Parameters.AddWithValue("@trackDriveTrain", strDriveTrain);

            try
            {
                cnn.Open();
                int success = Convert.ToInt32(comAddTrack.ExecuteNonQuery());//Runs the stored procedure
                cnn.Close();
                if (success == 1)
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
                MessageBox.Show("There was an error: \n" + ex.ToString());
                return false;
            }
        }

        static public DataTable getUser(string sUser) 
        {
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
            return dt;
            
        }
        static public DataTable getRacer(string sUser)
        {
            string strCommand = "getRacerHistory";
            MySqlConnection cnn = new MySqlConnection(conString); //Sets connection string as an actual SQL connection
            MySqlCommand comGetRacers = new MySqlCommand(strCommand, cnn);
            comGetRacers.CommandType = System.Data.CommandType.StoredProcedure;
            comGetRacers.Parameters.AddWithValue("@username", sUser);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            dataAdapter.SelectCommand = comGetRacers;
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
            return dt;

        }
        static public DataTable getSteward(string sUser) {
            string strCommand = "getStewardRaces";
            MySqlConnection cnn = new MySqlConnection(conString); //Sets connection string as an actual SQL connection
            MySqlCommand comGetRacers = new MySqlCommand(strCommand, cnn);
            comGetRacers.CommandType = System.Data.CommandType.StoredProcedure;
            comGetRacers.Parameters.AddWithValue("@username", sUser);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            dataAdapter.SelectCommand = comGetRacers;
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
            return dt;
        }


        static public void deleteUser(string sName)
        {
            string strCommand = "deleteUser";
            MySqlConnection cnn = new MySqlConnection(conString); //Sets connection string as an actual SQL connection
            MySqlCommand comDelUser = new MySqlCommand(strCommand, cnn);
            comDelUser.CommandType = System.Data.CommandType.StoredProcedure;
            comDelUser.Parameters.AddWithValue("@username", sName);

            try
            {
                cnn.Open();
                comDelUser.ExecuteNonQuery();
                cnn.Close();

                MessageBox.Show(sName + " has been successfully deleted.");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error: \n" + ex.ToString());
            }
            
        }




        static public DataTable getAllRacers()
        {
            MySqlConnection cnn = new MySqlConnection(conString); //Sets connection string as an actual SQL connection
            MySqlCommand comGetRacers = new MySqlCommand("getAllRacers", cnn);
            comGetRacers.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            dataAdapter.SelectCommand = comGetRacers;
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
            return dt;

        }
        static public Boolean applyRacerRole(string strUsername, string strFullName, string strCarName)
        {
            int intUserID = 0;
            MySqlConnection cnn = new MySqlConnection(conString); //Sets connection string as an actual SQL connection
            MySqlCommand comAddRacer = new MySqlCommand("addRacer", cnn);
            MySqlCommand comGetID = new MySqlCommand("getUserID", cnn);
            //MySqlCommand checkUsername = new MySqlCommand("usernameTakenCheck", cnn);
            comAddRacer.CommandType = System.Data.CommandType.StoredProcedure; //Tells C# to treat the command as a stored procedure
            comGetID.CommandType = System.Data.CommandType.StoredProcedure;
            comGetID.Parameters.AddWithValue("@username", strUsername);
            //checkUsername.Parameters.AddWithValue("@username", strUsername);
            comAddRacer.Parameters.AddWithValue("@userID", intUserID);
            comAddRacer.Parameters.AddWithValue("@racerName", strFullName);
            comAddRacer.Parameters.AddWithValue("@carName", strCarName);
            try
            {
                cnn.Open();
                /*int usernameCheck = 1; //Convert.ToInt32(checkUsername.ExecuteScalar());
                if (usernameCheck >= 0)
                {
                    cnn.Close();
                    return false; //If the username doesn't exist then it won't try to apply the user role
                }
                MessageBox.Show("Username is all good");*/
                intUserID = Convert.ToInt32(comGetID.ExecuteScalar());
                int intSuccess = Convert.ToInt32(comAddRacer.ExecuteNonQuery());
                MessageBox.Show("Racer has been added successfully");
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



        static public List<string> getCarNames()
        {
            MySqlConnection cnn = new MySqlConnection(conString);
            List<string> cars = new List<string>();
            MySqlCommand comGetCarNames = new MySqlCommand("getCarNames", cnn);
            comGetCarNames.CommandType = System.Data.CommandType.StoredProcedure;


            try
            {
                cnn.Open();
                MySqlDataReader rdr = comGetCarNames.ExecuteReader();

                while (rdr.Read())
                {
                    cars.Add(rdr.GetString(0));


                }

                cnn.Close();

            }
            catch (Exception ex)
            {

            }

            return cars;

        }
        static public List<string> getRacerNames()
        {
            MySqlConnection cnn = new MySqlConnection(conString);
            List<string> uids = new List<string>();
            string myCom = "SELECT t_racers.racer_name FROM t_racers;";
            MySqlCommand myCommand = new MySqlCommand(myCom, cnn);


            try
            {
                cnn.Open();
                MySqlDataReader rdr = myCommand.ExecuteReader();

                while (rdr.Read())
                {
                    uids.Add(rdr.GetString(0));


                }

                cnn.Close();

            }
            catch (Exception ex)
            {

            }

            return uids;

        }





        /*
        static public Boolean applyUserRole(string strUsername, string strRole)
        {
            int intUserID = 0;
            string strCommand = "";
            if (strRole == "admin")
            {
                strCommand = "addAdmin";
            }
            else if (strRole == "steward")
            {
                strCommand = "addSteward";
            }
            else
            {
                MessageBox.Show("Something went wrong. The role was probably wrong");
                return false;
            }
            MySqlConnection cnn = new MySqlConnection(conString); //Sets connection string as an actual SQL connection
            MySqlCommand comApplyUserRole = new MySqlCommand(strCommand, cnn);
           //MySqlCommand comGetID = new MySqlCommand("getUserID", cnn);
           // MySqlCommand checkUsername = new MySqlCommand("usernameTakenCheck", cnn);
            comApplyUserRole.CommandType = System.Data.CommandType.StoredProcedure; //Tells C# to treat the command as a stored procedure
            comApplyUserRole.Parameters.AddWithValue("@username", strUsername);
            //checkUsername.Parameters.AddWithValue("@username", strUsername);
            //comApplyUserRole.Parameters.AddWithValue("@userID", intUserID);
            try
            {
                cnn.Open();
                /*int usernameCheck = Convert.ToInt32(checkUsername.ExecuteScalar());
                if (usernameCheck == 0)
                {
                    cnn.Close();
                    return false; //If the username doesn't exist then it won't try to apply the user role
                }*/
        //intUserID = Convert.ToInt32(comGetID.ExecuteScalar());
        /*
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
*/

        static public List<string> getCars()
        {
            MySqlConnection cnn = new MySqlConnection(conString);
            List<string> carNames = new List<string>();
            string myCom = "SELECT t_cars.car_name FROM t_cars;";
            MySqlCommand myCommand = new MySqlCommand(myCom, cnn);

            try
            {
                cnn.Open();
                MySqlDataReader rdr = myCommand.ExecuteReader();

                while (rdr.Read())
                {
                    carNames.Add(rdr.GetString(0));


                }

                cnn.Close();

            }
            catch (Exception ex)
            {

            }

            return carNames;

        }


        static public List<string> getStewardNames()
        {
            MySqlConnection cnn = new MySqlConnection(conString);
            List<string> uids = new List<string>();
            MySqlCommand comGetName = new MySqlCommand("getStewardUsernames", cnn);



            try
            {
                cnn.Open();
                MySqlDataReader rdr = comGetName.ExecuteReader();

                while (rdr.Read())
                {
                    uids.Add(rdr.GetString(0));


                }

                cnn.Close();

            }
            catch (Exception ex)
            {

            }

            return uids;

        }



        static public List<string> getAdminNames()
        {
            MySqlConnection cnn = new MySqlConnection(conString);
            List<string> uids = new List<string>();
            MySqlCommand comGetName = new MySqlCommand("getAdminUsernames", cnn);



            try
            {
                cnn.Open();
                MySqlDataReader rdr = comGetName.ExecuteReader();

                while (rdr.Read())
                {
                    uids.Add(rdr.GetString(0));


                }

                cnn.Close();

            }
            catch (Exception ex)
            {

            }

            return uids;

        }


        static public List<string> getAllTracks()
        {
            MySqlConnection cnn = new MySqlConnection(conString);
            List<string> uids = new List<string>();
            string myCom = "SELECT t_tracks.track_name FROM t_tracks;";
            MySqlCommand myCommand = new MySqlCommand(myCom, cnn);

            try
            {
                cnn.Open();
                MySqlDataReader rdr = myCommand.ExecuteReader();

                while (rdr.Read())
                {
                    uids.Add(rdr.GetString(0));


                }

                cnn.Close();

            }
            catch (Exception ex)
            {

            }

            return uids;
        }


        static public List<string> getAllRaces()
        {
            MySqlConnection cnn = new MySqlConnection(conString);
            List<string> uids = new List<string>();
            string myCom = "SELECT t_races.race_name FROM t_races;";
            MySqlCommand myCommand = new MySqlCommand(myCom, cnn);

            try
            {
                cnn.Open();
                MySqlDataReader rdr = myCommand.ExecuteReader();

                while (rdr.Read())
                {
                    uids.Add(rdr.GetString(0));


                }

                cnn.Close();

            }
            catch (Exception ex)
            {

            }

            return uids;
        }


        static public List<string> getUserLogins()
        {
            MySqlConnection cnn = new MySqlConnection(conString);
            List<string> uids = new List<string>();
            string myCom = "SELECT t_users.user_login FROM t_users;";
            MySqlCommand myCommand = new MySqlCommand(myCom, cnn);


            try
            {
                cnn.Open();
                MySqlDataReader rdr = myCommand.ExecuteReader();

                while (rdr.Read())
                {
                    uids.Add(rdr.GetString(0));


                }

                cnn.Close();

            }
            catch (Exception ex)
            {

            }

            return uids;

        }
        static public void createNewRace(string strRaceName, string strTrackName, string strStewardName, int intEntryFee, DateTime startDate, DateTime endDate, string startTime, string endTime, string strRaceDesc)
        {
            string strCommand = "addRace";
            MySqlConnection cnn = new MySqlConnection(conString); //Sets connection string as an actual SQL connection
            MySqlCommand addRace = new MySqlCommand(strCommand, cnn);

            addRace.CommandType = System.Data.CommandType.StoredProcedure; //Tells C# to treat the command as a stored procedure
            addRace.Parameters.AddWithValue("@raceName", strRaceName);
            addRace.Parameters.AddWithValue("@trackName", strTrackName);
            addRace.Parameters.AddWithValue("@stewardName", strStewardName);
            addRace.Parameters.AddWithValue("@entryFee", intEntryFee);
            addRace.Parameters.AddWithValue("@startTime", startTime);
            addRace.Parameters.AddWithValue("@endTime", endTime);
            addRace.Parameters.AddWithValue("@startDate", startDate);
            addRace.Parameters.AddWithValue("@endDate", endDate);
            addRace.Parameters.AddWithValue("@raceDescription", strRaceDesc);
            //Added variables to be used in the stored procedure
            try
            {
                cnn.Open();
                addRace.ExecuteNonQuery(); //Ran the stored procedure
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        static public void addRacerToRace(string raceName, string racerName, int startPosition){
            string strCommand = "addRacerToRace";
            MySqlConnection cnn = new MySqlConnection(conString); //Sets connection string as an actual SQL connection
            MySqlCommand addRacer = new MySqlCommand(strCommand, cnn);

            addRacer.CommandType = System.Data.CommandType.StoredProcedure; //Tells C# to treat the command as a stored procedure
            addRacer.Parameters.AddWithValue("@raceName", raceName);
            addRacer.Parameters.AddWithValue("@racerUser", racerName);
            addRacer.Parameters.AddWithValue("@startPosition", startPosition);

            try
            {
                cnn.Open();
                addRacer.ExecuteNonQuery();
                cnn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        static public DataTable getTrack(string trackName)
        {
            string strCommand = "getTrack";
            MySqlConnection cnn = new MySqlConnection(conString); //Sets connection string as an actual SQL connection
            MySqlCommand getTrack = new MySqlCommand(strCommand, cnn);
            getTrack.CommandType = CommandType.StoredProcedure;
            getTrack.Parameters.AddWithValue("@trackName", trackName);

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            dataAdapter.SelectCommand = getTrack;
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
        
        static public void updateEvent(int raceID, string strRaceName, string strTrackName, string strStewardName, int intEntryFee, DateTime startDate, DateTime endDate, string startTime, string endTime, string strRaceDesc, int raceCompleted)
        {// REMEMBER!!!!!!!!!!!!!!!!!!!
         // Make sure all these fields are filled in! If there are any blank spaces, that will override what's in the database.
            string strCommand = "updateRace";
            MySqlConnection cnn = new MySqlConnection(conString); //Sets connection string as an actual SQL connection
            MySqlCommand updateRace = new MySqlCommand(strCommand, cnn);

            updateRace.CommandType = System.Data.CommandType.StoredProcedure; //Tells C# to treat the command as a stored procedure
            updateRace.Parameters.AddWithValue("@raceID", raceID);
            updateRace.Parameters.AddWithValue("@raceName", strRaceName);
            updateRace.Parameters.AddWithValue("@trackName", strTrackName);
            updateRace.Parameters.AddWithValue("@stewardName", strStewardName);
            updateRace.Parameters.AddWithValue("@entryFee", intEntryFee);
            updateRace.Parameters.AddWithValue("@startTime", startTime);
            updateRace.Parameters.AddWithValue("@endTime", endTime);
            updateRace.Parameters.AddWithValue("@startDate", startDate);
            updateRace.Parameters.AddWithValue("@endDate", endDate);
            updateRace.Parameters.AddWithValue("@raceDescription", strRaceDesc);
            updateRace.Parameters.AddWithValue("@raceComplete", raceCompleted);
            //Added variables to be used in the stored procedure
            try
            {
                cnn.Open();
                updateRace.ExecuteNonQuery(); //Ran the stored procedure
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }





        static public DataTable getEvent(string raceName)
        {
            string strCommand = "getRace";
            MySqlConnection cnn = new MySqlConnection(conString); //Sets connection string as an actual SQL connection
            MySqlCommand getRace = new MySqlCommand(strCommand, cnn);
            getRace.CommandType = CommandType.StoredProcedure;

            getRace.Parameters.AddWithValue("raceName", raceName);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            dataAdapter.SelectCommand = getRace;
            

            DataTable dt = new DataTable();

            try
            {
                cnn.Open();
                getRace.Prepare();
                dataAdapter.Fill(dt);
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error: \n" + ex.ToString());
            }

            return dt;
        }

        static public DataTable getAllUsers(string sRole)
        {
            string strCommand = "";
            switch (sRole)
            {
                case "admin":
                    strCommand = "getAllAdmins";
                    break;

                case "steward":
                    strCommand = "getAllStewards";
                    break;

                case "racer":
                    strCommand = "getAllRacerUsers";
                    break;
                default:
                    break;
            }
            MySqlConnection cnn = new MySqlConnection(conString); //Sets connection string as an actual SQL connection
            MySqlCommand getUsers = new MySqlCommand(strCommand, cnn);
            getUsers.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            dataAdapter.SelectCommand = getUsers;


            DataTable dt = new DataTable();

            try
            {
                cnn.Open();
                getUsers.Prepare();
                dataAdapter.Fill(dt);
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error: \n" + ex.ToString());
            }
            return null;
        }
        static public Boolean updateTrack(string strIndex, string strTrackName, int intLaps, string strTrackType, int intTrackCapacity, string strDriveTrain)
        {
            MySqlConnection cnn = new MySqlConnection(conString); //Sets connection string as an actual SQL connection
            MySqlCommand comUpdateTrack = new MySqlCommand("updateTrack", cnn);
            comUpdateTrack.CommandType = System.Data.CommandType.StoredProcedure; //Tells C# to treat the command as a stored procedure
            comUpdateTrack.Parameters.AddWithValue("@trackIndex", strIndex);
            comUpdateTrack.Parameters.AddWithValue("@trackName", strTrackName);
            comUpdateTrack.Parameters.AddWithValue("@trackLaps", intLaps);
            comUpdateTrack.Parameters.AddWithValue("@trackType", strTrackType);
            comUpdateTrack.Parameters.AddWithValue("@trackCapacity", intTrackCapacity);
            comUpdateTrack.Parameters.AddWithValue("@trackDriveTrain", strDriveTrain);

            try
            {
                cnn.Open();
                int success = Convert.ToInt32(comUpdateTrack.ExecuteNonQuery());//Runs the stored procedure
                cnn.Close();
                if (success == 1)
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
                MessageBox.Show("There was an error: \n" + ex.ToString());
                return false;
            }
        }
        static public string getRacerUserName(string sName)
        {
            string userName = "";
            string strCommand = "getRacerUserName";
            MySqlConnection cnn = new MySqlConnection(conString); //Sets connection string as an actual SQL connection
            MySqlCommand getRacerUserName = new MySqlCommand(strCommand, cnn);
            getRacerUserName.CommandType = CommandType.StoredProcedure;
            getRacerUserName.Parameters.AddWithValue("name", sName);
            //getRacerUserName.Parameters.AddWithValue("name", sName);




            try
            {
                cnn.Open();
                userName = getRacerUserName.ExecuteScalar().ToString();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error: \n" + ex.ToString());
            }
            MessageBox.Show(userName);
            return userName;
        }
    }
}

