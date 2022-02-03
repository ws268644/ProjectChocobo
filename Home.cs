using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.Hide();
            profiles profiles = new profiles();
            profiles.ShowDialog();
            this.Close();


        }

        private void btn_events_Click(object sender, EventArgs e)
        {
            this.Hide();
            Events eventPage = new Events();
            eventPage.ShowDialog();
            this.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings settingsPage = new Settings();
            settingsPage.ShowDialog();
            this.Close();
        }

        private void btn_tracks_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tracks tracksPage = new Tracks();
            tracksPage.ShowDialog();
            this.Close();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
