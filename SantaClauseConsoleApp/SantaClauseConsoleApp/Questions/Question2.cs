using SantaClauseConsoleApp.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaClauseConsoleApp
{
    public static partial class Questions
    {
        public static void Question2()
        {
            Console.WriteLine("======== QUESTION 2 =========\n\n");

            string[] letters = { "letter1.txt", "letter2.txt", "letter3.txt" };
            var children = GetChildrenListFromLetters(letters);
            foreach(var child in children)
            {
                Console.WriteLine(child);
            }

            Console.WriteLine("======== END OF QUESTION 2 ========\n\n");

        }

        public static List<Child> GetChildrenListFromLetters(string[] letters)
        {
            var children = new List<Child>();
            LetterReader reader = new LetterReader();
            foreach (var letterFileName in letters)
            {
                children.Add(reader.ReadLetter(letterFileName));
            }

            return children;
        }
    }
}
