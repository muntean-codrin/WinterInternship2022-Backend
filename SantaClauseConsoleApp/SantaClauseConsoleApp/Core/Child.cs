using System;
using System.Linq;

namespace SantaClauseConsoleApp
{
    public class Child
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Address Address { get; set; }
        public Letter Letter { get; set; }
        public BehaviorEnum Behavior { get; set; }

        public Child()
        {
            Id = Guid.NewGuid();
            Address = new Address("");
            Letter = new Letter();
        }

        public Child(string Name, DateTime DateOfBirth, Address Address, Letter Letter, BehaviorEnum Behavior)
        {
            Id = Guid.NewGuid();
            this.Name = Name;
            this.DateOfBirth = DateOfBirth;
            this.Address = Address;
            this.Letter = Letter;
            this.Behavior = Behavior;

        }

        public override string ToString()
        {
            return $"{Name} from {Address.City} was born in {DateOfBirth.ToString("yyyy")}. They were a very {BehaviorToString()} child this year. " +
                $"\n{Name} wants {Letter.Items.Count} presents this Christmas: {Letter}.\n";
        }
        private string BehaviorToString()
        {
            return (Behavior == BehaviorEnum.Good ? "good" : "bad");
        }

    }
}
