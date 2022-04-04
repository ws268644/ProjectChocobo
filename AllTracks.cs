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
    public partial class AllTracks : Form
    {
        public AllTracks()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tracks tracksPage = new Tracks();
            tracksPage.ShowDialog();
            this.Close();
        }

        private void spc_AllEvents_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
