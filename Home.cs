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
using static ProjectChocobo.clsUtility;

namespace ProjectChocobo
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_profiles_Click(object sender, EventArgs e)
        {

            profiles newProfiles = new profiles();

            nextPage(this, newProfiles);


            /*
            this.Hide();
            NewProfile profiles = new NewProfile();
            profiles.ShowDialog();
            this.Close();
            */


        }

        private void btn_events_Click(object sender, EventArgs e)
        {
            
        }

        private void Home_Load(object sender, EventArgs e)
        {
            switch(sUserRole)
            {
                case "Racer": btn_tracks.Hide(); break;
                case "Steward": btn_tracks.Hide(); break;
                case "Admin": btn_tracks.Show(); break;
            }
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            
            Settings settingsPage = new Settings();
            nextPage(this, settingsPage);
            
        }

        private void btn_tracks_Click(object sender, EventArgs e)
        {
            Tracks tracksPage = new Tracks();
            nextPage(this, tracksPage);
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            login loginPage = new login();
            
            logout();
            nextPage(this, loginPage);

            
            
        }

        private void btn_events_Click_1(object sender, EventArgs e)
        {
            Events eventsPage = new Events();
            nextPage(this, eventsPage);
        }

        private void btn_tracks_Click_1(object sender, EventArgs e)
        {
            Tracks tracksPage = new Tracks();
            nextPage(this, tracksPage);
        }
    }
}
