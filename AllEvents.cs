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
    public partial class AllEvents : Form
    {
        public AllEvents()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Events eventsPage = new Events();
            eventsPage.ShowDialog();
            this.Close();

        }

        private void AllEvents_Load(object sender, EventArgs e)
        {



            /*
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
                    spc_AllEvents.Panel1.Controls.Add(btn_newButton);
                }
                yLocation = yLocation + 25;
            }
            */



        }



        void btn_newButton_Click(object sender, EventArgs e)
        {
            // Link to a Event profile

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedEvent = cbo_selectedEvent.Text;
        }
    }
}
