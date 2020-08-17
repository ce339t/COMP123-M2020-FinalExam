using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*COMP123-M2020-Final Exam
 * Author: Christina May Pakingan
 * Student No.: 301121940
 * Date Created: August 17, 2020
 * Last Updated: August 17 - 6:20pm
 */
namespace COMP123_M2020_FinalExam
{
    public static class Program
    {
        public static Character character = new Character();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());
            //Application.Run(new AbilityGeneratorForm());
        }
    }
}
