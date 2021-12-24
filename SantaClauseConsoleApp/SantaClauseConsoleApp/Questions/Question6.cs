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
        public static void Question6()
        {
            Console.WriteLine("======== QUESTION 6 =========\n");

            string[] letters = { "letter1.txt", "letter2.txt", "letter3.txt" };
            var children = GetChildrenListFromLetters(letters);

            var addressesGroupedByCity = children.Select(c => c.Address).GroupBy(a => a.City);

            foreach(var city in addressesGroupedByCity)
            {
                Console.WriteLine($"\n{city.Key}:");
                foreach(var address in city)
                {
                    Console.WriteLine($"-{address.Details}");
                }
            }

            Console.WriteLine("\n\n======== END OF QUESTION 6 ========\n\n");
        }
    }
}
