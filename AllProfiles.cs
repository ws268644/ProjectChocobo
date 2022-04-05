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
    public partial class AllProfiles : Form
    {
        public AllProfiles()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            profiles profilePage = new profiles();
            profilePage.ShowDialog();
            this.Close();
        }

        private void AllProfiles_Load(object sender, EventArgs e)
        {
            // Fill combo box with all Racer Profile
            foreach (string sRacer in getRacerNames())
            {
                cbo_selectRacers.Items.Add(sRacer);
            }



            // Fill in the steward list with all steward profiles
            foreach (string sSteward in getStewardNames())
            {
                cbo_selectSteward.Items.Add(sSteward);
            }

            // Fill Events list with Events
            foreach (string sEvent in getAllRaces())
            {
                cbo_Events.Items.Add(sEvent);
            }


        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sSelectedProfile = cbo_selectRacers.SelectedItem.ToString();
            DataTable dtSelectedProfile = getAllUsers(sSelectedProfile);


            foreach (DataRow dt in dtSelectedProfile.Rows)
            {
                lbl_FullName.Text = dt.ItemArray[1].ToString() + "" + dt.ItemArray[2].ToString();
                lbl_UserName.Text = dt.ItemArray[3].ToString();
                

            }



            
        }

        private void btn_AddRacerToRace_Click(object sender, EventArgs e)
        {
            // if there is nothing selected when submitted
            if (cbo_Events.SelectedIndex.ToString() == null)
            {
                lbl_Warning.Visible = true;
                lbl_Warning.Text = "WARNING: No Event has been selected!";
            }
            else
            {
                // Add Racer to Event
                
            }
        }
    }
}
