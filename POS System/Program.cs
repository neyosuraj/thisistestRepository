using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SecureApp;


namespace POS_System
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

            string abc = @"Software\pos\PosPrivate";
            Secure scr = new Secure();
            bool logic = scr.Algorithm("DA412-628DS-S1VD2-SITCH", abc);
            if (logic == true)
                Application.Run(new Login());
        }
    }
}
