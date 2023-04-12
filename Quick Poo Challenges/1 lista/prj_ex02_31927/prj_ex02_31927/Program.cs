using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace prj_ex02_31927
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
            Application.Run(new frm_ex01_31927());
        }
    }
}
