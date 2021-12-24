using System;
using System.Collections.Generic;
using System.IO;

namespace SantaClauseConsoleApp.HelperClasses
{
    public class LetterReader
    {
        public LetterReader()
        {

        }

        public Child ReadLetter(string filename)
        {
            Letter letter = new Letter();
            Child child = new Child();

            var letterContent = File.ReadAllLines(filename);

            letter.WrittenAt = File.GetLastWriteTime(filename);
            letter.Items = GetItems(letterContent[4]);

            child.Name = letterContent[1].Substring(5);
            child.DateOfBirth = GetBirthDate(letterContent[2]);
            child.Address = GetAdress(letterContent[2]);
            child.Behavior = GetBehavior(letterContent[2]);

            child.Letter = letter;
            return child;
        }

        private BehaviorEnum GetBehavior(string letterParagraph)
        {
            int behaviorStartIndex = letterParagraph.IndexOf("a very") + 7;
            if(char.ToLower(letterParagraph[behaviorStartIndex]) == 'b')
            {
                return BehaviorEnum.Bad;
            }
            return BehaviorEnum.Good;
        }

        private Address GetAdress(string letterParagraph)
        {
            int addressStartIndex = letterParagraph.IndexOf("at") + 3;
            int addressEndIndex = letterParagraph.IndexOf("I have") - 3;
            int addressLength = addressEndIndex - addressStartIndex + 1;
            string addressString = letterParagraph.Substring(addressStartIndex, addressLength);
            return new Address(addressString);
        }

        private List<Item> GetItems(string letterParagraph)
        {
            var items = new List<Item>();
            var itemsString = letterParagraph.Split(',');
            foreach (var itemString in itemsString)
            {
                items.Add(new Item(itemString.Trim()));
            }

            return items;
        }

        private DateTime GetBirthDate(string letterParagraph)
        {
            int ageStartIndex = 5, ageEndIndex = 0;
            for(int i = ageStartIndex; i < letterParagraph.Length; i++)
            {
                if(letterParagraph[i] == ' ')
                {
                    ageEndIndex = i;
                    break;
                }
            }

            int ageLength = ageEndIndex - ageStartIndex + 1;
            string age = letterParagraph.Substring(ageStartIndex, ageLength);
            int ageInteger = int.Parse(age);

            
            int currentYear = DateTime.Now.Year;
            int birthYear = currentYear - ageInteger;
            DateTime birthDate = new DateTime(birthYear, 1, 1);

            return birthDate;
        }
    }
}
