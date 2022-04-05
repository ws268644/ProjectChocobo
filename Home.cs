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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_profiles_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewProfile profiles = new NewProfile();
            profiles.ShowDialog();
            this.Close();


        }

        private void btn_events_Click(object sender, EventArgs e)
        {
            
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
            
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login loginPage = new login();
            loginPage.ShowDialog();
            logout();
            this.Close();
            
        }
    }
}
