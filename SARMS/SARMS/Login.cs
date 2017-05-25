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
            
            
            if (id > 0 && id <= 499)
            {
                MainMenu_Admin MainMenuFormAdmin = new MainMenu_Admin(id);
                MainMenuFormAdmin.Show();
                this.Hide();
            }
            else if (id > 500 && id <= 1999)
            {
                MainMenu_Teacher MainMenuFormTeacher = new MainMenu_Teacher(id);
                MainMenuFormTeacher.Show();
                this.Hide();
            }
            else if (id >= 2000)
            {
                MainMenu_Student MainMenuFormStudent = new MainMenu_Student(id);
                MainMenuFormStudent.Show();
                this.Hide();
            }
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
