using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Reach the set interval, splash form will close
            this.Hide();
            // show to next form
            new GenerateNameForm().Show();
           // disable the timer
            timer1.Enabled = false;
        }
    }
}
