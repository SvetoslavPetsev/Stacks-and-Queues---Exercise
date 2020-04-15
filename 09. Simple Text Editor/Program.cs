using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main()
        {
            var text = string.Empty;
            var undoStack = new Stack<string>();
            var numberOperation = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOperation; i++)
            {
                var input = Console.ReadLine();
                if (input == "4" && undoStack.Any())
                {
                   text = undoStack.Pop();
                }
                var command = input.Split();
                if (command[0] == "1")
                {
                    var appends = command[1];
                    undoStack.Push(text); //запис на текущото състояние в Stack, преди промяната
                    text += appends;
                }
                else if (command[0] == "2")
                {
                    var count = int.Parse(command[1]);
                    var startIndex = text.Length - count;
                    undoStack.Push(text); //запис на текущото състояние в Stack, преди промяната
                    text = text.Remove(startIndex);
                }
                else if (command[0] == "3")
                {
                    var index = int.Parse(command[1]);
                    Console.WriteLine(text[index - 1]);
                }
            }
        }
    }
}
