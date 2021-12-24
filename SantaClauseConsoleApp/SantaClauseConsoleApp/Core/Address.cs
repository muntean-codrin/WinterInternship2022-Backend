using System;
using System.Linq;
using System.Collections.Generic;


namespace SantaClauseConsoleApp
{
    public class Address
    {
        public string City { get; set; }
        public string Details { get; set; }

        public Address(string address)
        {
            // we assume the address is divided into parts with comma as a separator
            // we also assume that the city is the last part of the adress e.g. Strada Somesului, Nr 13, Sibiu
            var addressParts = address.Split(',').Select(a => a.Trim()).ToList();

            int cityIndex = addressParts.Count - 1;
            this.City = addressParts[cityIndex];
            addressParts.RemoveAt(cityIndex);

            this.Details = string.Join(" ", addressParts);

        }
    }
}
