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
            Tracks tracksPage = new Tracks();
            tracksPage.ShowDialog();
            this.Close();
        }

        private void Tracks_Load(object sender, EventArgs e)
        {
            

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string strTrackName = txtTrackName.Text;
            int iLaps = (int) nudLapCount.Value;
            string strTrackType = cboTrackType.SelectedItem.ToString();
            int  iTrackCapacity = (int) nudTrackCapacity.Value;
            string strDriveTrain = cboDriveTrain.Text;
            int adminID = 0;

            addTrack(strTrackName, iLaps, strTrackType, iTrackCapacity, strDriveTrain);
        }
    }
}
