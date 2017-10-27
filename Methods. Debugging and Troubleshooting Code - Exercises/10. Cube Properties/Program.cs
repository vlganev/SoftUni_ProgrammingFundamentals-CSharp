using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double aCube = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            double result = 0;
            switch (type)
            {
                case "face":
                    result = printFace(aCube);
                    break;
                case "space":
                    result = printSpace(aCube);
                    break;
                case "volume":
                    result = printVolume(aCube);
                    break;
                case "area":
                    result = printArea(aCube);
                    break;
                default:
                    break;
            }
            Console.WriteLine("{0:f2}", result);
        }

        private static double printArea(double aCube)
        {
            double area = Math.Pow(aCube,2) * 6;
            return area;
        }

        private static double printVolume(double aCube)
        {
            double volume = Math.Pow(aCube, 3);
            return volume;
        }

        private static double printSpace(double aCube)
        {
            double space = Math.Sqrt(3 * Math.Pow(aCube, 2));
            return space;
        }

        private static double printFace(double aCube)
        {
            double face = Math.Sqrt(2 * Math.Pow(aCube, 2));
            return face;
        }
    }
}
