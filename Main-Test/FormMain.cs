using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Main;

namespace Main_Test
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public App MainApp = new App("Main Tester", new Main.Version(0, 0, 0, 1, VersionType.Beta));

        private void FormMain_Load(object sender, EventArgs e)
        {
            MainApp.ConfigureWindow(ref Program.MainForm);
        }
    }
}
