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


            for(int iCount = 0; iCount < clsDatabase.getAllUsers().Rows.Count; iCount ++)
            {

                string sContent = clsDatabase.getAllUsers().Rows[1]["fname"].ToString();

                cbo_selectedEvent.Items.Add(sContent);
                
                
            }


            
            
        }



        string PopulateSection(string selectedEvent)
        {
            string eventInfo = "";

            clsDatabase.getAllUsers();
            
            

            return(eventInfo);
        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedEvent = cbo_selectedEvent.Text;



        }







    }
}
