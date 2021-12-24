using System;
using System.Collections.Generic;
using System.Linq;

namespace SantaClauseConsoleApp
{
    public class Letter
    {
        public DateTime WrittenAt { get; set; }
        public List<Item> Items { get; set; }

        public Letter()
        {
            this.Items = new List<Item>();
        }

        public Letter(DateTime WrittenAt, List<Item> Items)
        {
            this.WrittenAt = WrittenAt;
            this.Items = Items;
        }

        public override string ToString()
        {
            return string.Join(", ", Items.Select(s => s.Name));
        }


    }
}
