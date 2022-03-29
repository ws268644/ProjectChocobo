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
            string sEventName = txt_EventName.Text;
            DateTime dtStartDate = dtp_StartDate.Value;
            DateTime dtEndDate = dtp_EndDate.Value;

            
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
