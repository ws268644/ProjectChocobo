using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjectChocobo.clsUtility;
using static ProjectChocobo.clsDatabase;

namespace ProjectChocobo
{
    public partial class profiles : Form
    {
        public profiles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewProfile newProfilePage = new NewProfile();
            newProfilePage.ShowDialog();
            this.Close();
        }

        private void btn_seeAllProfiles_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllRacers allProfilesPage = new AllRacers();
            allProfilesPage.ShowDialog();
            this.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            
            Home homePage = new Home();
            nextPage(this, homePage);
        }

        private void profiles_Load(object sender, EventArgs e)
        {
            switch(sUserRole)
            {
                case "Admin": btn_newProfile.Show(); break;
                case "Steward": btn_SeeAllStewards.Show(); btn_SeeAllAdmins.Show(); btn_SeeAllAdmins.Hide(); break;
                case "Racer": btn_newProfile.Hide(); btn_SeeAllStewards.Hide(); btn_SeeAllAdmins.Hide(); break;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AllStewards allStewardsPage = new AllStewards();
            nextPage(this, allStewardsPage);
        }

        private void btn_SeeAllAdmins_Click(object sender, EventArgs e)
        {
            AllAdmins allAdminsPage = new AllAdmins();
            nextPage(this, allAdminsPage);
        }
    }
}
