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
    public partial class FinalForm : Form
    {
        public RaceAndClassForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FinalForm_Load(object sender, EventArgs e)
        {   
            //assign the value of each program.character object to the corresponding
            //textboxes in finalform
            DexterityTextBox.Text = Program.character.Dexterity;
            StrengthTextBox.Text = Program.character.Strength;
            ConstitutionTextBox.Text = Program.character.Constitution;
            IntelligenceTextBox.Text = Program.character.Intelligence;
            CharismaTextBox.Text = Program.character.Charisma;
            WisdomTextBox.Text = Program.character.Wisdom;
            LastNameTextBox.Text = Program.character.LastName;
            FirstNametextBox.Text = Program.character.FirstName;
            RaceTextBox.Text = Program.character.Race;

        }
    }
}
