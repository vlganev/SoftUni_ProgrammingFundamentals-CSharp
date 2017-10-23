using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());

            findTheNearestPoint(X1, Y1, X2, Y2);
        }

        private static void findTheNearestPoint(double X1, double Y1, double X2, double Y2)
        {
            double diagonal1 = Math.Sqrt(Math.Abs(X1) * Math.Abs(X1) + Math.Abs(Y1) * Math.Abs(Y1));
            double diagonal2 = Math.Sqrt(Math.Abs(X2) * Math.Abs(X2) + Math.Abs(Y2) * Math.Abs(Y2));
            if (diagonal1 < diagonal2)
            {
                Console.WriteLine($"({X1}, {Y1})");
            }
            else
            {
                Console.WriteLine($"({X2}, {Y2})");
            }
        }
    }
}
