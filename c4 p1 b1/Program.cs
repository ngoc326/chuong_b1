using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace c4_p1_b1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmTinhTong());
        }
    }
}
