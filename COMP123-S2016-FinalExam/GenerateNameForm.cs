using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    public partial class GenerateNameForm : Form
    {
        public GenerateNameForm()
        {
            InitializeComponent();
        }

        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            GenerateNames();
        }

        //created method to generate random firstname and lastname
        private void GenerateNames()
        {
            //generate random item in the firstname Listbox 
            var random = new Random();
            int index = random.Next(0, FirstNameListBox.Items.Count);

            //display the generated firstname to textbox
            FirstNametextBox.Text = FirstNameListBox.Items[index].ToString();

            //generate random item in the firstname Listbox and display in lastname textbox
            int index2 = random.Next(0, LastNameListBox.Items.Count);
            LastNameTextBox.Text = LastNameListBox.Items[index2].ToString();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
            //assign the random generated lastname and firstname to a character object
            Program.character.LastName = LastNameTextBox.Text;
            Program.character.FirstName = FirstNametextBox.Text;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            // show the ability generator form
            new AbilityGeneratorForm().Show();
            //hide the current form
            this.Hide();
        }

       
    }
}
