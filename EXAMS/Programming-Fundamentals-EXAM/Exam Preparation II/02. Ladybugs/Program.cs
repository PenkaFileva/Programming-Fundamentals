using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var fieldSize = int.Parse(Console.ReadLine());//разнер на масива
            var ladybugIndexes = Console.ReadLine()
                .Split().Select(int.Parse)
                .Where(a => a >= 0 && a < fieldSize).ToArray(); //индекси на калинките
            var ladybugs = new int[fieldSize]; //масив от калинки
            foreach (var ledybugIndex in ladybugIndexes) //подадените индекси променяме на 1
            {
                ladybugs[ledybugIndex] = 1;
            }
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "end") break;
                var tokens = line.Split();
                var ladybugIndex = int.Parse(tokens[0]); //индекс
                var direction = tokens[1];// посока
                var count = int.Parse(tokens[2]);//бр. премествания
                //проверка дали подавания индекс е в масива
                bool isInsideArray = ladybugIndex >= 0 && ladybugIndex < ladybugs.Length;
                if (!isInsideArray)
                    continue;

                //дали има колинка на подавания индекс
               bool ladybugExsist = ladybugs[ladybugIndex] == 1;
                if(!ladybugExsist)
                    continue;
                MoveLadybug(ladybugs, ladybugIndex, direction, count);  
            }
            Console.WriteLine(string.Join(" ", ladybugs));
        }

        private static void MoveLadybug(int[] ladybugs, int ladybugIndex, string direction, int count)
        {
            if (direction == "left")
            {
                count = -count;
            }

            var nextIndex = ladybugIndex + count;
            ladybugs[ladybugIndex] = 0;

            bool hasLeftArrayOrFoundPlace = false; //дали е намерено място на калинката
            while (!hasLeftArrayOrFoundPlace)
            {
                //дали nextIndex е извън Масива
                if (nextIndex < 0 ||  nextIndex > ladybugs.Length - 1)
                {
                    hasLeftArrayOrFoundPlace = true;
                    continue;
                }
                //дали има калинка на nextIndex. Ako има преместваме nextIndex със ст/стта на count
                bool ladybugAlreadyExistsOnIndex = ladybugs[nextIndex] == 1;
                if (ladybugAlreadyExistsOnIndex)
                {
                    nextIndex += count;
                    continue;
                }
                ladybugs[nextIndex] = 1;
                hasLeftArrayOrFoundPlace = true;
                
            }
        }
    }
}
