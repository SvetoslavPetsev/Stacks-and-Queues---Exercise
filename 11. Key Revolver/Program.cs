using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main()
        {
            int bulletCost = int.Parse(Console.ReadLine());
            int sizeBarrel = int.Parse(Console.ReadLine());

            int[] bullets = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] locks = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int inteligentValue = int.Parse(Console.ReadLine());

            Stack<int> bulletsStack = new Stack<int>(bullets);
            Queue<int> locksQueue = new Queue<int>(locks);
            int bulletCounter = 0;

            while (locksQueue.Any() && bulletsStack.Any())
            {
                for (int i = 0; i < sizeBarrel; i++)
                {
                    if (!bulletsStack.Any() || !locksQueue.Any())
                    {
                        break;
                    }

                    else if (bulletsStack.Peek() <= locksQueue.Peek())
                    {
                        Console.WriteLine("Bang!");
                        locksQueue.Dequeue();
                    }

                    else
                    {
                        Console.WriteLine("Ping!");
                    }

                    bulletsStack.Pop();
                    bulletCounter++;
                    if (bulletsStack.Any() && i == sizeBarrel - 1)
                    {
                        Console.WriteLine("Reloading!");
                    }
                }
            }
            if (locksQueue.Any())
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
            }
            else
            {
                int profit = inteligentValue - (bulletCounter * bulletCost);
                Console.WriteLine($"{bulletsStack.Count} bullets left. Earned ${profit}");
            }
        }
    }
}
