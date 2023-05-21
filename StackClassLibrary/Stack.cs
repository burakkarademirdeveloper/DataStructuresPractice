using System.Collections;
using StackClassLibrary.Interfaces;

namespace StackClassLibrary;

public class Stack<T> : IStack<T>
{
    private readonly IStack<T> _stack;
    public IEnumerator<T> GetEnumerator()
    {
        return _stack.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public int Count => _stack.Count;
    public T Pop()
    {
        return _stack.Pop();
    }

    public void Push(T item)
    {
    _stack.Push(item);
    }

    public T Peek()
    {
        return _stack.Peek();
    }
}