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
    public partial class NewProfile : Form
    {
        public NewProfile()
        {
            InitializeComponent();
        }

        private void NewProfile_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_AddRacer_Click(object sender, EventArgs e)
        {
            string firstName = txt_FirstName.Text;
            string lastName = txt_LastName.Text;

            string password = txt_Password.Text;


            // Check to make sure that the password is the same as the entered confirmed password
            if(txt_Password.Text == txt_ConfirmPassword.Text)
            {
                // Make a profile and add to the database
            }

        }
    }
}
