using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\";
            if (File.Exists(path + "output.txt"))
                File.Delete(path + "output.txt");
            Dictionary<string, string> emailDB = new Dictionary<string, string>();
            using (StreamReader reader = new StreamReader(path + "input.txt", Encoding.GetEncoding("UTF-8")))
            {
                string line = "x";
                while (line != null)
                {
                    string name = reader.ReadLine();
                    string email = "";
                    if (name == "stop")
                    {
                        break;
                    }
                    else
                    {
                        email = reader.ReadLine();
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
                        using (StreamWriter writer = new StreamWriter(path + "output.txt", append: true))
                        {
                            writer.WriteLine($"{name} -> {email}");
                        }
                    }
                }
            }
        }
    }
}
