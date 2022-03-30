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
            // Get the values of the event fields
            string sEventName = txt_EventName.Text;
            DateTime dtStartDate = dtp_StartDate.Value;
            DateTime dtEndDate = dtp_EndDate.Value;

            // Convert the start and end times to integers for processing
            int iStartTime = int.Parse(txt_startTime.Text);
            int iFinishTime = int.Parse(txt_endTime.Text);


            // Currency types
            Boolean bPound = rdo_PoundSterlingToggle.Checked;
            Boolean bDollar = rdo_DollarToggle.Checked;
            Boolean bEuro = rdo_EuroToggle.Checked;




            // Check if name is given
            if(txt_EventName == null)
            {
                lbl_NewEventError.Text = "WARNING: No name has been entered";
            }

            // Check if start date is not greater than end date or the end date being lesser than the start date
            if (dtp_StartDate.Value >= dtp_EndDate.Value || dtp_EndDate.Value <= dtp_StartDate.Value)
            {
                lbl_NewEventError.Text = "WARNING: Event dates are not compatable";
            }


            // Check if start time is not greater than finish time or the finish time being lesser than the start time
            if (iStartTime >= iFinishTime || iFinishTime <= iStartTime)
            {
                lbl_NewEventError.Text = "WARNING: Event dates are not compatable";
            }



            // Check if no currency has been selected
            if (bPound == false && bDollar == false && bEuro == false)
            {
                lbl_NewEventError.Text = "WARNING: No currency has been selected";
            }

            // Check if ticket price has been entered
            if(txt_TicketPrice.Text == null)
            {
                lbl_NewEventError.Text = "WARNING: No ticket price has been entered.";
            }



            // If all checks out, then submit
            
            
            
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
