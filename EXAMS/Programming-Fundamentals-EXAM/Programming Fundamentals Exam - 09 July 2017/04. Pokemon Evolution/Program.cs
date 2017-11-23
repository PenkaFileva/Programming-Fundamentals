using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Pokemon_Evolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> pokemons = 
                new Dictionary<string, List<string>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "wubbalubbadubdub")
                {
                    break;
                }
                var tokens = input.Split(new string[] {" -> "},
                    StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 1)
                {
                    var pokemonN = tokens[0];
                    if (pokemons.ContainsKey(pokemonN))
                    {
                        Console.WriteLine($"# {pokemonN}");
                        pokemons[pokemonN].ForEach(Console.WriteLine);
                    }
                    else
                    {
                        continue; 
                    }
                }
                else
                {
                    var pokemonName = tokens[0];
                    var evolutionType = tokens[1];
                    var evolutionIndex = (tokens[2]);

                    var evolutionTypeIndex = evolutionType + " <-> " + evolutionIndex;
                    if (!pokemons.ContainsKey(pokemonName))
                    {
                        pokemons[pokemonName] = new List<string>();
                    }
                    pokemons[pokemonName].Add(evolutionTypeIndex);
                }


                // Pokemon pokemon = new Pokemon()
                // {
                //     Name = pokemonName,
                //     EvolutionType = evolutionType,
                //     EvolutionIndex = evolutionIndex
                // };
            }
            foreach (var kvp in pokemons)
            {
                Console.WriteLine(($"# {kvp.Key}"));
                var ordered = kvp.Value
                    .OrderByDescending(a =>
                    {
                        return int.Parse(a.Split(new string[] {"<->"}
                            , StringSplitOptions.RemoveEmptyEntries)[1]);
                    });
                foreach (var output in ordered)
                {
                    Console.WriteLine(output);
                }
            }
        }
    }

    //class Pokemon
    //{
    //    public string Name { get; set; }
    //    public string EvolutionType { get; set; }
    //    public long EvolutionIndex { get; set; }
    //}
}
