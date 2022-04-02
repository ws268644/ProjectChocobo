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
            // Fill in the steward list with all steward profiles
            foreach (string sSteward in getStewardNames())
            {
                cbo_selectSteward.Items.Add(sSteward);
            }


            foreach (string sTracks in getAllTracks())
            {
                cbo_TrackName.Items.Add(sTracks);
            }




        }

        private void btn_addEvent_Click(object sender, EventArgs e)
        {
            // Get the values of the event fields
            string sEventName = txt_EventName.Text;
            
            DateTime dtStartDate = dtp_StartDate.Value;
            DateTime dtEndDate = dtp_EndDate.Value;
            string sTrack = cbo_TrackName.Text;
            string sSteward = cbo_selectSteward.Text;
            int iPrice = int.Parse(txt_TicketPrice.Text);
            string sEventDescription = txt_eventDescription.Text;

            // Convert the start and end times to integers for processing
            DateTime dtStartTime = dtp_StartTime.Value;
            DateTime dtFinishTime = dtp_FinishTime.Value;
            string sStartTime = dtp_StartTime.Value.ToString();
            string sFinishTime = dtp_FinishTime.Value.ToString();



            // Currency types
            Boolean bPound = rdo_PoundSterlingToggle.Checked;
            Boolean bDollar = rdo_DollarToggle.Checked;
            Boolean bEuro = rdo_EuroToggle.Checked;

            // This is going to be interesting, trying to combine all checks needed into variables that will fit into one if statement.
            var vCheckName = txt_EventName == null; // Check if name is given
            var vCheckDates = dtp_StartDate.Value >= dtp_EndDate.Value || dtp_EndDate.Value <= dtp_StartDate.Value; // Check if start date is not greater than end date or the end date being lesser than the start date
            var vCheckTime = dtStartTime >= dtFinishTime || dtFinishTime <= dtStartTime; // Check if start time is not greater than finish time or the finish time being lesser than the start time
            var vCheckCurrency = bPound == false && bDollar == false && bEuro == false; // Check if no currency has been selected
            var vCheckTicketPrice = txt_TicketPrice.Text == null; // Check if ticket price has been entered



            // There NEEDS to be some way to combine all of this into a switch statement.
            // Check if name is given
            if (vCheckName)
            {
                lbl_NewEventError.Text = "WARNING: No name has been entered";
            }

            // Check if start date is not greater than end date or the end date being lesser than the start date
            if (vCheckDates)
            {
                lbl_NewEventError.Text = "WARNING: Event dates are not compatable";
            }


            // Check if start time is not greater than finish time or the finish time being lesser than the start time
            if (vCheckTime)
            {
                lbl_NewEventError.Text = "WARNING: Event dates are not compatable";
            }



            // Check if no currency has been selected
            if (vCheckCurrency)
            {
                lbl_NewEventError.Text = "WARNING: No currency has been selected";
            }

            // Check if ticket price has been entered
            if(vCheckTicketPrice)
            {
                lbl_NewEventError.Text = "WARNING: No ticket price has been entered.";
            }



            // If all checks out, then submit
            if (vCheckName == false && vCheckDates == false && vCheckCurrency == false && vCheckTime == false && vCheckTicketPrice == false)
            {
                createNewRace(sEventName, sTrack, sSteward, iPrice, dtStartDate, dtEndDate, sStartTime, sFinishTime, sEventDescription);
            }


           
            
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cbo_TrackName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
