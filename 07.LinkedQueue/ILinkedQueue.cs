namespace _07.LinkedQueue
{
    public interface ILinkedQueue<T>
    {
        void Enqueue(T element);

        T Dequeue();

        T[] ToArray();
    }
}