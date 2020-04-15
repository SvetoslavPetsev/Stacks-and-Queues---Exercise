using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main()
        {
            var cmdArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int pushElements = cmdArgs[0];
            int popElements = cmdArgs[1];
            int check = cmdArgs[2];

            var elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var queue = new Queue<int>();

            for (int i = 0; i < pushElements; i++)
            {
                queue.Enqueue(elements[i]);
            }
            for (int i = 0; i < popElements; i++)
            {
                if (queue.Any())
                {
                    queue.Dequeue();
                }
            }
            if (queue.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if (queue.Contains(check))
            {
                Console.WriteLine(queue.Contains(check).ToString().ToLower());
            }
            else
            {
                Console.WriteLine(queue.Min().ToString());
            }
        }
    }
}
