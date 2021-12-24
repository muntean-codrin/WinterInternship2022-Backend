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
        public static void Question4()
        {
            Console.WriteLine("======== QUESTION 4 =========\n\n");
            Console.WriteLine("Toy Factory Report:\n");
            string[] letters = { "letter1.txt", "letter2.txt", "letter3.txt" };
            var children = GetChildrenListFromLetters(letters);

            var toys = children.SelectMany(c => c.Letter.Items).GroupBy(i => i.Name)
                .Select(g => new { name = g.Key, count = g.Count() }).OrderByDescending(t => t.count);
            
            foreach (var toy in toys)
            {
                Console.WriteLine($"{toy.name} - {toy.count}");
            }

            Console.WriteLine("\n\n======== END OF QUESTION 4 ========\n\n");
        }
    }
}
