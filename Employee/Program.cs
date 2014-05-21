using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Mappings;
using NHibernate;

namespace Employee
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
            ISessionFactory session = SessionFactory.CreateSessionFactory(); //NOT SURE. Ask McFall 
            Application.Run(new LoginForm());

            
        }
    }
}
