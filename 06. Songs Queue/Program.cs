using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main()
        {
            var songsArr = Console.ReadLine().Split(", ");
            var queueSongs = new Queue<string>(songsArr);

            while (queueSongs.Count > 0)
            {
                var input = Console.ReadLine();
                var cmdArgs = input.Split();
                var cmd = cmdArgs[0];
                if (cmd == "Play")
                {
                    queueSongs.Dequeue();
                    if (queueSongs.Count == 0)
                    {
                        Console.WriteLine("No more songs!");
                        break;
                    }
                }
                else if (cmd == "Add")
                {
                    var song = input.Remove(0, 4);
                    if (queueSongs.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        queueSongs.Enqueue(song);
                    }
                }
                else if (cmd == "Show")
                {
                    Console.WriteLine(string.Join(", ", queueSongs));
                }
            }
        }
    }
}
