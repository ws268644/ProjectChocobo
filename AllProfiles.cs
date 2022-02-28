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
            int iProfiles = 4;
            int xLocation = 5;
            int yLocation = 5;

            for (int iCount = 0; iCount < iProfiles; iCount++)
            {
                {
                    Button btn_newButton = new Button();
                    btn_newButton.Name = "btn_newButton";
                    btn_newButton.Text = "New Button";
                    btn_newButton.Location = new System.Drawing.Point(xLocation, yLocation);
                    btn_newButton.AutoSize = true;
                    btn_newButton.Click += new EventHandler(btn_newButton_Click);
                    //this.Controls.Add(btn_newButton);
                    spc_profilesSplit.Panel1.Controls.Add(btn_newButton);
                }
                yLocation = yLocation + 25;
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }



        void btn_newButton_Click(object sender, EventArgs e)
        {



            // Fill panel 2 with information for the selected profile.
            Label lbl_Name = new Label();
            lbl_Name.Name = "lbl_name";
            lbl_Name.Text = "";


        }
    }
}
