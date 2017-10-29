using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonEvolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<int, Dictionary<string, int>>> dictPokemons = new Dictionary<string, Dictionary<int, Dictionary<string, int>>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "wubbalubbadubdub")
                {
                    break;
                }
                if (input.Contains("->"))
                {
                    string[] delimiters = new string[] { "->" };
                    string[] inputParsed = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                    string pokemonName = inputParsed[0].Trim();
                    string evolutionType = inputParsed[1].Trim();
                    int evolutionIndex = int.Parse(inputParsed[2]);
                    // dictPokemons[pokemonName][evolutionIndex][evolutionType]
                    if (dictPokemons.ContainsKey(pokemonName))
                    {
                        if (dictPokemons[pokemonName].ContainsKey(evolutionIndex))
                        {
                            if (dictPokemons[pokemonName][evolutionIndex].ContainsKey(evolutionType))
                            {
                                dictPokemons[pokemonName][evolutionIndex][evolutionType]++;
                            }
                            else
                            {
                                dictPokemons[pokemonName][evolutionIndex].Add(evolutionType, 1);
                            }
                        }
                        else
                        {
                            Dictionary<string, int> thirdDict = new Dictionary<string, int>();
                            thirdDict.Add(evolutionType, 1);
                            dictPokemons[pokemonName].Add(evolutionIndex, thirdDict);
                        }
                    }
                    else
                    {
                        Dictionary<int, Dictionary<string, int>> localdict = new Dictionary<int, Dictionary<string, int>>();
                        Dictionary<string, int> thirdDict = new Dictionary<string, int>();
                        thirdDict.Add(evolutionType, 1);
                        localdict.Add(evolutionIndex, thirdDict);
                        dictPokemons.Add(pokemonName, localdict);
                    }
                }
                else
                {
                    string pokemonNamec = input;
                    if (dictPokemons.ContainsKey(pokemonNamec))
                    {
                        foreach (var pokemonName in dictPokemons.Where(x => x.Key == pokemonNamec))
                        {
                            Console.WriteLine("# " + pokemonName.Key);
                            foreach (var evolutionIndex in pokemonName.Value.OrderByDescending(y => y.Key))
                            {
                                foreach (var evolutionType in evolutionIndex.Value)
                                {
                                    for (int i = 0; i < evolutionType.Value; i++)
                                    {
                                        Console.WriteLine(evolutionType.Key + " <-> " + evolutionIndex.Key);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            // dictPokemons[pokemonName][evolutionIndex][evolutionType]
            foreach (var pokemonName in dictPokemons)
            {
                Console.WriteLine("# " + pokemonName.Key);
                foreach (var evolutionIndex in pokemonName.Value.OrderByDescending(y => y.Key))
                {
                    foreach (var evolutionType in evolutionIndex.Value)
                    {
                        for (int i = 0; i < evolutionType.Value; i++)
                        {
                            Console.WriteLine(evolutionType.Key + " <-> " + evolutionIndex.Key);
                        }
                    }
                }
            }
        }
    }
}
