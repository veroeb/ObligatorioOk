using Obligatorio.Models;
using Obligatorio.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obligatorio
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
            Application.Run(new LaunchScreen());

            Home home = new Home();
            LaunchScreen Launch = new LaunchScreen();
            NuevaCasa nuevaCasa = new NuevaCasa();
            NuevoApartamento nuevoapto = new NuevoApartamento();


        }
    }
}
