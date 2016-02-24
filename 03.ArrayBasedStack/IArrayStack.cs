namespace _03.ArrayBasedStack
{
    public interface IArrayStack<T>
    {
        int Count { get; }

        void Push(T element);

        T Pop();

        T Peek();

        T[] ToArray();
    }
}