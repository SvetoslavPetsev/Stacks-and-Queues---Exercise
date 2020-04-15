using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
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
            var stack = new Stack<int>();

            for (int i = 0; i < pushElements; i++)
            {
                stack.Push(elements[i]);
            }
            for (int i = 0; i < popElements; i++)
            {
                if (stack.Any())
                {
                    stack.Pop();
                }
            }
            if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if (stack.Contains(check))
            {
                Console.WriteLine(stack.Contains(check).ToString().ToLower());
            }
            else
            {
                Console.WriteLine(stack.Min().ToString());
            }
        }
    }
}
