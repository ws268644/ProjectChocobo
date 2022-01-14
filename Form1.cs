using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

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
            profiles frmProfiles = new profiles();

            frmProfiles.Show();
            
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btn_events_Click(object sender, EventArgs e)
        {
            Events frmEvents = new Events();

            frmEvents.Show();
        }

        private void btn_tracks_Click(object sender, EventArgs e)
        {
            Tracks frmTracks = new Tracks();

            frmTracks.Show();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            Settings frmSettings = new Settings();

            frmSettings.Show();
        }
    }
}
