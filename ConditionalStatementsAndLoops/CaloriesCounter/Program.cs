using System;


namespace CaloriesCounter
{
    class Program
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            int calories = 0;
            for (int i = 0; i < lines; i++)
            {
                var ingredient = Console.ReadLine();
                ingredient = ingredient.ToLower();
                switch (ingredient)
                {
                    case "cheese":
                        calories += 500;
                        break;
                    case "tomato sauce":
                        calories += 150;
                        break;
                    case "salami":
                        calories += 600;
                        break;
                    case "pepper":
                        calories += 50;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
