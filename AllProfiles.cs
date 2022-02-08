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

        private void dgv_ProfilesDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AllProfiles_Load(object sender, EventArgs e)
        {
            
        }







        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditProfile editProfilePage = new EditProfile();
            editProfilePage.ShowDialog();
            this.Close();

        }
    }
}
