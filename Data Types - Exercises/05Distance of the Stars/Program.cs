using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Distance_of_the_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal kmForOneLightYear = 9450000000000m;
            decimal proximaCentauri = kmForOneLightYear * 4.22m;
            decimal center = kmForOneLightYear * 26000m;
            decimal milkyWay = kmForOneLightYear * 100000m;
            decimal observableUniverse = kmForOneLightYear * 46500000000m;
            Console.WriteLine("{0:e2}", proximaCentauri);
            Console.WriteLine("{0:e2}", center);
            Console.WriteLine("{0:e2}", milkyWay);
            Console.WriteLine("{0:e2}", observableUniverse);
        }
    }
}
