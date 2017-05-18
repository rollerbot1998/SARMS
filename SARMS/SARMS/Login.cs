using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            //get user id    NOTE: id of 0 will be returned if connection fails!!!!!!
            var dbcon = new DBConnect();
            int id = dbcon.login(Username_box.Text, Password_box.Text);

            if (id != 0)
            {
                //make main menu form
                MainMenu_Admin MainMenuForm = new MainMenu_Admin(id);

                Console.WriteLine(id);

                //open main menu form
                MainMenuForm.Show();

                //close this form
                this.Hide();
            }
            //if login is unsuccesful tell the user
            else
            {
                //login unsuccesful
                MessageBox.Show("invalid username or password", "unsuccesful", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
