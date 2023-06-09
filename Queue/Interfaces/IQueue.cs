﻿namespace Queue.Interfaces;

public interface IQueue<T> : IEnumerable<T>
{
    int Count { get; }
    void Enqueue(T item);
    T Dequeue();
    T Peek();
}