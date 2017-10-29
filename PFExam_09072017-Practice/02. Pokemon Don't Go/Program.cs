using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listPokemons = Console
                .ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            long sum = 0;
            while (true)
            {
                int value = 0;
                bool remove = true;
                if (listPokemons.Count == 0)
                {
                    break;
                }
                int index = int.Parse(Console.ReadLine());
                if (index < 0)
                {
                    index = 0;
                    value = listPokemons[0];
                    listPokemons[0] = listPokemons[listPokemons.Count - 1];
                    remove = false;
                }
                else if (index >= listPokemons.Count)
                {
                    index = listPokemons.Count - 1;
                    value = listPokemons[listPokemons.Count - 1];
                    listPokemons[listPokemons.Count - 1] = listPokemons[0];
                    remove = false;
                }
                
                if (remove)
                {
                    value = listPokemons[index];
                    listPokemons.RemoveAt(index);

                }
                sum += value;
                for (int i = 0; i < listPokemons.Count; i++)
                {
                    if (listPokemons[i] <= value)
                    {
                        listPokemons[i] += value;
                    }
                    else
                    {
                        listPokemons[i] -= value;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
