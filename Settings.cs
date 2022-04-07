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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home mainMenu = new Home();
            

            nextPage(this, mainMenu);
            
        }
    }
}
