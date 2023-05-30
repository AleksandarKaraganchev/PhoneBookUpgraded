using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookUpgraded
{
    internal class AddressBook
    {
        private AddressEntry[] entries;
        public AddressBook(int size)
        {
            entries = new AddressEntry[size];
        }
        public void AddEntry(string name, string address, int rating)
        {
            for (int i = 0; i < entries.Length; i++)
            {
                if (entries[i] == null)
                {
                    AddressEntry entry = new AddressEntry(name, address, rating);
                    entries[i] = entry;
                    Console.WriteLine("Entry has been added successfully!");
                    return;
                }
            }
            Console.WriteLine("Address book is full!");
        }
        public void DeleteEntry(int id)
        {
            if (id >= 1 && id <= entries.Length)
            {
                entries[id - 1] = null;
                Console.WriteLine($"Entry with ID [{id}] was deleted successfully!");
            }
            else
            {
                Console.WriteLine($"Entry with ID [{id}] does not exist!");
            }
        }
        public void InsertEntry(int id, string name, string address, int rating)
        {
            if (id >= 1 && id <= entries.Length)
            {
                if (entries[id - 1] == null)
                {
                    AddressEntry entry = new AddressEntry(name, address, rating);
                    entries[id - 1] = entry;
                    Console.WriteLine("Entry inserted successfully!!!");
                }
                else
                {
                    Console.WriteLine($"There is already an entry at ID {id}!!!");
                }
            }
            else
            {
                Console.WriteLine($"Cannot insert entry at ID [{id}]!!!");
            }
        }
        public void PrintAllEntries()
        {
            for (int i = 0; i < entries.Length; i++)
            {
                if (entries[i] != null)
                {
                    Console.WriteLine($"ID: [{i + 1}]");
                    entries[i].Print();
                }
            }
        }
    }
}
