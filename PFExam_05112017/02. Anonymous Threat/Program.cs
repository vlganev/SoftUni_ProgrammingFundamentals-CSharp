using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousThreat
{
    class Program
    {
        static void Main()
        {
            List<string> initialList = Console
                .ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "3:1")
                {
                    break;
                }
                string[] tokens = input
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                     .ToArray();
                string command = tokens[0];
                switch (command)
                {
                    case "merge":
                        MergeIndexes(tokens, initialList);
                        break;
                    case "divide":
                        DivideIndexs(tokens, initialList);
                        break;
                    default:
                        break;
                }
            }
            for (int i = 0; i < initialList.Count; i++)
            {
                Console.Write(initialList[i] + " ");
            }
            Console.WriteLine();
        }

        private static void DivideIndexs(string[] tokens, List<string> initialList)
        {
            int index = int.Parse(tokens[1]);
            int partitions = int.Parse(tokens[2]);
            if (index < 0 || index > initialList.Count)
            {
                return;
            }
            string dividedIndex = initialList[index];
            int partCount = initialList[index].Length / partitions;
            initialList.RemoveAt(index);
            for (int i = 0; i < partitions; i++)
            {
                int range = 0;
                if (i != 0)
                {
                    range = i * partCount;
                }
                if (i != partitions - 1)
                {
                    string item = new string(dividedIndex.Skip(range).Take(partCount).ToArray());
                    initialList.Insert(index + i, item);
                }
                else
                {
                    string item = new string(dividedIndex.Skip(range).ToArray());
                    initialList.Insert(index + i, item);
                }
            }
        }

        private static void MergeIndexes(string[] tokens, List<string> initialList)
        {
            int startIndex = int.Parse(tokens[1]);
            int endIndex = int.Parse(tokens[2]);
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            if (endIndex >= initialList.Count)
            {
                endIndex = initialList.Count - 1;
            }
            if (startIndex >= initialList.Count || 0 > endIndex)
            {
                return;
            }
            StringBuilder mergedIndex = new StringBuilder();
            for (int i = startIndex; i <= endIndex; i++)
            {
                mergedIndex.Append(initialList[i]);
            }
            initialList[startIndex] = mergedIndex.ToString();
            int count = endIndex - startIndex;

            initialList.RemoveRange(startIndex + 1, count);
        }
    }
}
