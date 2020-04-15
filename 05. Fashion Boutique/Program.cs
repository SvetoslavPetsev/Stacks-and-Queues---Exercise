using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main()
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var clothBox = new Stack<int>(arr);
            var startCapacity = int.Parse(Console.ReadLine());
            var counterRack = 1;

            var capacity = startCapacity;

            while (clothBox.Count != 0)
            {
                if (capacity - clothBox.Peek() >= 0)
                {
                    capacity -= clothBox.Pop();
                }
                else
                {
                    counterRack++;
                    capacity = startCapacity;
                }
            }
            Console.WriteLine(counterRack);
        }
    }
}