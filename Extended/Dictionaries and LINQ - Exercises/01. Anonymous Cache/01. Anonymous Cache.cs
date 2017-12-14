using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Anonymous_Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            List<string> dateSet = new List<string>();
            var dateSetKeySize = new Dictionary<string, Dictionary<string, long>>();

            while (input != "thetinggoesskrra")
            {
                var tokens = input.Split(("->| ").ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (tokens.Length == 1)
                {
                    var set = tokens[0];
                    dateSet.Add(set);
                }               

                else 
                {
                    var set = tokens[2];
                    var key = tokens[0];
                    var size = long.Parse(tokens[1]);
                    if (!dateSetKeySize.ContainsKey(set))
                    {
                        dateSetKeySize[set] = new Dictionary<string, long>();   
                    }
                    dateSetKeySize[set][key] = size;

                }
              
                input = Console.ReadLine();
            }
            dateSetKeySize.ToList().Where(a => !dateSet.Contains(a.Key))
                .ToList().ForEach(s => dateSetKeySize.Remove(s.Key));
            
            //foreach (var set in dateSetKeySize)
            //{
            //    if (!dateSet.Contains(set.Key) )
            //    {
            //        dateSetKeySize.Remove(set.Key);
            //    }   
            //}
            if (dateSetKeySize.Count > 0)
            {
                var resultSetKeySize = dateSetKeySize
                    .OrderByDescending(a => a.Value.Sum(n => n.Value))
                    .First();

                Console.WriteLine($"Data Set: {resultSetKeySize.Key}, Total Size: {resultSetKeySize.Value.Sum(a => a.Value)}");
                foreach (var key in resultSetKeySize.Value)
                {
                    Console.WriteLine($"$.{key.Key}");
                }
            }
           
        }
    }
}
