using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookUpgraded
{
    internal class AddressEntry
    {
        private string name;
        private string address;
        private string phoneNumber;
        private int rating;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public AddressEntry(string name, string address, int rating)
        {
            this.Name = name;
            this.Address = address;
            this.Rating = rating;
            Random random = new Random();
            this.PhoneNumber = "0" + random.Next(860000000, 900000000).ToString();
        }
        public void Print()
        {
            Console.WriteLine($"Name: [{this.Name}]");
            Console.WriteLine($"Address: [{this.Address}]");
            Console.WriteLine($"Phone Number: [{this.PhoneNumber}]");
            Console.WriteLine($"Rating: [{this.Rating}]");
            Console.WriteLine();
        }
    }
}
