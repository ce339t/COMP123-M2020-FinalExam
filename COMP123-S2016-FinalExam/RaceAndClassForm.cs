﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
    public partial class RaceAndClassForm : Form
    {
        public AbilityGeneratorForm previousForm;
        private string _selectedRace;


        public RaceAndClassForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            character.Race = this._selectedRace;

            // Step 1 - show the parent form
            this.previousForm.Show();

            // Step 2 - close this form
            this.Close();
        }

        private void RaceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRace = (RadioButton)sender;

            this._selectedRace = selectedRace.Text;
            //added code: _selectedRace value is assign to character object Race
            Program.character.Race = this._selectedRace;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            FinalForm finalForm = new FinalForm();
            finalForm.previousForm = this;

            finalForm.Show();
            this.Hide();
        }

        private void RaceAndClassForm_Load(object sender, EventArgs e)
        {

        }
    }
}
