using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjectChocobo.clsDatabase;

namespace ProjectChocobo
{
    public partial class NewProfile : Form
    {
        public NewProfile()
        {
            InitializeComponent();
        }

        private void NewProfile_Load(object sender, EventArgs e)
        {
            cbo_userRole.Items.Add("Racer");
            cbo_userRole.Items.Add("Steward");
            cbo_userRole.Items.Add("Admin");


            foreach (string sCar in getCars())
            {
                cbo_userVehicle.Items.Add(sCar);
            }

            


        }

        private void btn_AddRacer_Click(object sender, EventArgs e)
        {
            string sFirstName = txt_FirstName.Text;
            string sLastName = txt_LastName.Text;
            string sUsername = txt_username.Text;
            string sPassword = txt_Password.Text;
            string sRole = cbo_userRole.Text;
            string sVehicle = cbo_userVehicle.Text;

            // Check to make sure that the password is the same as the entered confirmed password
            if(txt_Password.Text == txt_ConfirmPassword.Text)
            {
                // Make a profile and add to the database

                createNewUser(sUsername, sPassword);
                applyUserRole(sUsername, sRole);
                

            }

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            profiles profilePage = new profiles();
            profilePage.ShowDialog();
            this.Close();
        }
    }
}
