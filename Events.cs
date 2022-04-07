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
    public partial class Events : Form
    {
        public Events()
        {
            InitializeComponent();
        }

        private void Events_Load(object sender, EventArgs e)
        {
            switch (sUserRole)
            {
                case "Admin": btn_newEvents.Show(); break;
                case "Steward": btn_UpdateEvent.Show(); break;
                case "Racer": btn_UpdateEvent.Hide(); btn_newEvents.Hide(); break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            AllEvents allEventsPage = new AllEvents();
            nextPage(this, allEventsPage);
        }

        private void btn_newEvents_Click(object sender, EventArgs e)
        {
            
            NewEvent newEventPage = new NewEvent();
            nextPage(this, newEventPage);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Home mainMenu = new Home();

            nextPage(this, mainMenu);
        }

        private void btn_UpdateEvent_Click(object sender, EventArgs e)
        {
            
            UpdateEvent updateEventPage = new UpdateEvent();
            nextPage(this, updateEventPage);
        }

        private void btn_EventAnalytics_Click(object sender, EventArgs e)
        {
            EventAnalytics eaPage = new EventAnalytics();
            nextPage(this, eaPage);
        }

        private void btn_stewardsMenu_Click(object sender, EventArgs e)
        {
            StewardMenu stewardsPage = new StewardMenu();
            nextPage(this, stewardsPage);
        }
    }
}
