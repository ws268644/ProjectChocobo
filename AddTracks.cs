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
    public partial class AddTracks : Form
    {
        public AddTracks()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home homePage = new Home();
            homePage.ShowDialog();
            this.Close();
        }

        private void Tracks_Load(object sender, EventArgs e)
        {
            

        }
    }
}
