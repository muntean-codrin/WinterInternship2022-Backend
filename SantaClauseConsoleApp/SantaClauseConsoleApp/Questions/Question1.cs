using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaClauseConsoleApp
{
    public static partial class Questions
    {
        public static void Question1()
        {
            Console.WriteLine("======== QUESTION 1 =========\n\n");

            var children = GenerateChildrenList();

            foreach (var child in children)
            {
                Console.WriteLine(child);
            }

            Console.WriteLine("======== END OF QUESTION 1 ========\n\n");
        }
        public static List<Child> GenerateChildrenList()
        {
            List<Child> children = new List<Child>();
            children.Add(new Child
            {
                Name = "Timmy Thompson",
                DateOfBirth = new DateTime(2010, 5, 8),
                Address = new Address("Strada Somesului, Nr. 13, Bucuresti"),
                Letter = new Letter
                {
                    WrittenAt = new DateTime(2021, 12, 23),
                    Items = new List<Item>
                    {
                        new Item("Harry Potter and the Philosopher's Stone"),
                        new Item("Acoustic Guitar")
                    }
                },
                Behavior = BehaviorEnum.Bad
            });

            children.Add(new Child
            {
                Name = "Olivia Vertigo",
                DateOfBirth = new DateTime(2007, 3, 12),
                Address = new Address("Strada Teilor, Nr. 25, Bloc 2, Ap. 32, Brasov"),
                Letter = new Letter
                {
                    WrittenAt = new DateTime(2021, 12, 15),
                    Items = new List<Item>
                    {
                        new Item("School bag"),
                        new Item("Teddy Bear")
                    }
                },
                Behavior = BehaviorEnum.Good
            });

            children.Add(new Child
            {
                Name = "Peter Parker",
                DateOfBirth = new DateTime(2011, 11, 15),
                Address = new Address("Strada Republicii, Nr. 3, Bucuresti"),
                Letter = new Letter
                {
                    WrittenAt = new DateTime(2021, 12, 15),
                    Items = new List<Item>
                    {
                        new Item("Teddy Bear"),
                        new Item("Christmas mug")
                    }
                },
                Behavior = BehaviorEnum.Good
            });

            return children;
        }
        
    }
}
