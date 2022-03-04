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
            AllProfiles allProfilesPage = new AllProfiles();
            allProfilesPage.ShowDialog();
            this.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home homePage = new Home();
            homePage.ShowDialog();
            this.Close();
        }

        private void profiles_Load(object sender, EventArgs e)
        {

        }
    }
}
