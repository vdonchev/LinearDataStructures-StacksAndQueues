namespace _07.LinkedQueue
{
    using System;

    public class LinkedQueue<T> : ILinkedQueue<T>
    {
        private QueueNode<T> start; 
        private QueueNode<T> end; 

        public int Count { get; private set; }

        public void Enqueue(T element)
        {
            var currentNode = new QueueNode<T>(element);

            if (this.Count == 0)
            {
                this.start = this.end = currentNode;
            }
            else
            {
                this.end.NextNode = currentNode;
                currentNode.PrevNode = this.end;
                this.end = currentNode;
            }

            this.Count++;
        }

        public T Dequeue()
        {
            if (this.Count <= 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            QueueNode<T> currentNode = null;

            if (this.Count == 1)
            {
                currentNode = this.start;
                this.start = this.end = null;
            }
            else
            {
                currentNode = this.start;
                this.start = this.start.NextNode;
                this.start.PrevNode = null;
            }

            this.Count--;

            return currentNode.Value;
        }

        public T[] ToArray()
        {
            var arr = new T[this.Count];
            var currentNode = this.start;
            var arrIndex = 0;
            while (currentNode != null)
            {
                arr[arrIndex] = currentNode.Value;
                arrIndex++;
                currentNode = currentNode.NextNode;
            }

            return arr;
        }

        private class QueueNode<T2>
        {
            public QueueNode(T2 element)
            {
                this.Value = element;
            }

            public T2 Value { get; private set; }

            public QueueNode<T2> NextNode { get; set; }

            public QueueNode<T2> PrevNode { get; set; }
        }
    }
}