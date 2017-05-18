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
            About aboutform = new About();
            aboutform.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dbcon = new DBConnect();
            int id = 0;
            
          if (int.TryParse(textBox1.Text, out id))
            {
               label1.Text = dbcon.Select_user_fname(id);
            }
            else
            {
                MessageBox.Show("invalid id", "unsuccessful", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }    
            
        }
    }
}
