using System;

namespace SantaClauseConsoleApp
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Item(string Name)
        {
            Id = Guid.NewGuid();
            this.Name = Name;
        }
    }
}
