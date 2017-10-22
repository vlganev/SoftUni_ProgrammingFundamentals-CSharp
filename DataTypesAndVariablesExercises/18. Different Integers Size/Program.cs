using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            bool canFit = false;
            string numStr = Console.ReadLine();
            string message = "";

            try
            {
                sbyte sbyteNum = sbyte.Parse(numStr);
                message += "* sbyte\n";
                canFit = true;
            }
            catch (Exception)
            {
            }

            try
            {
                byte byteNum = byte.Parse(numStr);
                message += "* byte\n";
                canFit = true;
            }
            catch (Exception)
            {
            }

            try
            {
                short shortNum = short.Parse(numStr);
                message += "* short\n";
                canFit = true;
            }
            catch (Exception)
            {
            }

            try
            {
                ushort ushortNum = ushort.Parse(numStr);
                message += "* ushort\n";
                canFit = true;
            }
            catch (Exception)
            {
            }

            try
            {
                int intNum = int.Parse(numStr);
                message += "* int\n";
                canFit = true;
            }
            catch (Exception)
            {
            }

            try
            {
                uint uintNum = uint.Parse(numStr);
                message += "* uint\n";
                canFit = true;
            }
            catch (Exception)
            {
            }

            try
            {
                long longNum = long.Parse(numStr);
                message += "* long\n";
                canFit = true;
            }
            catch (Exception)
            {
            }

            if (canFit)
            {
                Console.WriteLine("{0} can fit in:", numStr);
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("{0} can't fit in any type", numStr);
            }
        }
    }
}
