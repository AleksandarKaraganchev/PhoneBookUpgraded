using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookUpgraded
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Enter the size of the address book: ");
            int size = int.Parse(Console.ReadLine());
            AddressBook addressBook = new AddressBook(size);
            while (true)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Select an option:");
                Console.WriteLine("(1) [Add entry]");
                Console.WriteLine("(2) [Delete entry]");
                Console.WriteLine("(3) [Insert entry]");
                Console.WriteLine("(4) [Print entries]");
                Console.WriteLine("(5) [Exit]");
                Console.WriteLine("--------------------------------");
                int option = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (option)
                {
                    case 1:
                        Console.Write("Enter name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter address: ");
                        string address = Console.ReadLine();
                        Console.Write("Enter rating: ");
                        int rating = int.Parse(Console.ReadLine());
                        addressBook.AddEntry(name, address, rating);
                        break;
                    case 2:
                        Console.WriteLine("Enter the ID of the entry to delete:");
                        int deleteId = int.Parse(Console.ReadLine());
                        addressBook.DeleteEntry(deleteId);
                        break;
                    case 3:
                        Console.Write("Enter the ID of the entry to insert after: ");
                        int insertId = int.Parse(Console.ReadLine());
                        Console.Write("Enter name: ");
                        string insertName = Console.ReadLine();
                        Console.Write("Enter address: ");
                        string insertAddress = Console.ReadLine();
                        Console.Write("Enter rating: ");
                        int insertRating = int.Parse(Console.ReadLine());
                        addressBook.InsertEntry(insertId, insertName, insertAddress, insertRating);
                        break;
                    case 4:
                        addressBook.PrintAllEntries();
                        break;
                    case 5:
                        return;
                }
                //задачата може да се направи по същият начин със if!!!
                Console.WriteLine();
            }
        }
    }
}
