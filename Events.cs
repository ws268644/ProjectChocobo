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
    public partial class Events : Form
    {
        public Events()
        {
            InitializeComponent();
        }

        private void Events_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllEvents allEventsPage = new AllEvents();
            allEventsPage.ShowDialog();
            this.Close();
        }

        private void btn_newEvents_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewEvent newEventPage = new NewEvent();
            newEventPage.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home mainMenu = new Home();
            mainMenu.ShowDialog();
            this.Close();
        }
    }
}
