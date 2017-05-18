﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//Add MySql Library
using MySql.Data.MySqlClient;

namespace SARMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 



[STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            

            //initiate nessisary variables
            bool running = true;
            



            //initiate main loop
            while (running == true)
            {
                //main loop of the program when this exits program exits

            }





            //application exit
            Application.Exit();


        }
    }

    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "sql9.freesqldatabase.com";
            database = "sql9174922";
            uid = "sql9174922";
            password = "bQF5891SwU";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void Insert()
        {
            string query = "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void Update()
        {
            string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        
        //Update SARMS_users statement
        public void Update_SARMS_users(int id , string field, string data)
        {
            string query = "UPDATE SARMS_users SET "+ field + "= '" + data + "' WHERE id= " + id + " ;";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        
        //Update user's suspended status
        public void Update_SARMS_users(int id, bool suspended)
        {
            if (suspended = true)
            {
                string query_true = "UPDATE SARMS_users SET suspended = 1 WHERE id= " + id + " ;";

                //Open connection
                if (this.OpenConnection() == true)
                {
                    //create mysql command
                    MySqlCommand cmd = new MySqlCommand();
                    //Assign the query using CommandText
                    cmd.CommandText = query_true;
                    //Assign the connection using Connection
                    cmd.Connection = connection;

                    //Execute query
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }
            }
            else
            {
                string query_false = "UPDATE SARMS_users SET suspended = 0 WHERE id= " + id + " ;";

                //Open connection
                if (this.OpenConnection() == true)
                {
                    //create mysql command
                    MySqlCommand cmd = new MySqlCommand();
                    //Assign the query using CommandText
                    cmd.CommandText = query_false;
                    //Assign the connection using Connection
                    cmd.Connection = connection;

                    //Execute query
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }

            
            }
        }

        //add user to SARMS_users
        //note for type 1 = admin, 2 = teacher, other = student
        public void Add_SARMS_User(int type ,string username, string password, string first_name, string last_name, string email, string dob )
        {
            //find open usernumber in table
            //get range of user number based on type
            int range_min = 0;
            int range_max = 0;

            switch (type)
            {
                case 0:
                    //admin
                    range_min = 1;
                    range_max = 500;
                    break;
                case 1:
                    //teacher
                    range_min = 501;
                    range_max = 2000;
                    break;
                default:
                    //student
                    range_min = 2001;
                    range_max = 999999999;
                    break;
            }

            //loop through database until empty space is found
            int loop = range_min;

            //set default user number
            int usernumber = 0;

            //open connection
            if (this.OpenConnection() == true)
            {

                while (loop <= range_max)
                {
                    try
                    {
                        //build query
                        string query_loop = "SELECT first_name FROM SARMS_users WHERE usernumber =" + loop + ";";

                        //used to store reply
                        string fname = "error";


                        //create command
                        MySqlCommand cmd_loop = new MySqlCommand(query_loop, connection);

                        //Create a data reader and Execute the command
                        MySqlDataReader dataReader = cmd_loop.ExecuteReader();

                        while (dataReader.Read())
                        {
                            fname = dataReader.GetString("first_name");
                        }


                        //close Data Reader
                        dataReader.Close();


                        loop = loop + 1;
                    }
                    catch
                    {
                        Console.WriteLine("free user space found");
                        usernumber = loop;
                    }
                }

               


                //build sql statement 
                string query = "INSERT INTO SARMS_users (usernumber, username, password, first_name, last_name, email, dob, suspended) VALUES(" + usernumber + "," + username + "," + password + "," + first_name + "," + last_name + "," + email + "," + dob + ", 0 )";


                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        
        //Delete statement
        public void Delete(int id)
        {
            string query = "DELETE FROM SARMS_users WHERE usernumber="+id+";";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Select statement
        public List<string>[] Select()
        {
            string query = "SELECT * FROM tableinfo";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["name"] + "");
                    list[2].Add(dataReader["age"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }
               
        //get firstname statement
        public string Select_user_fname(int id)
        {
            //build query
            string query = "SELECT first_name FROM SARMS_users WHERE usernumber =" + id + ";";

            //used to store reply
            string fname = "error";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    fname = dataReader.GetString("first_name");
                }


                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return fname;
            }
            //return 0
            else
            {
                return fname;
            }

        }

        //get lastname statement
        public string Select_user_lname(int id)
        {
            //build query
            string query = "SELECT last_name FROM SARMS_users WHERE usernumber =" + id + ";";

            //used to store reply
            string lname = "error";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    lname = dataReader.GetString("last_name");
                }


                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return lname;
            }
            //return 0
            else
            {
                return lname;
            }

        }

        //get email statement
        public string Select_user_email(int id)
        {
            //build query
            string query = "SELECT email FROM SARMS_users WHERE usernumber =" + id + ";";

            //used to store reply
            string email = "error";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    email = dataReader.GetString("email");
                }


                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return email;
            }
            //return 0
            else
            {
                return email;
            }

        }

        //get dob statement
        public string Select_user_dob(int id)
        {
            //build query
            string query = "SELECT dob FROM SARMS_users WHERE usernumber =" + id + ";";

            //used to store reply
            string dob = "error";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    dob = dataReader.GetString("dob");
                }


                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return dob;
            }
            //return 0
            else
            {
                return dob;
            }

        }

        //get suspended statement
        public int Select_user_suspended(int id)
        {
            //build query
            string query = "SELECT suspended FROM SARMS_users WHERE usernumber =" + id + ";";

            //used to store reply
            int suspended = 1;

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    suspended = dataReader.GetInt32(dataReader.GetOrdinal("suspended"));
                }


                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return suspended;
            }
            //return 0
            else
            {
                return suspended;
            }

        }

        //login statement
        public int login(string username, string password)
        {
            //build query
            string query = "SELECT usernumber FROM SARMS_users WHERE username = '" + username + "' AND password ='" + password + "' ;";

            //used to store reply
            int id = 0;

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    id = dataReader.GetInt32(dataReader.GetOrdinal("usernumber"));
                }


                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return id;
            }
            //return 0
            else
            {
                return id;
            }

        }

        //Count statement
        public int Count()
        {
            string query = "SELECT Count(*) FROM tableinfo";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

    /*   //Backup
        public void Backup()
        {
            try
            {
                DateTime Time = DateTime.Now;
                int year = Time.Year;
                int month = Time.Month;
                int day = Time.Day;
                int hour = Time.Hour;
                int minute = Time.Minute;
                int second = Time.Second;
                int millisecond = Time.Millisecond;

                //Save file to C:\ with the current date as a filename
                string path;
                path = "C:\\MySqlBackup" + year + "-" + month + "-" + day +
            "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
                StreamWriter file = new StreamWriter(path);


                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysqldump";
                psi.RedirectStandardInput = false;
                psi.RedirectStandardOutput = true;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                    uid, password, server, database);
                psi.UseShellExecute = false;

                Process process = Process.Start(psi);

                string output;
                output = process.StandardOutput.ReadToEnd();
                file.WriteLine(output);
                process.WaitForExit();
                file.Close();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to backup!");
            }
        }

        //Restore
        public void Restore()
        {
            try
            {
                //Read file from C:\
                string path;
                path = "C:\\MySqlBackup.sql";
                StreamReader file = new StreamReader(path);
                string input = file.ReadToEnd();
                file.Close();

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysql";
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = false;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                    uid, password, server, database);
                psi.UseShellExecute = false;


                Process process = Process.Start(psi);
                process.StandardInput.WriteLine(input);
                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to Restore!");
            }
        }
        
        
        }*/
    }

}
