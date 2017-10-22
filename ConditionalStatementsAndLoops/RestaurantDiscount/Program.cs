using System;

namespace RestaurantDiscount
{
    class Program
    {
        public static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();

            var hall = "null";
            int priceHall = 0;
            double discount = 0;
            int pricePackage = 0;

            if (groupSize <= 50)
            {
                hall = "Small Hall";
                priceHall = 2500;
            }
            else if (groupSize <= 100)
            {
                hall = "Terrace";
                priceHall = 5000;
            }
            else if (groupSize <= 120)
            {
                hall = "Great Hall";
                priceHall = 7500;
            }

            if (hall != "null")
            {
                switch (package)
                {
                    case "Normal":
                        discount = 0.95;
                        pricePackage = 500;
                        break;
                    case "Gold":
                        discount = 0.90;
                        pricePackage = 750;
                        break;
                    case "Platinum":
                        discount = 0.85;
                        pricePackage = 1000;
                        break;
                    default:
                        break;
                }
                var totalPrice = (priceHall + pricePackage) * discount;
                var pricePerPerson = Math.Round(totalPrice / groupSize, 2);


                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
