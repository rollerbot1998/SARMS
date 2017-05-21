﻿using System;
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
            progressBar2.Value = 10;
            var dbcon = new DBConnect();
            int id = 0;
            progressBar2.Value = 25;
            //parse text in textbox to int id
          if (int.TryParse(textboxID.Text, out id))
            {
                progressBar2.Value = 50;
                //replace label text with returned information
                labelFname.Text = dbcon.Select_user_fname(id);
               labelLname.Text = dbcon.Select_user_lname(id);
               labelEmail.Text = dbcon.Select_user_email(id);
               labelID.Text = users_id +"";
                labelDob.Text = dbcon.Select_user_dob(id);               
               labelSuspended.Text = dbcon.Select_user_suspended(id)+"";
                progressBar2.Value = 100;
            }
            else
            {
                //failing parse display error message and clear textboxID
                MessageBox.Show("invalid id", "unsuccessful", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                textboxID.Text = "";
                progressBar2.Value = 0;
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

        private void generate_Click(object sender, EventArgs e)
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
                MessageBox.Show("Invalid username and/or password.", "Unsuccesful", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                //clear input fields
                usernameBox.Text = "";
                PasswordBox.Text = "";
                unitBox.Text = "";
                progressBar1.Value = 0;
                   
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
                    MessageBox.Show("Invalid unit", "unsuccesful", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);                    
                    unitBox.Text = "";
                    progressBar1.Value = 0;
                }
            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }    

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void addPassword_Click(object sender, EventArgs e)
        {

        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            //add user based on data given
            //get data from fields
            int type = 0;
            string temp = userType.GetItemText(userType.SelectedItem);
            switch (temp)
            {
                case "Student":
                    type = 3;
                    break;
                case "Teacher":
                    type = 2;
                    break;
                case "Admin":
                    type = 1;
                    break;
             }

            string username = usernameTextbox.Text;
            string password = passwordTextbox.Text;
            string fname = firstnameTextbox.Text;
            string lname = lastnameTextbox.Text;
            string email = emailTextbox.Text;

            string dob = dateTimePicker.Value.ToString("dd/MM/yyyy");

            //check fields are not empty if one is return
            if (type ==0)
            {
                MessageBox.Show("invalid type", "unsuccesful", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                return;
            }
            if (username == "")
            {
                MessageBox.Show("invalid username", "unsuccesful", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                return;
            }

            if (password == "")
            {
                MessageBox.Show("invalid password", "unsuccesful", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                return;
            }
            if (fname == "")
            {
                MessageBox.Show("invalid first name", "unsuccesful", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                return;
            }
            if (lname == "")
            {
                MessageBox.Show("invalid last name", "unsuccesful", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                return;
            }
            if (email == "")
            {
                MessageBox.Show("invalid Email", "unsuccesful", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                return;
            }

            var dbcon = new DBConnect();

            //check if username is already in use
            int check = dbcon.Select_user_id(fname, lname);

            if (check != 0)
            {
                MessageBox.Show("user already exists with id "+check, "unsuccesful", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                return;
            }

            check = dbcon.login(username, password);

            if (check != 0)
            {
                MessageBox.Show("user already exists with id " + check, "unsuccesful", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                return;
            }

            //commit to database

            dbcon.Add_SARMS_User(type, username, password, fname, lname, email, dob);
            MessageBox.Show("User "+ username +" created succesfuly", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);


        }

        private void enrol_in_unit_button_Click(object sender, EventArgs e)
        {
            //get variables
            string fname = SFName.Text;
            string lname = SLName.Text;
            string unit = enrolUnit.Text;

            //check fields are not empty
            if (fname == "")
            {
                MessageBox.Show("invalid first name", "unsuccesful", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                return;
            }
            if (lname == "")
            {
                MessageBox.Show("invalid last name", "unsuccesful", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                return;
            }
            if (unit == "")
            {
                MessageBox.Show("invalid Unit", "unsuccesful", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                return;
            }

            //make dbconnector
            var dbcon = new DBConnect();

            //check unit exists
            if (dbcon.unit_exists(unit))
            {
                //enrol student

                //get id
                int id = dbcon.Select_user_id(fname, lname);


                dbcon.student_unit(id, unit);

                MessageBox.Show("User with id:" + id + " has been sucessfuly enrolled in unit " + unit, "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Unit " + unit + " does not exist, make sure you spelt it with uppercase letters e.g CAS324", "unsuccesful", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textboxID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
