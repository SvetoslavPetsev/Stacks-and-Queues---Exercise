using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main()
        {
            var numberStation = int.Parse(Console.ReadLine());
            var stationQueue = new Queue<int[]>();
            for (int i = 0; i < numberStation; i++)
            {
                var station = Console.ReadLine().Split().Select(int.Parse).ToArray();
                stationQueue.Enqueue(station);
            }

            var fullDistance = stationQueue.Sum(x => x[1]);
            var startStationIndex = 0;
            var fuel = 0;
            var distance = 0;
            var currStationIndex = 0;
            while (distance < fullDistance)
            {
                var currStation = stationQueue.Peek();
                int currFuel = currStation[0];
                int currDistance = currStation[1];

                if (fuel + currFuel < currDistance)
                {
                    startStationIndex = currStationIndex + 1;
                    fuel = 0;
                    distance = 0;
                }
                else
                {
                    fuel += currFuel;
                    fuel -= currDistance;
                    distance += currDistance;
                }
                currStationIndex++;
                stationQueue.Enqueue(currStation);
                stationQueue.Dequeue();
            }
            Console.WriteLine(startStationIndex);
        }
    }
}
