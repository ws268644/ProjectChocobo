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
using static ProjectChocobo.clsDatabase;

namespace ProjectChocobo
{
    public partial class StewardMenu : Form
    {
        public StewardMenu()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Events eventsPage = new Events();
            nextPage(this, eventsPage);
        }

        private void btn_pastRaces_Click(object sender, EventArgs e)
        {
            dgv_RaceViewer.DataSource = getAllRaces();
        }
    }
}
