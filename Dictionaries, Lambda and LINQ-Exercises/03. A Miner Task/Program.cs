using System;
using System.Collections.Generic;
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

            bool canContinue = true;
            int count = 0;
            string addKey = "";
            while (canContinue)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    foreach (var item in miner)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                    canContinue = false;
                    break;
                }
                if (count%2 == 0)
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
        }
    }
}
