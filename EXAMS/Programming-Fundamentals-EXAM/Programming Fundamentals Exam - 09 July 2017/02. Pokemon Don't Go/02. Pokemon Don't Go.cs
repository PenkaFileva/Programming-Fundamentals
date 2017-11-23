using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokeMon = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var sum = 0;
            while (pokeMon.Count > 0)
            {
                var index = int.Parse(Console.ReadLine());
                if (index < 0)
                {
                    var currentElement = pokeMon[0];
                    pokeMon.RemoveAt(0);
                    pokeMon.Insert(0, pokeMon[pokeMon.Count-1]);
                    for (int i = 0; i < pokeMon.Count; i++)
                    {
                        if (pokeMon[i] <= currentElement )
                        {
                            pokeMon[i] += currentElement;
                        }
                        else
                        {
                            pokeMon[i] -= currentElement;
                        } 
                    }
                    sum += currentElement;
                    continue;
                }
                if (index > pokeMon.Count-1)
                {
                    var currentElement = pokeMon[pokeMon.Count-1];
                    pokeMon.RemoveAt(pokeMon.Count-1);
                    pokeMon.Add(pokeMon[0]);
                    for (int i = 0; i < pokeMon.Count; i++)
                    {
                        if (pokeMon[i] <= currentElement)
                        {
                            pokeMon[i] += currentElement;
                        }
                        else
                        {
                            pokeMon[i] -= currentElement;
                        }
                    }
                    sum += currentElement;
                    continue;
                }
                else if (index >= 0 && index < pokeMon.Count)
                {
                    var currentElement = pokeMon[index];
                    pokeMon.RemoveAt(index);
                    //pokeMon.Add(pokeMon[0]);
                    for (int i = 0; i < pokeMon.Count; i++)
                    {
                        if (pokeMon[i] <= currentElement)
                        {
                            pokeMon[i] += currentElement;
                        }
                        else
                        {
                            pokeMon[i] -= currentElement;
                        }
                    }
                    sum += currentElement;
                    continue;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
