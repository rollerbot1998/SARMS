using System;
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
            /*while (running == true)
            {
                //main loop of the program when this exits program exits

            } */

        



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
        public void Insert(string query)
        {
            

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
        public void Update_SARMS_users(int id, string field, string data)
        {
            string query = "UPDATE SARMS_users SET " + field + "= '" + data + "' WHERE id= " + id + " ;";

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
        public void Add_SARMS_User(int type, string username, string password, string first_name, string last_name, string email, string dob)
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
                        string query_loop = "SELECT usernumber FROM SARMS_users WHERE usernumber =" + loop + ";";

                        //used to store reply
                        int temp = 0;


                        //create command
                        MySqlCommand cmd_loop = new MySqlCommand(query_loop, connection);

                        //Create a data reader and Execute the command
                        MySqlDataReader dataReader = cmd_loop.ExecuteReader();

                        while (dataReader.Read())
                        {
                            temp = dataReader.GetInt32(dataReader.GetOrdinal("link_id"));
                        }

                        //set assignment ID
                        if (temp == 0)
                        {
                            usernumber = loop;
                            //send loop over max to escape
                            loop = range_max + 1;
                            this.CloseConnection();
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
            string query = "DELETE FROM SARMS_users WHERE usernumber=" + id + ";";

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

        //get id statement
        public int Select_user_id (string fname, string lname)
        {
            //build query
            string query = "SELECT usernumber FROM SARMS_users WHERE first_name ='" + fname + "' AND last_name = '" + lname + "';";

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



        //sign user up to class
        public void add_unit(int id, string unit_to_add)
        {
            

            //save variables in these
            int linking_id = 0;
            int assesment_id = 0;
            int class_id = 0;

            //get ids
            //open connection
            if (this.OpenConnection() == true)
            {
                int loop = 1;
                int range_max = 999999999;
                while (loop <= range_max)
                {
                    try
                    {
                        //build query
                        string query_loop = "SELECT link_id FROM SARMS_linking WHERE link_id =" + loop + ";";

                        //used to store reply
                        int temp = 0;


                        //create command
                        MySqlCommand cmd_loop = new MySqlCommand(query_loop, connection);

                        //Create a data reader and Execute the command
                        MySqlDataReader dataReader = cmd_loop.ExecuteReader();

                        while (dataReader.Read())
                        {
                            temp = dataReader.GetInt32(dataReader.GetOrdinal("link_id"));
                        }

                        //set assignment ID
                        if (temp == 0)
                        {
                            linking_id = loop;
                            assesment_id = loop;
                            class_id = loop;
                            //send loop over max to escape
                            loop = range_max + 1;
                            this.CloseConnection();
                        }


                        //close Data Reader
                        dataReader.Close();


                        loop = loop + 1;
                    }
                    catch
                    {
                        Console.WriteLine("free user space found");
                        linking_id = loop;
                    }
                }

            

            


                //make linking table entry
                //build query
                string query = "INSERT INTO SARMS_linking (link_id, student_id, unit_code, assesment_id, classes_id) VALUES ("+ linking_id + ","+id+",'"+ unit_to_add +"',"+ assesment_id+","+class_id+" )";
                //run query
                this.Insert(query);

                //make class table
                query = "insert into SARMS_classes values (" + class_id + ", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)";
                //run query
                this.Insert(query);

                //make assesment table
                query = "insert into SARMS_assignments  values (" + assesment_id + ","+ id + ","+ unit_to_add + ",-1,-1,-1,-1,-1,-1)";
                //run query
                this.Insert(query);

                //lastly close connection
                //close Connection
                this.CloseConnection();
            }

        



        }

        public bool unit_exists (string unit_code)
        {
            string query = "SELECT unit_code FROM SARMS_unit WHERE unit_code = '"+unit_code+"';";

            //used to store reply
            string unit = "none";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    unit = dataReader.GetString("unit_code");
                }


                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                if (unit == unit_code)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            //return 0
            else
            {
                return false;
            }

            

        }

        //retuns 0 if student is not in unit
        public int student_in_unit (string unit, int student_id)
        {
            string query = "SELECT link_id FROM SARMS_linking WHERE unit_code LIKE '" + unit + "' and student_id = "+student_id+";";

            //used to store reply
            int link_id = 0;

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    link_id = dataReader.GetInt32(dataReader.GetOrdinal("link_id"));
                }


                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                return link_id;
                
            }
            //return 0
            else
            {
                return link_id;
            }
        }

        //returns the number of classes a student has attended
        public int get_class_attendance(int class_id)
        {
            

            //used to store reply
            int total_attended = 0;
            int temp = 0;
            int loop = 1;

            //open connection
            if (this.OpenConnection() == true)
            {
                while (loop <= 30)
                {
                    string query = "SELECT class"+loop+" FROM SARMS_classes WHERE instance_id= " + class_id + ";";

                    //create command
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        temp = dataReader.GetInt32(dataReader.GetOrdinal("class"+loop));
                    }

                    //if student attended add 1 to attended
                    if (temp == 2)
                    {
                        total_attended = total_attended + 1;
                    }

                    //close Data Reader
                    dataReader.Close();

                    loop = loop + 1;

                   
                }
                //close Connection
                this.CloseConnection();

                return total_attended;
            }
            //return 0
            else
            {
                return total_attended;
            }
        }

        //returns the number of classes that have been run for a unit
        public int get_classes_run(int class_id)
        {


            //used to store reply
            int total_classes = 0;
            int temp = 0;
            int loop = 1;

            //open connection
            if (this.OpenConnection() == true)
            {
                while (loop <= 30)
                {
                    string query = "SELECT class" + loop + " FROM SARMS_classes WHERE instance_id= " + class_id + ";";

                    //create command
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        temp = dataReader.GetInt32(dataReader.GetOrdinal("class" + loop));
                    }

                    //if student attended add 1 to attended
                    if (temp != 0)
                    {
                        total_classes = total_classes + 1;
                    }

                    //close Data Reader
                    dataReader.Close();

                    loop = loop + 1;


                }
                //close Connection
                this.CloseConnection();

                return total_classes;
            }
            //return 0
            else
            {
                return total_classes;
            }
        }

        public int get_total_assesments(int class_id)
        {


            //used to store reply
            int total_assesments = 0;
            int temp = 0;
            int loop = 1;

            //open connection
            if (this.OpenConnection() == true)
            {
                while (loop <= 6)
                {
                    string query = "SELECT assignment" + loop + " FROM SARMS_assignments WHERE instance_id= " + class_id + ";";

                    //create command
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        temp = dataReader.GetInt32(dataReader.GetOrdinal("assignment" + loop));
                    }

                    //if assignment exists for unit add 1
                    if (temp != -1)
                    {
                        total_assesments = total_assesments + 1;
                    }

                    //close Data Reader
                    dataReader.Close();

                    loop = loop + 1;


                }
                //close Connection
                this.CloseConnection();

                return total_assesments;
            }
            //return 0
            else
            {
                return total_assesments;
            }
        }

        public int get_assesment_results(int class_id)
        {


            //used to store reply
            int assesments = 0;
            int temp = 0;
            int loop = 1;

            //open connection
            if (this.OpenConnection() == true)
            {
                while (loop <= 6)
                {
                    string query = "SELECT assignment" + loop + " FROM SARMS_assignments WHERE instance_id= " + class_id + ";";

                    //create command
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        temp = dataReader.GetInt32(dataReader.GetOrdinal("assignment" + loop));
                    }

                    //if assignment exists for unit add 1
                    if (temp != -1)
                    {
                        assesments = assesments + temp;
                    }

                    //close Data Reader
                    dataReader.Close();

                    loop = loop + 1;


                }
                //close Connection
                this.CloseConnection();

                return assesments;
            }
            //return 0
            else
            {
                return assesments;
            }
        }

        //

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
