using System.Collections;
using DataStructures.Arrray.Generic;
using StackClassLibrary.Interfaces;

namespace StackClassLibrary;

public class ArrayStack<T> : IStack<T>
{
    private readonly Array<T> _array;
    public IEnumerator<T> GetEnumerator()
    {
        return _array.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public int Count => _array.Count;
    public T Pop()
    {
        if (Count==0)
        {
            throw new Exception("Yığın boş.");
        }

        var result = _array.Remove();
        return result;
    }

    public void Push(T item)
    {
        _array.Add(item);
    }

    public T Peek()
    {
        if (Count==0)
        {
            return default(T);
        }

        return _array.GetValue(_array.Count - 1);
    }
}