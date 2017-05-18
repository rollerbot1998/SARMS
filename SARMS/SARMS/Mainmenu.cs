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
    public partial class MainMenu_Admin : Form
    {

        


        //initialise variables
        int users_id = 0;
        string fname = "";
        string lname = "";
        string email = "";
        string dob = "";
        int suspended = 1;

        
         

        public MainMenu_Admin(int id)
        {
            InitializeComponent();
            users_id = id;

            //load all of users data from the database
            //setup connection
            var dbcon = new DBConnect();
            
            fname = dbcon.Select_user_fname(id);

            lname = dbcon.Select_user_lname(id);

            email = dbcon.Select_user_email(id);

            dob = dbcon.Select_user_dob(id);

            suspended = dbcon.Select_user_suspended(id);
            
        }

        private void MainMenu_Admin_Load(object sender, EventArgs e)
        {

        }

        private void About_Button_Click(object sender, EventArgs e)
        {
            //display about form
            About aboutform = new About();
            aboutform.Show();

            
        }
        //clicking search button event
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var dbcon = new DBConnect();
            int id = 0;
            //parse text in textbox to int id
          if (int.TryParse(textboxID.Text, out id))
            {
                //replace label text with returned information
               labelFname.Text = dbcon.Select_user_fname(id);
               labelLname.Text = dbcon.Select_user_lname(id);
               labelEmail.Text = dbcon.Select_user_email(id);
               labelID.Text = users_id +"";
                labelDob.Text = dbcon.Select_user_dob(id);               
               labelSuspended.Text = dbcon.Select_user_suspended(id)+"";

            }
            else
            {
                //failing parse display error message and clear textboxID
                MessageBox.Show("invalid id", "unsuccessful", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                textboxID.Text = "";
            }    
            
        }
        private void Admin_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (string.Equals((sender as Button).Name, @"CloseButton"))
            {
               Form loginform = new Form1();
                loginform.Close();
                Console.WriteLine("X button was pressed");
            }
            else
            {
                Console.WriteLine("X button was pressed");
            }
  }

<<<<<<< HEAD
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = PasswordBox.Text;
            string unit = unitBox.Text;
            int id = 0;

            //reset loading bar
            progressBar1.Value = 0;

            //get user id    NOTE: id of 0 will be returned if connection fails!!!!!!
            var dbcon = new DBConnect();
            id = dbcon.login(username, password);

            if (id == 0)
            {
                //login unsuccesful
                MessageBox.Show("invalid username or password", "unsuccesful", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

            else
            {
                //check that unit exists
                bool unit_exists = dbcon.unit_exists(unit);

                //update loading bar
                progressBar1.Value = 10;

                if (unit_exists == true)
                {
                    int link_table_id = dbcon.student_in_unit(unit, id);

                    //update loading bar
                    progressBar1.Value = 25;

                    if (link_table_id != 0)
                    {
                        int attended = dbcon.get_class_attendance(link_table_id);
                        int run = dbcon.get_classes_run(link_table_id);
                        //build string to put in label
                        string display = "" + attended + " / " + run + "";
                        //display 
                        classesDisplay.Text = display;

                        float percent = 0;

                        //update loading bar
                        progressBar1.Value = 50;

                        //get students percentage of assesments
                        int student_assesment_total = dbcon.get_assesment_results(link_table_id);
                        int no_of_assesments = dbcon.get_total_assesments(link_table_id);
                        if (no_of_assesments != 0)
                        {
                             percent = student_assesment_total / no_of_assesments;
                        }
                        else
                        {
                             percent = 0;
                        }
                        //update loading bar
                        progressBar1.Value = 100;

                        //make percentage string
                        display = string.Format("{0:N2}", percent);
                        //display percentage
                        displayPercentage.Text = display;
                    }
                    else
                    {
                        //student not in unit
                        MessageBox.Show("you are not enroled in this unit", "unsuccesful", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    //invalid unit
                    MessageBox.Show("invalid unit", "unsuccesful", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        
=======
        private void kill_Click(object sender, EventArgs e)
        {
            Form loginform = new Form1();
            loginform.Close();
        }
>>>>>>> origin/master
    }
}
