using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            verLabel.Text = Version.GetVersionNumber();
        }


        private void login_button_Click(object sender, EventArgs e)
        {
            //get user id    NOTE: id of 0 will be returned if connection fails!!!!!!            
            var dbcon = new DBConnect();            
            int id = dbcon.login(Username_box.Text, Password_box.Text);
            
            if (id != 0)
            {
                //generate login box
                
                //make main menu form
                MainMenu_Admin MainMenuForm = new MainMenu_Admin(id);
                

                Console.WriteLine(id);
                //open main menu form                
                MainMenuForm.Show();

                //close this form                              
                this.Hide();                
            }
            /*else if (id >= 501)
            {
                //TODO launch separate form
            }*/
            //if login is unsuccesful tell the user
            else
            {
                //login unsuccesful
                MessageBox.Show("Invalid username and/or password", "Unsuccesful", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                //clear input boxes 
                Username_box.Text = "";
                Password_box.Text = "";
                
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

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
