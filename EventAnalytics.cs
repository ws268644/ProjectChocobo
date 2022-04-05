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
    public partial class EventAnalytics : Form
    {
        public EventAnalytics()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Events eventsPage = new Events();
            nextPage(this, eventsPage);
        }

        private void crt_EventAnalytics_Click(object sender, EventArgs e)
        {
            
        }

        private void EventAnalytics_Load(object sender, EventArgs e)
        {





            DataTable dtSelectedEvent = getAllRaces();

            foreach (DataRow dt in dtSelectedEvent.Rows)
            {
                lbl_EventName.Text = dt.ItemArray[1].ToString();
                lbl_UserNameHeadline.Text = dt.ItemArray[1].ToString();
                lbl_EventDate.Text = dt.ItemArray[2].ToString();
                lbl_Attendees.Text = dt.ItemArray[3].ToString();
                lbl_EventCompleted.Text = dt.ItemArray[4].ToString();
                txt_eventRacers.Text = dt.ItemArray[4].ToString();
            }

            // Y axis change, but X axis dont
            crt_EventAttendance.Series["Attendance"].Points.AddXY(getAllRaces());


        }
    }
}
