﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using QLGV.Forms;

namespace QLGV
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //try
            //{
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new SysMain());
            //}
            //catch (Exception ex)
            //{
            //    GUIController.ShowErrorBox(ex);
            //}
        }
    }
}
