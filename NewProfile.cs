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
            //MessageBox.Show("Button pressed");
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

                Boolean success = false;
                // Assign Role
                switch(cbo_userRole.Text)
                {
                    case "Racer": applyRacerRole(sUsername, sFirstName + " " + sLastName, sVehicle).ToString(); MessageBox.Show("Adding Racer");  break;
                    case "Admin": success = applyUserRole(sUsername, sRole.ToLower()); MessageBox.Show("Adding Admin"); break;
                    case "Steward": success = applyUserRole(sUsername, sRole.ToLower()); MessageBox.Show("Adding Steward"); break;


                    default: MessageBox.Show("Jumped to default"); break;
                }

             

            }
            else if (txt_Password.Text != txt_ConfirmPassword.Text)
            {
                tmr_Warning.Start();
                lbl_Warning.Text = "WARNING: Passwords do not match";
            }

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            profiles profilePage = new profiles();
            profilePage.ShowDialog();
            this.Close();
        }

        private void cbo_userRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbo_userVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileExplorer = new OpenFileDialog();

            fileExplorer.ShowDialog();

            // Work in progress
            //Image selectedImage = fileExplorer.OpenFile();
        }

        private void tmr_Warning_Tick(object sender, EventArgs e)
        {
            tmr_Warning.Stop();
            lbl_Warning.Hide();
        }
    }
}
