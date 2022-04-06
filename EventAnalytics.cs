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



            
            // Y axis change, but X axis dont
            crt_EventAttendance.Series["Attendance"].Points.AddXY(getAllRaces());


        }
    }
}
