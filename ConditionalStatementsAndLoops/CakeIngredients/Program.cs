using System;


namespace CakeIngredients
{
    class Program
    {
        public static void Main()
        {
            for (int i = 0; i <= 20; i++)
            {
                var ingredient = Console.ReadLine();
                if (ingredient == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {i} ingredients.");
                    break;
                }
                Console.WriteLine($"Adding ingredient {ingredient}.");
                }
        }
    }
}
