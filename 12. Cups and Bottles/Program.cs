using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    class Program
    {
        static void Main()
        {
            var cupsCapacityArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var filledBottles = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var cupsQueue = new Queue<int>(cupsCapacityArr);
            var bottlesStack = new Stack<int>(filledBottles);
            var wastedWater = 0;
            while (cupsQueue.Any())
            {
                var currCup = cupsQueue.Peek();
                if (!bottlesStack.Any())
                {
                    break;
                }
                while (bottlesStack.Any())
                {
                    var currBottle = bottlesStack.Peek();
                    var diff = currBottle - currCup;
                    if (diff >= 0)
                    {
                        cupsQueue.Dequeue();
                        bottlesStack.Pop();
                        wastedWater += diff;
                        break;
                    }
                    else
                    {
                        bottlesStack.Pop();
                        currCup = diff * -1;
                    }
                }
            }
            if (bottlesStack.Any())
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottlesStack)}");
            }
            else if (cupsQueue.Any())
            {
                Console.WriteLine($"Cups: {string.Join(" ", cupsQueue)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
