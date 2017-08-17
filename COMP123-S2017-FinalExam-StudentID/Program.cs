using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name:Alessandro da Silva Santos
 * Date:2017/08/17
 * StudentID:300927354
 * Description: Creating a program splash form
 * Version:01. creating a program splash form
 */

namespace COMP123_S2017_FinalExam_StudentID
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PickHighestCardForm = new PickHighestCardForm();
            Application.Run(new SplashForm());

        }
    }
}
