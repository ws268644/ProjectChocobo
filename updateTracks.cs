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

        private void cboTrackSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sSelectedEvent = cboTrackSelect.SelectedItem.ToString();
            DataTable dtSelectedEvent = getTrack(sSelectedEvent);
            if (dtSelectedEvent == null) { }
            else
            {
                // Populate the fields with the selected event
                foreach (DataRow dr in dtSelectedEvent.AsEnumerable())
                {
                    txtTrackName.Text = dr.ItemArray[1].ToString();
                    nudLapCount.Text = dr.ItemArray[2].ToString();
                    cboTrackType.Text = dr.ItemArray[3].ToString();
                    nudTrackCapacity.Text = dr.ItemArray[4].ToString();
                    cboDriveTrain.Text = dr.ItemArray[5].ToString();
                }
                MessageBox.Show("Track Updated");
            }
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string index = cboTrackSelect.SelectedItem.ToString();
            string trackName = txtTrackName.Text;
            string trackType = cboTrackType.SelectedItem.ToString();
            int iLaps = (int)nudLapCount.Value;
            int iCapacity = (int)nudTrackCapacity.Value;
            string driveTrain = cboDriveTrain.SelectedItem.ToString();
            updateTrack(index, trackName, iLaps, trackType, iCapacity, driveTrain);
        }
    }
}
