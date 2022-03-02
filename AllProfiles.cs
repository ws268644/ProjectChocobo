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
    public partial class AllProfiles : Form
    {
        public AllProfiles()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            profiles profilePage = new profiles();
            profilePage.ShowDialog();
            this.Close();
        }

        private void AllProfiles_Load(object sender, EventArgs e)
        {
            for (int iCount = 0; iCount < clsDatabase.getAllUsers().Rows.Count; iCount++)
            {

                string sContent = clsDatabase.getAllUsers().Rows[1]["fname"].ToString();

                cbo_selectedProfiles.Items.Add(sContent);


            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sSelectedRace = cbo_selectedProfiles.Text;
            
            
        }
    }
}
