using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SantaClauseConsoleApp.HelperClasses
{
    public class LetterWriter
    {
        public LetterWriter()
        {

        }

        public void WriteLetter(Child child, string filePath)
        {
            string[] letterParagraphs = new string[5];

            letterParagraphs[0] = "Dear Santa,";
            letterParagraphs[1] = $"I am {child.Name}";
            letterParagraphs[2] = $"I am {CalculateAge(child.DateOfBirth)} years old. I live at " +
                $"{AddressToString(child.Address)}. I have been a very {BehaviorToString(child.Behavior)} child this year";
            letterParagraphs[3] = "What I would like the most this Christmas is:";
            letterParagraphs[4] = string.Join(',', child.Letter.Items.Select(i => i.Name));

            File.WriteAllLines(filePath, letterParagraphs);

        }

        private string AddressToString(Address address)
        {
            return $"{address.Details}, {address.City}";
        }

        private int CalculateAge(DateTime dateOfBirth)
        {
            int age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }

        private string BehaviorToString(BehaviorEnum behavior)
        {
            return behavior == BehaviorEnum.Good ? "good" : "bad";
        }
    }
}
