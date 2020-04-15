using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main()
        {
            var quantityFood = int.Parse(Console.ReadLine());

            var ordersArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var orderQueue = new Queue<int>(ordersArr);

            Console.WriteLine(orderQueue.Max().ToString());

            while (true)
            {
                int currOrder = orderQueue.Peek();
                if (currOrder <= quantityFood)
                {
                    quantityFood -= currOrder;
                    orderQueue.Dequeue();

                    if (orderQueue.Count == 0)
                    {
                        Console.WriteLine("Orders complete");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", orderQueue)}");
                    break;
                }
            }   
        }
    }
}
