using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Test
{
    static class Program
    {
        /// <summary>
        /// The application's main window. 
        /// </summary>
        public static Form MainForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm = new FormMain();
            Application.Run(MainForm);
        }
    }
}
