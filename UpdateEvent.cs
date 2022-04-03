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
    public partial class UpdateEvent : Form
    {
        public UpdateEvent()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home mainMenu = new Home();
            mainMenu.ShowDialog();
            this.Close();
        }

        private void UpdateEvent_Load(object sender, EventArgs e)
        {
            foreach(string sEvent in getAllRaces())
            {
                cbo_ExistingEventName.Items.Add(sEvent);
            }



        }

        private void cbo_ExistingEventName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sSelectedEvent = this.Text;
            DataTable dtSelectedEvent = getEvent(sSelectedEvent);

            //txt_eventDescription.Text = dtSelectedEvent.
            
        }
    }
}
