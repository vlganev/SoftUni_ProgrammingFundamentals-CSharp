using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> miner = new Dictionary<string, decimal>();

            string[] lines = File.ReadAllLines(@"..\..\input.txt");
            string output = string.Empty;

            string addKey = "";
            int count = 0;
            foreach (var line in lines)
            {
                string input = line;
                if (input == "stop")
                {
                    foreach (var item in miner)
                    {
                        output += ($"{item.Key} -> {item.Value}" + Environment.NewLine);
                    }
                    break;
                }
                if (count % 2 == 0)
                {
                    if (!miner.ContainsKey(input))
                    {
                        miner[input] = 0;
                        addKey = input;
                    }
                    else
                    {
                        addKey = input;
                    }
                }
                else
                {
                    decimal inputDec = decimal.Parse(input);
                    miner[addKey] += inputDec;
                }
                count++;
            }
            output += "END" + Environment.NewLine + Environment.NewLine;
            File.AppendAllText(@"..\..\output.txt", output);
        }
    }
}
