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
    public partial class NewEvent : Form
    {
        public NewEvent()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Events eventsPage = new Events();
            eventsPage.ShowDialog();
            this.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void NewEvent_Load(object sender, EventArgs e)
        {

        }

        private void btn_addEvent_Click(object sender, EventArgs e)
        {
            string sEventName = txt_EventName.Text;
            DateTime dtStartDate = dtp_StartDate.Value;
            DateTime dtEndDate = dtp_EndDate.Value;

            decimal iRacers = nud_entryFee.Value;
            decimal iAttendees = nud_Attendees.Value;

            string startTime = txt_startTime.Text;
            string endTime = txt_endTime.Text;

            string eventDesc = txt_description.Text;

            createNewRace(sEventName, strStewardName, intEntryFee, dtStartDate, dtEndDate, startTime, endTime, eventDesc);
        }
    }
}
