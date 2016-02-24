namespace _02.CalculateSequenceWithQueue
{
    using System;
    using System.Collections.Generic;

    public static class CalculateSequenceWithQueue
    {
        private const int ResultLimit = 50;

        public static void Main()
        {
            Console.Write("Insert a starting integer number = ");
            var start = int.Parse(Console.ReadLine());

            var queue = new Queue<long>();
            queue.Enqueue(start);

            var output = new List<long>();
            int numberOfResults = ResultLimit;
            while (numberOfResults > 0)
            {
                var currentNum = queue.Dequeue();
                output.Add(currentNum);
                numberOfResults--;

                queue.Enqueue(currentNum + 1);
                queue.Enqueue((currentNum * 2) + 1);
                queue.Enqueue(currentNum + 2);
            }

            Console.WriteLine(string.Join(", ", output));
        }
    }
}
