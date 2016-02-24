namespace _05.LinkedStack
{
    using System;

    public static class LinkedStack
    {
        public static void Main()
        {
            var stack = new LinkedStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(10);
            stack.Push(69);
            stack.Push(69);

            while (stack.Count > 0)
            {
                Console.WriteLine($"Pop: {stack.Pop()}");
            }

            stack.Push(1);
            stack.Push(2);
            stack.Push(10);
            stack.Push(69);
            stack.Push(69);

            var popped = stack.Pop();
            Console.WriteLine($"Popped element: {popped}");

            var arr = stack.ToArray();

            Console.WriteLine(
                "Stack to array representataion: {0}",
                string.Join(", ", arr));
        }
    }
}