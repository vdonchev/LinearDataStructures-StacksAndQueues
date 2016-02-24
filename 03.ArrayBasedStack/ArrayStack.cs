namespace _03.ArrayBasedStack
{
    using System;

    public class ArrayStack<T> : IArrayStack<T>
    {
        private const int InitialCapacity = 16;

        private T[] internalStorage;
        private int capacity;

        public ArrayStack(int capacity = InitialCapacity)
        {
            this.Capacity = capacity;
            this.internalStorage = new T[this.Capacity];
        }

        public int Count { get; private set; }

        private int Capacity
        {
            get
            {
                return this.capacity;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(value),
                        "Capacity should be positive integer number.");
                }

                this.capacity = value;
            }
        }

        public void Push(T element)
        {
            if (this.GrowNeeded())
            {
                this.Grow();
            }

            this.internalStorage[this.Count] = element;
            this.Count++;
        }

        public T Pop()
        {
            if (this.Count <= 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            
            this.Count--;
            var element = this.internalStorage[this.Count];
            this.internalStorage[this.Count] = default(T);

            return element;
        }

        public T Peek()
        {
            var element = this.internalStorage[this.Count - 1];

            return element;
        }

        public T[] ToArray()
        {
            var arr = new T[this.Count];
            this.FillStorage(arr);
            Array.Reverse(arr);

            return arr;
        }

        private bool GrowNeeded()
        {
            var result = this.Count >= this.Capacity;

            return result;
        }

        private void Grow()
        {
            this.Capacity *= 2;
            var newStorage = new T[this.Capacity];
            this.FillStorage(newStorage);
            this.internalStorage = newStorage;
        }

        private void FillStorage(T[] array)
        {
            Array.Copy(this.internalStorage, array, this.Count);
        }
    }
}
