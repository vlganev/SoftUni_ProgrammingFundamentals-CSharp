using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] array2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int countlr = 0;
            int countrl = 0;

            for (int i = 0; i < Math.Min(array1.Length, array2.Length); i++)
            {
                if (array1[i] == array2[i])
                {
                    countlr++;
                }
                if (array1[array1.Length - 1 - i] == array2[array2.Length - 1 - i])
                {
                    countrl++;
                }
            }


            if (countlr > 0)
            {
                Console.WriteLine(countlr);
            }
            else if (countrl > 0)
            {
                Console.WriteLine(countrl);
            }
            else
            {
                Console.WriteLine("0");
            }

        }
    }
}
