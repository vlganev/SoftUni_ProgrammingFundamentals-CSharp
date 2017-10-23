using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = Math.Abs(decimal.Parse(Console.ReadLine()));
            decimal lastDigit = a % 10;
            string text = DigitToText(lastDigit);
            Console.WriteLine(text);
        }
        static string DigitToText (decimal digit)
        {
            string textDigit = string.Empty;
            switch (digit)
            {
                case 1:
                    textDigit = "one";
                    break;
                case 2:
                    textDigit = "two";
                    break;
                case 3:
                    textDigit = "three";
                    break;
                case 4:
                    textDigit = "four";
                    break;
                case 5:
                    textDigit = "five";
                    break;
                case 6:
                    textDigit = "six";
                    break;
                case 7:
                    textDigit = "seven";
                    break;
                case 8:
                    textDigit = "eight";
                    break;
                case 9:
                    textDigit = "nine";
                    break;
                case 0:
                    textDigit = "zero";
                    break;
                default:
                    break;
            }
            return textDigit;
        }
    }
}
