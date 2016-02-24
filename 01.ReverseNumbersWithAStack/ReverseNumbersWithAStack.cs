namespace _01.ReverseNumbersWithAStack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class ReverseNumbersWithAStack
    {
        public static void Main()
        {
            Console.WriteLine("Insert n integer numbers separated by space(s):");
            var userInput = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var numStack = new Stack<int>();

            foreach (var item in userInput)
            {
                numStack.Push(item);
            }

            while (numStack.Count > 0)
            {
                Console.Write($"{numStack.Pop()} ");
            }
        }
    }
}
