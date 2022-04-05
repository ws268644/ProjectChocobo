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
            this.Hide();
            Events eventsPage = new Events();
            eventsPage.ShowDialog();
            this.Close();

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

            





        }

        private void spc_AllEvents_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void spc_AllEvents_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
