using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main()
        {
            var stack = new Stack<sbyte>();
            var numberInput = sbyte.Parse(Console.ReadLine());
            for (int i = 0; i < numberInput; i++)
            {
                var cmd = Console.ReadLine().Split();
                if (cmd[0] == "1")
                {
                    var element = sbyte.Parse(cmd[1]);
                    stack.Push(element);
                }
                else if (cmd[0] == "2")
                {
                    if (stack.Any())
                    {
                        stack.Pop();
                    }
                }
                else if (cmd[0] == "3")
                {
                    if (stack.Any())
                    {
                        Console.WriteLine(stack.Max().ToString());
                    }
                }
                else if (cmd[0] == "4")
                {
                    if (stack.Any())
                    {
                        Console.WriteLine(stack.Min().ToString());
                    }
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
