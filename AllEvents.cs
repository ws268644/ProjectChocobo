using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using static ProjectChocobo.clsDatabase;
using static ProjectChocobo.clsUtility;

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
            Events eventsPage = new Events();
            nextPage(this, eventsPage);

        }

        private void AllEvents_Load(object sender, EventArgs e)
        {

            foreach (string sRace in getAllRaces())
            {
                cbo_selectedEvent.Items.Add(sRace);
            }

        }








            string PopulateSection(string selectedEvent)
        {
            string eventInfo = "";

            
            
            

            return(eventInfo);
        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedEvent = cbo_selectedEvent.Text;

            DataTable dtSelectedEvent = getEvent(selectedEvent);

            foreach(DataRow dt in dtSelectedEvent.Rows)
            {
                lbl_EventName.Text = dt.ItemArray[1].ToString();
                lbl_UserNameHeadline.Text = dt.ItemArray[1].ToString();
                lbl_EventDate.Text = dt.ItemArray[2].ToString();
                lbl_Attendees.Text = dt.ItemArray[3].ToString();
                lbl_EventCompleted.Text = dt.ItemArray[4].ToString();
                txt_eventRacers.Text = dt.ItemArray[4].ToString();
            }



        }

        private void spc_AllEvents_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void spc_AllEvents_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
