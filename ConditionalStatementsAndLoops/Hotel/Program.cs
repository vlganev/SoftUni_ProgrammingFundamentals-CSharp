using System;

namespace Hotel
{
    class Program
    {
        public static void Main()
        {
            var month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            int studioPrice = 0;
            int doublePrice = 0;
            int suitePrice = 0;
            double discountStudio = 1;
            double discountDouble = 1;
            double discountSuite = 1;
            double studio = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                doublePrice = 65;
                suitePrice = 75;
                if (nights > 7)
                {
                    discountStudio = 0.95;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 60;
                doublePrice = 72;
                suitePrice = 82;
                if (nights > 14)
                {
                    discountDouble = 0.9;
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68;
                doublePrice = 77;
                suitePrice = 89;
                if (nights > 14)
                {
                    discountSuite = 0.85;
                }
            }

            if (month == "September" || month == "October" && nights > 7)
            {
                studio = studioPrice * discountStudio * ( nights -1 );
            }
            else
            {
                studio = studioPrice * discountStudio * nights;
            }
            double doub = doublePrice * discountDouble * nights;
            double suite = suitePrice * discountSuite * nights;

            Console.WriteLine($"Studio: {studio:F2} lv.");
            Console.WriteLine($"Double: {doub:F2} lv.");
            Console.WriteLine($"Suite: {suite:F2} lv.");
        }
    }
}
