using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameDrink = Console.ReadLine();
            var ml = double.Parse(Console.ReadLine());
            var energyFor100ml = double.Parse(Console.ReadLine());
            var sugarFor100ml = double.Parse(Console.ReadLine());
            var totalEnergy = (ml / 100) * energyFor100ml;
            var totalSugar = (ml / 100) * sugarFor100ml;
            Console.WriteLine("{0}ml {1}:", ml, nameDrink);
            Console.WriteLine("{0}kcal, {1}g sugars", totalEnergy, totalSugar);
        }
    }
}
