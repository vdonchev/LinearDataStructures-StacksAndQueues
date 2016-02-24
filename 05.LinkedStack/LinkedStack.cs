namespace _05.LinkedStack
{
    using System;

    public class LinkedStack<T> : ILinkedStack<T>
    {
        private LinkedStackNode<T> firstNode;

        public int Count { get; private set; }

        public void Push(T element)
        {
            var newNode = new LinkedStackNode<T>(element)
            {
                NextNode = this.firstNode
            };
            this.firstNode = newNode;
            this.Count++;
        }

        public T Pop()
        {
            if (this.Count <= 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            var nodeToPop = this.firstNode;
            this.firstNode = this.firstNode.NextNode;
            this.Count--;

            return nodeToPop.Value;
        }

        public T Peek()
        {
            var nodeToPeek = this.firstNode;

            return nodeToPeek.Value;
        }

        public T[] ToArray()
        {
            var arr = new T[this.Count];
            var currentNode = this.firstNode;
            var arrIndex = 0;
            while (currentNode != null)
            {
                arr[arrIndex] = currentNode.Value;
                arrIndex++;
                currentNode = currentNode.NextNode;
            }

            return arr;
        }

        private class LinkedStackNode<T2>
        {
            public LinkedStackNode(
                T2 value,
                LinkedStackNode<T2> nextNode = null)
            {
                this.Value = value;
            }

            public T2 Value { get; private set; }

            public LinkedStackNode<T2> NextNode { get; set; }
        }
    }
}
