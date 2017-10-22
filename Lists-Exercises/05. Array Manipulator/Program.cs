using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> initialList = Console
                .ReadLine()
                .Split( new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string[] commandLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            while (commandLine[0] != "print")
            {
                switch (commandLine[0])
                {
                    case "add":
                        initialList.Insert(int.Parse(commandLine[1]), int.Parse(commandLine[2]));
                        break;
                    case "addMany":
                        var index = int.Parse(commandLine[1]);
                        var numbersToAdd = commandLine.Skip(2).Select(int.Parse).ToList();
                        initialList.InsertRange(index, numbersToAdd);
                        break;
                    case "contains":
                        if (initialList.Contains(int.Parse(commandLine[1])))
                        {
                            Console.WriteLine(initialList.IndexOf(int.Parse(commandLine[1])));
                        }
                        else
                        {
                            Console.WriteLine("-1");
                        }
                        break;
                    case "remove":
                        initialList.RemoveAt(int.Parse(commandLine[1]));
                        break;
                    case "shift":
                        int number = int.Parse(commandLine[1]);
                        var rem = initialList.Take(number).ToList();
                        initialList.RemoveRange(0, number);
                        initialList.AddRange(rem);
                        break;
                    case "sumPairs":
                        List<int> tempList = new List<int>();
                        int last = initialList.Count;
                        if (last % 2 == 1)
                        {
                            for (int i = 0; i < last-1; i += 2)
                            {
                                tempList.Add(initialList[0 + i] + initialList[1 + i]);
                                tempList.Add(initialList[initialList.Count - 1]);
                                    }
                        }
                        else
                        {
                            for (int i = 0; i < last; i += 2)
                            {
                                tempList.Add(initialList[0 + i] + initialList[1 + i]);
                            }
                        }
                        initialList = tempList;
                        break;
                    default:
                        break;
                }
                commandLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine("[{0}]", string.Join(", ", initialList));
        }
    }
}
