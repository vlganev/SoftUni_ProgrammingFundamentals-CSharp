using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            bool canContinue = true;
            while (canContinue)
            {
                string[] commandLine = Console.ReadLine().Split();
                string command = commandLine[0];
                switch (command)
                {
                    case "A":
                        string member = commandLine[1];
                        string number = commandLine[2];
                        phonebook[member] = number;
                        break;
                    case "S":
                        string memberSearch = commandLine[1];
                        string numberSearch = "";
                        if (phonebook.TryGetValue(memberSearch, out numberSearch))
                        {
                            Console.WriteLine($"{memberSearch} -> {numberSearch}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {memberSearch} does not exist.");
                        }
                        break;
                    case "ListAll":
                        foreach (var contact in phonebook)
                        {
                            Console.WriteLine($"{contact.Key} -> {contact.Value}");
                        }
                        break;
                    case "END":
                        canContinue = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
