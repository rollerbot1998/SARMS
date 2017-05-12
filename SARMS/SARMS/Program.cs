using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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

}
