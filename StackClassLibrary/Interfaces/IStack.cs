namespace StackClassLibrary.Interfaces;

public interface IStack<T> :IEnumerable<T>
{
    int Count { get; }
    T Pop();
    void Push(T item);
    T Peek();
}