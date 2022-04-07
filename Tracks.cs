using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjectChocobo.clsUtility;

namespace ProjectChocobo
{
    public partial class Tracks : Form
    {
        public Tracks()
        {
            InitializeComponent();
        }

        private void btn_addTracks_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddTracks addtracksPage = new AddTracks();
            addtracksPage.ShowDialog();
            this.Close();
        }

        private void btnUpdateTracks_Click(object sender, EventArgs e)
        {
            this.Hide();
            updateTracks updatetracksPage = new updateTracks();
            updatetracksPage.ShowDialog();
            this.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Home homePage = new Home();
            nextPage(this, homePage);
            
        }
    }
}
