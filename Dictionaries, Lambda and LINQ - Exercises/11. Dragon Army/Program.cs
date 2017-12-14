using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var dragonsArmy = new Dictionary<string, Dictionary<string, List<double>>>();
            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                var nameArmy = input[0];
                var nameDragon = input[1];
                var damage = 0.0;
                if (input[2] == "null")
                {
                    damage = 45;
                }
                else
                {
                    damage = double.Parse(input[2]);
                }
                var heaith = 0.0;
                if (input[3] == "null")
                {
                    heaith = 250;
                }
                else
                {
                    heaith = double.Parse(input[3]);
                }
                var armor = 0.0;
                if (input[4] == "null")
                {
                    armor = 10;
                }
                else
                {
                    armor = double.Parse(input[4]);
                }
                if (dragonsArmy.ContainsKey(nameArmy))
                {
                    if (dragonsArmy[nameArmy].ContainsKey(nameDragon))
                    {
                        List<double> status = new List<double>();
                        status.Add(damage);
                        status.Add(heaith);
                        status.Add(armor);
                        dragonsArmy[nameArmy][nameDragon] = status;
                    }
                    else
                    {
                        List<double> status = new List<double>();
                        status.Add(damage);
                        status.Add(heaith);
                        status.Add(armor);
                        dragonsArmy[nameArmy].Add(nameDragon, status);
                    }
                }
                else
                {
                    var dragon = new Dictionary<string, List<double>>();
                    List<double> status = new List<double>();
                    status.Add(damage);
                    status.Add(heaith);
                    status.Add(armor);
                    dragon.Add(nameDragon, status);
                    dragonsArmy.Add(nameArmy, dragon);
                }
            }
            foreach (var army in dragonsArmy)
            {
                var damage = 0.0;
                var health = 0.0;
                var armor = 0.0;
                foreach (var dragon in army.Value)
                {
                    damage += dragon.Value[0];
                    health += dragon.Value[1];
                    armor += dragon.Value[2];
                }
                var length = army.Value.Values.Count();
                Console.WriteLine("{0}::({1:f2}/{2:f2}/{3:f2})", army.Key, damage/length, health/length, armor/length);
                foreach (var dragon in army.Value.OrderBy(a => a.Key))
                {
                    Console.WriteLine("-{0} -> damage: {1}, health: {2}, armor: {3}", dragon.Key, dragon.Value[0], dragon.Value[1], dragon.Value[2]);
                }
            }
            
        }
    }
}
