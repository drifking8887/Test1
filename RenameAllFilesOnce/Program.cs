using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RenameAllFilesOnce
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
            MessageBox.Show("I LOVE U");
            Application.Run(new Main());
        }
    }
}