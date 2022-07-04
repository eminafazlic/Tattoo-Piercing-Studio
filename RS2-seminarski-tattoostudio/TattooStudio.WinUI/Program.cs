using System;
using System.Windows.Forms;
using TattooStudio.WinUI.LoginRegistracija;

namespace TattooStudio.WinUI
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
            Application.Run(new frmHomePage());
        }
    }
}
