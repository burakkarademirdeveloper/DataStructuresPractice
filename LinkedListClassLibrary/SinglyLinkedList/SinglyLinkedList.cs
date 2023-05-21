using System.Collections;

namespace LinkedListClassLibrary.SinglyLinkedList;

public class SinglyLinkedList<T> : IEnumerable<T>
{
    public SinglyLinkedListNode<T> Head { get; set; }
    public int Count { get; set; }
    private bool isHeadNull => Head is null;

    public SinglyLinkedList()
    {
        Head = null;
        Count = 0;
    }

    public SinglyLinkedList(IEnumerable<T> collection) : this()
    {
        foreach (var item in collection)
        {
            AddFirst(item);
        }
    }
    
    public void AddFirst(T value)
    {
        SinglyLinkedListNode<T> newNode = new(value);
        if (isHeadNull)
        {
            Head = newNode;
            Count++;
            return;
        }
        newNode.Next = Head;
        Head = newNode;
        Count++;
        return;
    }



    public void AddLast(T value)
    {
        var newNode = new SinglyLinkedListNode<T>(value);
        if (isHeadNull)
        {
            Head = newNode;
            Count++;
            return;
        }
        var current = Head;
        var previous = current;
        while (current != null)
        {
            previous = current;
            current = current.Next;
        }
        previous.Next = newNode;
        Count++;
        return;
    }

    public void AddBefore(SinglyLinkedListNode<T> refNode, T value)
    {
        var newNode = new SinglyLinkedListNode<T>(value);
        if (isHeadNull)
        {
            Head = newNode;
            Count++;
            return;
        }
        var current = Head;
        var previous = current;
        while (current != null)
        {
            if (current == refNode)
            {
                previous.Next = newNode;
                newNode.Next = current;
                Count++;
                return;
            }
            previous = current;
            current = current.Next;
        }
        throw new Exception("Referans node bulunamadı.");
    }
    
    public void AddAfter(SinglyLinkedListNode<T> refNode, T value)
    {
        var newNode = new SinglyLinkedListNode<T>(value);
        if (isHeadNull)
        {
            Head = newNode;
            Count++;
            return;
        }
        var current = Head;
        while (current != null)
        {
            if (current == refNode)
            {
                newNode.Next = current.Next;
                current.Next = newNode;
                Count++;
                return;
            }
            current = current.Next;
        }
        throw new Exception("Referans node bulunamadı.");
    }
    
    public void RemoveFirst()
    {
        if (isHeadNull)
        {
            throw new Exception("Liste boş.");
        }
        Head = Head.Next;
        Count--;
        return;
    }

    public T RemoveLast( int value)
    {
        if (isHeadNull || Count == 0)
        {
            throw new Exception(nameof(Head));
        }

        if (Count==1)
        {
            Head = null;
            Count--;
            return Head.Value;
        }
        else
        {
            var current = Head;
            var previous = current;
            while (current.Next != null)
            {
                previous = current;
                current = current.Next;
            }
            previous.Next = null;
            Count--;
            return current.Value;
        }
    }
    public IEnumerator<T> GetEnumerator()
    {
        throw new SinglyLinkedListEnumerator<T>(Head);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    
    public List<T> ToList() => new List<T>(this);

}