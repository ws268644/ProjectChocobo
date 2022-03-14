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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string sUsername = txtUsername.Text;
            string sPassword = txtPassword.Text;

            


            Boolean bLogin = login(sUsername, sPassword);

            if(bLogin == true)
            {
                this.Hide();
                Home homePage = new Home();
                homePage.ShowDialog();
                this.Close();
            }
            else
            {

                tmr_ErrorMessage.Start();
                lbl_ErrorMessage.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tmr_ErrorMessage.Stop();
            lbl_ErrorMessage.Hide();
        }
    }
}

