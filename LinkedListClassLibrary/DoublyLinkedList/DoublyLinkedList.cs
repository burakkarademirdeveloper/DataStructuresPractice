namespace LinkedListClassLibrary.DoublyLinkedList;

public class DoublyLinkedList<T>
{
    public int Count { get; private set; }
    public DbNode<T> Head { get; private set; }
    public DbNode<T> Tail { get; private set; }
    
    private bool isHeadNull => Head == null;

    public DoublyLinkedList()
    {
        Head = null;
        Tail = null;
        Count = 0;
    }

    public DoublyLinkedList(IEnumerable<T> collection) : this()
    {
        foreach (var item in collection)
        {
            AddFirst(item);
        }
    }

    public void AddFirst(T value)
    {
        var newNode = new DbNode<T>(value);
        if (isHeadNull)
        {
            Head = newNode;
            Tail = newNode;
            Count++;
            return;
        }
        else
        {
            newNode.Next = Head;
            Head.Previous = newNode;
            Head = newNode;
            Count++;
            return;
        }
    }

    public void AddLast(T value)
    {
        var newNode = new DbNode<T>(value);
        if (isHeadNull)
        {
            AddFirst(value);
            return;
        }
        Tail.Next = newNode;
        newNode.Previous = Tail;
        Tail = newNode;
        Count++;
        return;
    }

    public void AddBefore(DbNode<T> node, T value)
    {
        if (node == null || value is null)
        {
            throw new ArgumentNullException(nameof(node));
        }

        if (isHeadNull || node.Equals(Head))
        {
            AddFirst(value);
            return;
        }
        var newNode = new DbNode<T>(value);
        var current = Head;
        var previous = current;
        while (current!=null)
        {
            if (current.Equals(node))
            {
                newNode.Next = previous.Next;
                newNode.Previous = previous;
                previous.Next = newNode;
                newNode.Next.Previous = newNode;
                Count++;
                return;
            }
            previous = current;
            current = current.Next;
        }

        throw new ArgumentException("Ex");
    }

    public void AddAfter(DbNode<T> node, T value)
    {
        if (node == null || value is null)
        {
            throw new ArgumentNullException(nameof(node));
        }

        if (isHeadNull || node.Equals(Head))
        {
            AddFirst(value);
            return;
        }
        var newNode = new DbNode<T>(value);
        var current = Head;
        var previous = current;

        while (current!=null)
        {
            if (current.Equals(node))
            {
                if (current.Next!=null)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    newNode.Previous = current;
                    newNode.Next.Previous = newNode;
                    Count++;
                    return;
                }
                else
                {
                    AddLast(value);
                    return;
                }
            }
            current = current.Next;
        }
    }

    public T RemoveFirst()
    {
        if (isHeadNull)
        {
            throw new ArgumentNullException("Liste boş.");
        }

        var temp = Head;
        if (Count==1)
        {
            Head = null;
            Count--;
            return temp.Value;
        }
        Head = Head.Next;
        Head.Previous = null;
        Count--;
        return temp.Value;
    }

    public T RemoveLast()
    {
        if (isHeadNull || Count==0)
        {
            throw new Exception();
        }

        if (Count==1)
        {
            var temp = Head;
            Head = null;
            Count--;
            return temp.Value;
        }
        else
        {
            var temp = Tail;
            Tail.Previous.Next = null;
            Tail = Tail.Previous;
            Count--;
            return temp.Value;
        }
    }

    public T Remove(T value)
    {
        if (isHeadNull)
        {
            throw new Exception();
        }
        var current = Head;
        var previous = current;
        while (current!=null)
        {
            if (current.Value.Equals(value))
            {
                if (current.Value.Equals(Head.Value))
                {
                    return RemoveFirst();
                }

                if (current.Value.Equals(Tail))
                {
                    return RemoveLast();
                }

                var temp = current;
                previous.Next = current.Next;
                current.Next.Previous = current.Previous;
                current = null;
                Count--;
                return temp.Value;
            }
            previous = current;
            current = current.Next;
        }

        throw new ArgumentException();
    }

}