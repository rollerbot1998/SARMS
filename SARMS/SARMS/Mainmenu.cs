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
        public MainMenu_Admin()
        {
            InitializeComponent();
        }

        private void MainMenu_Admin_Load(object sender, EventArgs e)
        {

        }

        private void About_Button_Click(object sender, EventArgs e)
        {
            About aboutform = new About();
            aboutform.Show();

        }
    }
}
