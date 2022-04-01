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
    public partial class UpdateEvent : Form
    {
        public UpdateEvent()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home mainMenu = new Home();
            mainMenu.ShowDialog();
            this.Close();
        }

        private void UpdateEvent_Load(object sender, EventArgs e)
        {
            cbo_EventSelect.Items.Add = getall
        }
    }
}
