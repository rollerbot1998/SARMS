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
    public partial class MainMenu_Teacher : Form
    {




        //initialise variables
        int users_id = 0;
        string fname = "";
        string lname = "";
        string email = "";
        string dob = "";
        int suspended = 1;




        public MainMenu_Teacher(int id)
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
                        labelFname.Text = dbcon.Select_user_fname(id);
                        labelLname.Text = dbcon.Select_user_lname(id);
                        labelEmail.Text = dbcon.Select_user_email(id);
                        labelID.Text = users_id + "";
                        labelDob.Text = dbcon.Select_user_dob(id);
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

        

        

        private void Submit_result_Click(object sender, EventArgs e)
        {
            //set variables
            int converted_assnum;
            int converted_result;
            progressBar4.Value = 0;

            //convert assignment number from string
            bool result = Int32.TryParse(Assignment_number.Text, out converted_assnum);
            if (result)
            {
                Console.WriteLine("Converted assignment number.", Assignment_number.Text, converted_assnum);
            }
            else
            {

                Console.WriteLine("Attempted conversion of assignment number failed.");

                MessageBox.Show("Invalid assignment number", "Unsuccessful", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                return;
            }



            //convert result from string
            result = Int32.TryParse(Assignment_result.Text, out converted_result);
            if (result)
            {
                progressBar4.Value = 50;
                Console.WriteLine("Converted assignment number.", Assignment_number.Text, converted_result);
            }
            else
            {

                Console.WriteLine("Attempted conversion of assignment result failed.");

                MessageBox.Show("Invalid result number", "Unsuccessful", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                progressBar4.Value = 0;
                return;
            }




            //make dbcon object
            var dbcon = new DBConnect();

            //get the user number of the student 
            int usernumber = dbcon.get_user_id(Students_username.Text);

            //make sure usernumber returned non 0
            if (usernumber != 0)
            {
                progressBar4.Value = 50;
                int assignment_id = dbcon.get_assignment_id(usernumber, Unit_code.Text);

                //check id isn't 0
                if (assignment_id != 0)
                {

                    //commit result
                    bool success = dbcon.set_assesment_results(assignment_id, converted_assnum, converted_result);

                    if (success)
                    {
                        progressBar4.Value = 100;
                        MessageBox.Show("results added", "success", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    }
                }
                //assignment table entry not found
                else
                {
                    MessageBox.Show("that user is not enroled in the unit", "Unsuccessful", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }

            }
            //user doesn't exist
            else
            {
                MessageBox.Show("Invalid username", "Unsuccessful", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }


        }

        private void Submit_attendance_Click(object sender, EventArgs e)
        {
            progressBar3.Value = 0;
            int class_number;

            //check if attended is ticked or not
            int attended = 1;
            //if so set attended to 2 to signify attendance
            if (checkBoxAttended.Checked)
            {
                attended = 2;
            }

            //convert class number from string
            bool result = Int32.TryParse(Class_number.Text, out class_number);
            if (result)
            {
                Console.WriteLine("Converted class number.", Assignment_number.Text, class_number);
            }
            else
            {
                Console.WriteLine("Attempted conversion of class number failed.");

                MessageBox.Show("Invalid class number", "Unsuccessful", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                progressBar3.Value = 0;
                return;
            }



            //make dbcon object
            var dbcon = new DBConnect();
            progressBar3.Value = 10;
            //get the user number of the student 
            int usernumber = dbcon.get_user_id(Students_username.Text);
            //make sure usernumber returned non 0
            if (usernumber != 0)
            {
                int class_id = dbcon.get_class_id(usernumber, Unit_code.Text);

                //check id isn't 0
                if (class_id != 0)
                {
                    //commit class
                    progressBar3.Value = 50;
                    bool success = dbcon.set_class_attendance(class_id, class_number, attended);

                    if (success)
                    {
                        MessageBox.Show("results added", "success", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                        progressBar3.Value = 100;
                    }
                }
                //class table entry not found
                else
                {
                    MessageBox.Show("that user is not enroled in the unit", "Unsuccessful", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
            }
            //user doesn't exist
            else
            {
                MessageBox.Show("Invalid username", "Unsuccessful", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }

        private void textBoxRetreival_TextChanged(object sender, EventArgs e)
        {

        }

        private void teacherGenerateReport_Click(object sender, EventArgs e)
        {
            progressBarTeacher.Value = 0;

            //make dbcon object
            var dbcon = new DBConnect();

            //get student id
            int id = dbcon.get_user_id(Students_username.Text);

            //check id was found
            if (id != 0)
            {
                progressBarTeacher.Value = 10;
                //check unit exists
                if (dbcon.unit_exists(Unit_code.Text))
                {
                    int link_table_id = dbcon.student_in_unit(Unit_code.Text, id);

                    //update loading bar
                    progressBarTeacher.Value = 25;

                    if (link_table_id != 0)
                    {
                        int attended = dbcon.get_class_attendance(link_table_id);
                        int run = dbcon.get_classes_run(link_table_id);
                        //build string to put in label
                        string display = "" + attended + " / " + run + "";
                        //display 
                        teacherAttendance.Text = display;

                        float percent = 0;

                        //update loading bar
                        progressBarTeacher.Value = 50;

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
                        progressBarTeacher.Value = 100;

                        //make percentage string
                        display = string.Format("{0:N2}", percent);
                        //display percentage
                        teacherPerformance.Text = display;

                    }
                    else
                    {

                    }
                }
                else
                {
                    //student not in unit
                    MessageBox.Show("you are not enroled in this unit", "unsuccesful", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
            }
            //id not found
            else
            {

            }
        }


    }
}

