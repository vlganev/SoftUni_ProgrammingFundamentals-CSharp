using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string firstArg = input[0];
            string secondArg = input[1];
            Console.WriteLine(IsMagicalNumber(firstArg, secondArg).ToString().ToLower());
        }

        private static bool IsMagicalNumber(string firstArg, string secondArg)
        {
            string ls = firstArg.Length > secondArg.Length ? firstArg : secondArg;
            string ss = firstArg.Length < secondArg.Length ? firstArg : secondArg;
            Dictionary<char, char> charList = new Dictionary<char, char>();
            if (firstArg.Length != secondArg.Length)
            {
                for (int i = 0; i < Math.Max(firstArg.Length, secondArg.Length); i++)
                {
                    if (i >= Math.Min(firstArg.Length, secondArg.Length))
                    {
                        char char1 = ls[i];
                        if (!charList.ContainsKey(char1))
                        {
                            return false;
                        }
                    }
                    else
                    {
                        char char1 = ls[i];
                        char char2 = ss[i];
                        if (!charList.ContainsKey(char1))
                        {
                            charList.Add(char1, char2);
                        }
                        else
                        {
                            if (charList[char1] != char2)
                            {
                                return false;
                            }
                        }
                    }
                }
                return true;
            }
            else
            {
                for (int i = 0; i < Math.Max(firstArg.Length, secondArg.Length); i++)
                {
                    if (!charList.ContainsKey(firstArg[i]))
                    {
                        charList.Add(firstArg[i], secondArg[i]);
                    }
                    else
                    {
                        if (charList[firstArg[i]] != secondArg[i])
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
