﻿using System;
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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login loginPage = new login();
            loginPage.ShowDialog();
            logout();
            this.Close();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            this.Hide();
            Events eventPage = new Events();
            eventPage.ShowDialog();
            this.Close();
        }

        private void btnTracks_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tracks tracksPage = new Tracks();
            tracksPage.ShowDialog();
            this.Close();
        }

        private void btn_profiles_Click(object sender, EventArgs e)
        {
            this.Hide();
            profiles profiles = new profiles();
            profiles.ShowDialog();
            this.Close();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings settingsPage = new Settings();
            settingsPage.ShowDialog();
            this.Close();
        }
    }
}