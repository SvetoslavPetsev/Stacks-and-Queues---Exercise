using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Crossroads
{
    class Program
    {
        static void Main()
        {
            var grLightDuration = int.Parse(Console.ReadLine());
            var freeWindow = int.Parse(Console.ReadLine());
            var totalCarsPassed = 0;

            Queue<string> traffiic = new Queue<string>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                if (input == "green")
                {
                    var currLigthDuration = grLightDuration;

                    while (traffiic.Any() && currLigthDuration != 0)
                    {
                        var currCar = traffiic.Peek();
                        var curCarLenght = currCar.Length;
                        if (curCarLenght <= currLigthDuration)
                        {
                            traffiic.Dequeue();
                            currLigthDuration -= currCar.Length;
                            totalCarsPassed++;
                            continue;
                        }

                        else
                        {
                            curCarLenght -= currLigthDuration;
                        }

                        if (curCarLenght <= freeWindow)
                        {
                            traffiic.Dequeue();
                            totalCarsPassed++;
                            break;
                        }

                        else
                        {
                            curCarLenght -= freeWindow;
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{currCar} was hit at {currCar[currCar.Length - curCarLenght]}.");
                            return;
                        }
                    }
                }
                else
                {
                    var car = input;
                    traffiic.Enqueue(car);
                }
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{totalCarsPassed} total cars passed the crossroads.");
        }
    }
}
