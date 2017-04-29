using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SARMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        

        private void login_button_Click(object sender, EventArgs e)
        {
            //check login with server if good go to main screen


            //make main menu form
            Mainmenu MainMenuForm = new Mainmenu();


            //open main menu form
            MainMenuForm.Show();

            //close this form
            this.Close();

        }
    }
}
