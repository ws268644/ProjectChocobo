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
            List<string> lt = getAdminNames();

            cbo_selectAdmins.Items.Add(lt);
        }

        private void cbo_selectAdmins_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If Admin selects themselves, then remove the delete button
            if(checkRole(sUsername, "Admin") == 1)
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
