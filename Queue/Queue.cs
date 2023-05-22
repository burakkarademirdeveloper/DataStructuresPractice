using System.Collections;
using Queue.Interfaces;

namespace Queue;

public class Queue<T> : IQueue<T>
{
    private readonly IQueue<T> _queue;
    public int Count => _queue.Count;
    public void Enqueue(T item)
    {
        _queue.Enqueue(item);
    }

    public T Dequeue()
    {
        return _queue.Dequeue();
    }

    public T Peek()
    {
        return _queue.Peek();
    }

    public IEnumerator<T> GetEnumerator()
    {
        return _queue.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class ArrayQueue<T> : IQueue<T>
{
    private readonly List<T> _queue;

    public ArrayQueue()
    {
        _queue = new List<T>();
    }
    public IEnumerator<T> GetEnumerator()
    {
        return _queue.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public int Count => _queue.Count;
    public void Enqueue(T item)
    {
        _queue.Add(item);
    }

    public T Dequeue()
    {
        if (Count==0)
        {
            throw new Exception("Queue boş.");
        }
        var temp = _queue[0];
        _queue.RemoveAt(0);
        return temp;
    }

    public T Peek()
    {
        return Count == 0 ? default(T) : _queue[0];
    }
}