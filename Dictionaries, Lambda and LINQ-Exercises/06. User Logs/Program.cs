using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedDictionary<string,int>> mails = new SortedDictionary<string, SortedDictionary<string, int>>();
            bool canContinue = true;

            while (canContinue)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    canContinue = false;
                    break;
                }
                //  char[] delimiterChars = { '=', '\'' };
                //  string[] parsedInput = input.Split(delimiterChars);
                //  string[] temp = parsedInput[1].Split();
                //  string IP = temp[0];
                //    string user = parsedInput[5];
                List<string> lineData = input.Split(' ').ToList();
                string user = lineData[2].Substring(5);
                string IP = lineData[0].Substring(3);

                if (!mails.ContainsKey(user))
                {
                    mails.Add(user, new SortedDictionary<string, int>());
                }
                if (!mails[user].ContainsKey(IP))
                {
                    mails[user].Add(IP, 1);
                }
                else
                {
                    mails[user][IP] +=1;
                }

            }
            foreach (var user in mails)
            {
                Console.WriteLine($"{user.Key}:");
                foreach (var IP in user.Value)
                {
                    var thing = IP.Key;
                    if (IP.Key != user.Value.Keys.Last()) Console.Write($"{IP.Key} => {IP.Value}, ");
                    else Console.WriteLine($"{IP.Key} => {IP.Value}.");
                }
            }


        }
    }
}
