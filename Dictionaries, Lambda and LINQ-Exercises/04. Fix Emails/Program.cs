using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emailDB = new Dictionary<string, string>();
            bool canContinue = true;
            while (canContinue)
            {
                string name = Console.ReadLine();
                string email = "";
                if (name.ToLower() == "stop")
                {
                    canContinue = false;
                    break;
                }
                else
                {
                    email = Console.ReadLine();
                }

                if (email.EndsWith("us") || email.EndsWith("uk"))
                {
                    break;
                }

                if (emailDB.ContainsKey(name))
                {
                    emailDB[name] = email;
                }
                else
                {
                    emailDB.Add(name, email);
                    Console.WriteLine($"{name} -> {email}");
                }
            }
        }
    }
}
