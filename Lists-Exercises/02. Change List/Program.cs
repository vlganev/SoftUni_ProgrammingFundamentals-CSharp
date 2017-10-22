using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> initialNumbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string[] commandLine = Console.ReadLine().Split(' ');
            
            while (commandLine[0].ToLower() != "odd" && commandLine[0].ToLower() != "even")
            {
                switch (commandLine[0].ToLower())
                {
                    case "delete":
                        initialNumbers.RemoveAll(i => i == int.Parse(commandLine[1]));
                        break;
                    case "insert":
                        initialNumbers.Insert(int.Parse(commandLine[2]), int.Parse(commandLine[1]));
                        break;
                    default:
                        break;
                }
                commandLine = Console.ReadLine().Split(' ');
            }
            if (commandLine[0].ToLower() == "odd")
            {
                for (int i = 0; i < initialNumbers.Count; i++)
                {
                    if (initialNumbers[i] % 2 == 1)
                    {
                        Console.Write($"{initialNumbers[i]} ");
                    }
                }
            }
            else
            {
                for (int i = 0; i < initialNumbers.Count; i++)
                {
                    if (initialNumbers[i] % 2 == 0)
                    {
                        Console.Write($"{initialNumbers[i]} ");
                    }
                }
            }
        }
    }
}
