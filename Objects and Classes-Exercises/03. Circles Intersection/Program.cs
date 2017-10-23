using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclesIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] circle1 = Console
                .ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] circle2 = Console
                .ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Circle circleA = new Circle { Center = new Point { X = circle1[0], Y = circle1[1] }, Radius = circle1[2] };
            Circle circleB = new Circle { Center = new Point { X = circle2[0], Y = circle2[1] } , Radius = circle2[2] };

            int deltaX = circleA.Center.X - circleB.Center.X;
            int detlaY = circleA.Center.Y - circleB.Center.Y;

            double distance = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(detlaY, 2));

            if (distance <= (circleA.Radius+circleB.Radius))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }

    class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
