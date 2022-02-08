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
    public partial class EditProfile : Form
    {
        public EditProfile()
        {
            InitializeComponent();
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {

            int iProfiles = 4;

            for (int iCount = 0; iCount < iProfiles; iCount++)
            {

                Label lbl_staticLabel = new Label();

                lbl_staticLabel.Name = "lbl_label_";
                lbl_staticLabel.Text = "It's label " + iCount.ToString() + "!";
                lbl_staticLabel.Location = new System.Drawing.Point(22 + (iCount * 50), 112 + (iCount * 70));
                lbl_staticLabel.Font = new System.Drawing.Font("Arial", 20, FontStyle.Bold);
                lbl_staticLabel.AutoSize = true;
                this.Controls.Add(lbl_staticLabel);


                Button profileButton = new Button();
                {
                    profileButton.Name = string.Format("Profile{0}" , iProfiles);
                    profileButton.Text = string.Format("Profile{0}", iProfiles);
                    
                }


            }



        }







        private void lbl_ProfilePageTitle_Click(object sender, EventArgs e)
        {

        }

        private void lbl_title_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllProfiles allProfilesPage = new AllProfiles();
            allProfilesPage.ShowDialog();
            this.Close();
        }
    }
}
