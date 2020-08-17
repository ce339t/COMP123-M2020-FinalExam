using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;

/*COMP123-M2020-Final Exam
 * Author: Christina May Pakingan
 * Student No.: 301121940
 * Date Created: August 17, 2020
 * Last Updated: August 17 - 6:20pm
 */
namespace COMP123_M2020_FinalExam
{
    public class Character
    {
        public string Strength { get; set; }

        public string Dexterity { get; set; }

        public string Constitution { get; set; }

        public string Intelligence { get; set; }

        public string Wisdom { get; set; }

        public string Charisma { get; set; }

        public string Race { get; set; }

        //add firstname and lastname field to character class
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}