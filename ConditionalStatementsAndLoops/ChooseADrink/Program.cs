using System;

namespace ChooseADrink
{
    class Program
    {
        public static void Main()
        {
            var profession = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
           // var drink = "null";
            double price;

            switch (profession)
            {
                case "Athlete":
                 //   drink = "Water";
                    price = 0.70;
                    break;
                case "Businessman":
                case "Businesswoman":
                  //  drink = "Coffee";
                    price = 1.00;
                    break;
                case "SoftUni Student":
                  //  drink = "Beer";
                    price = 1.70;
                    break;
                default:
                   // drink = "Tea";
                    price = 1.20;
                    break;
            }
            double totalPrice = price * count;
            Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
        }
    }
}
