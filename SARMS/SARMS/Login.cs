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
            //check login with server if good go to main screen

            //open connection with the sql server
            SqlConnection myConnection = new SqlConnection("user id=ljjohnso;" +
                                       "password=Funhaus2017;server=interactive.deakin.edu.au;" +
                                       "Trusted_Connection=yes;" +
                                       "database=SSID; " +
                                       "connection timeout=30");
            //open connection
            try
            {
                myConnection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine ("it didn't work");
            }

            

            try
            {
                SqlDataReader myReader = null;
                //formulate command
                SqlCommand myCommand = new SqlCommand("SELECT * FROM SARMS_users WHERE username like '" + username.Text + "'; ", myConnection);

                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    Console.WriteLine(myReader["Column1"].ToString());
                    Console.WriteLine(myReader["Column2"].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(e.ToString());
            }

            //close the connection
            try
            {
                myConnection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(e.ToString());
            } 

            //make main menu form
            MainMenu_Admin MainMenuForm = new MainMenu_Admin();


            //open main menu form
            MainMenuForm.Show();

            //close this form
            this.Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
