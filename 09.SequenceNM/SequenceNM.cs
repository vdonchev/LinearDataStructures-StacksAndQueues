namespace _09.SequenceNM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class SequenceNm
    {
        public static void Main()
        {
            Console.Write("Insert n and m integers, separated by space = ");
            var userInput = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var n = userInput[0];
            var m = userInput[1];

            var queue = new Queue<MyItem<int>>();
            queue.Enqueue(new MyItem<int>(n));

            var result = new Stack<int>();
            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                if (item.Value < m)
                {
                    queue.Enqueue(new MyItem<int>(item.Value * 2, item));
                    queue.Enqueue(new MyItem<int>(item.Value + 2, item));
                    queue.Enqueue(new MyItem<int>(item.Value + 1, item));
                }

                if (item.Value == m)
                {
                    var currentItem = item;
                    while (currentItem != null)
                    {
                        result.Push(currentItem.Value);
                        currentItem = currentItem.Prev;
                    }

                    break;
                }
            }

            if (result.Count > 0)
            {
                Console.WriteLine(string.Join(" -> ", result));
            }
            else
            {
                Console.WriteLine("(no solution)");
            }
        }

        private class MyItem<T>
        {
            public MyItem(
                T value,
                MyItem<T> prev = null)
            {
                this.Value = value;
                this.Prev = prev;
            }

            public T Value { get; private set; }

            public MyItem<T> Prev { get; private set; }
        }
    }
}