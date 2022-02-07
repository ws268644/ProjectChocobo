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

        private void dgv_ProfilesDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AllProfiles_Load(object sender, EventArgs e)
        {
            Button btn_newButton = new Button();
            btn_newButton.Name = "btn_newButton";
            btn_newButton.Text = "New Button";
            btn_newButton.Location = new System.Drawing.Point(22, 10);
            btn_newButton.AutoSize = true;
            btn_newButton.Click += new EventHandler(btn_newButton_Click);
            this.Controls.Add(btn_newButton);
        }





        void btn_newButton_Click(object sender, EventArgs e)
        {


            for (int iCount = 0; iCount < 4; iCount++)
            {
                Label lbl_staticLabel = new Label();

                lbl_staticLabel.Name = "lbl_label_";
                lbl_staticLabel.Text = "It's label " + iCount.ToString() + "!";
                lbl_staticLabel.Location = new System.Drawing.Point(22 + (iCount * 50), 112 + (iCount * 70));
                lbl_staticLabel.Font = new System.Drawing.Font("Wingdings", 20, FontStyle.Bold);
                lbl_staticLabel.AutoSize = true;
                this.Controls.Add(lbl_staticLabel);
            }



        }
    }
}
