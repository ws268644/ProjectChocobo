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
using static ProjectChocobo.clsEvent;

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

            string sSelectedEvent = cbo_ExistingEventName.SelectedItem.ToString();
            DataTable dtSelectedEvent = getEvent(sSelectedEvent);



            


            // Populate the fields with the selected event
            foreach (DataRow dr in dtSelectedEvent.Rows)
            {
                txt_NewEventName.Text = dr.ItemArray[0].ToString();
                cbo_TrackName.Text = dr.ItemArray[1].ToString();
                cbo_selectSteward.Text = dr.ItemArray[2].ToString();
                txt_TicketPrice.Text = dr.ItemArray[3].ToString();
                dtp_StartDate.Value = Convert.ToDateTime(dr.ItemArray[8].ToString());
                dtp_StartTime.Value = Convert.ToDateTime(dr.ItemArray[6].ToString());
                dtp_EndDate.Text = dr.ItemArray[9].ToString();
                dtp_FinishTime.Text = dr.ItemArray[7].ToString();
                txt_eventDescription.Text = dr.ItemArray[10].ToString();

            }
        }

        private void btn_addEvent_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Events eventsPage = new Events();
            eventsPage.ShowDialog();
            this.Close();
        }
    }
}
