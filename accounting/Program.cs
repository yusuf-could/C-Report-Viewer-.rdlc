﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace accounting
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static Boolean dasbord { get; set; }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new view.Home());
            Application.Run(new view.Login());

            if (dasbord)
            {
                Application.Run(new view.Home());
            }

        }
    }
}
