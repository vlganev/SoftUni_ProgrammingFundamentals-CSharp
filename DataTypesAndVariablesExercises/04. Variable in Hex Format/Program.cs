using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableInHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexadecimalFormat = Console.ReadLine();
            int integer = Convert.ToInt32(hexadecimalFormat, 16);
            Console.WriteLine(integer);
        }
    }
}
