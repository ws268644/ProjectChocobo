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
using static ProjectChocobo.clsUtility;

namespace ProjectChocobo
{
    public partial class AllStewards : Form
    {
        public AllStewards()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            profiles profilePage = new profiles();
            nextPage(this, profilePage);
        }

        private void cbo_selectStewards_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If Admin selects themselves, then remove the delete button
            if (checkRole(sUsername) == "admin")
            {
                btn_delete.Hide();
            }
            else
            {
                btn_delete.Show();
            }
        }
    }
}
