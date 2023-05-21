namespace LinkedListClassLibrary.DoublyLinkedList;

public class DbNode<T>
{
    public T Value { get; set; }
    public DbNode<T> Next { get; set; }
    public DbNode<T> Previous { get; set; }

    public DbNode(T item)
    {
        Value = item;
    }
}