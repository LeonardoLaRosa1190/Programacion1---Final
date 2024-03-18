using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Windows.System;

namespace sys_LeonardoLaRosa
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //abre el formulario principal
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            Application.Run();

        }
    }
}