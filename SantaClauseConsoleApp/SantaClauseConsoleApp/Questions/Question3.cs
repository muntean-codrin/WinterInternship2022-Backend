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
        public static void Question3()
        {
            Console.WriteLine("======== QUESTION 3 =========\n\n");

            var children = GenerateChildrenList();
            LetterWriter writer = new LetterWriter();
            foreach (var child in children)
            {
                string fileName = $"letter_{child.Name.Replace(' ', '_')}.txt";
                writer.WriteLetter(child, fileName);
                Console.WriteLine($"Wrote the file: {fileName}");
            }

            Console.WriteLine("\n\n======== END OF QUESTION 3 ========\n\n");
        }
    }
}
