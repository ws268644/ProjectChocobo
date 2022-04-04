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
    public partial class updateTracks : Form
    {
        public updateTracks()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tracks tracksPage = new Tracks();
            tracksPage.ShowDialog();
            this.Close();
        }

        private void updateTracks_Load(object sender, EventArgs e)
        {
            foreach (string sTracks in getAllTracks())
            {
                cboTrackSelect.Items.Add(sTracks);
            }
        }
    }
}
