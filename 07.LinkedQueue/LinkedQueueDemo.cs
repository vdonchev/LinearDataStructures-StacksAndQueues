namespace _07.LinkedQueue
{
    using System;

    public static class LinkedQueueDemo
    {
        public static void Main()
        { 
            var linkeQueue = new LinkedQueue<int>();
            linkeQueue.Enqueue(1);
            linkeQueue.Enqueue(3);
            linkeQueue.Enqueue(69);
            linkeQueue.Enqueue(100);
            Console.WriteLine(linkeQueue.Count);
            linkeQueue.Dequeue();
            linkeQueue.Dequeue();
            linkeQueue.Dequeue();
            linkeQueue.Dequeue();
            Console.WriteLine(linkeQueue.Count);

            try
            {
                linkeQueue.Dequeue();
            }
            catch (InvalidOperationException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }

            linkeQueue.Enqueue(1);
            linkeQueue.Enqueue(3);
            linkeQueue.Enqueue(69);
            linkeQueue.Enqueue(100);

            while (linkeQueue.Count > 0)
            {
                Console.WriteLine(linkeQueue.Dequeue());
            }

            linkeQueue.Enqueue(1);
            linkeQueue.Enqueue(3);
            linkeQueue.Enqueue(69);
            linkeQueue.Enqueue(100);

            var arr = linkeQueue.ToArray();
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
