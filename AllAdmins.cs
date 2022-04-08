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
    public partial class AllAdmins : Form
    {
        public AllAdmins()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AllAdmins_Load(object sender, EventArgs e)
        {
            // Populate the admin combo box with all admins
            List<string> stAdmins = getAdminNames();
            List<string> stUsers;

            foreach (string st in stAdmins)
            {
                cbo_selectAdmins.Items.Add(st);
            }



            

            
        }

        private void cbo_selectAdmins_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If Admin selects themselves, then remove the delete button
            if(checkRole(sUsername) == "Admin")
            {
                btn_delete.Hide();
            }
            else
            {
                btn_delete.Show();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            profiles profilesPage = new profiles();
            nextPage(this, profilesPage);
        }

        private void cbo_users_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
