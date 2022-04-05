using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using static ProjectChocobo.clsDatabase;

namespace ProjectChocobo
{
    class clsUtility
    {

        static public void nextPage(Form fPreviousForm, Form fNewForm)
        {
            fPreviousForm.Hide();
            fNewForm.ShowDialog();
            fPreviousForm.Close();
        }


        


    }
}
