using System.Collections;

namespace LinkedListClassLibrary.SinglyLinkedList;

public class SinglyLinkedListEnumerator<T> : Exception, IEnumerator<T>
{
    private SinglyLinkedListNode<T> Head { get; set; }
    private SinglyLinkedListNode<T> Curr { get; set; }

    public T Current => Curr.Value;

    object IEnumerator.Current => Current;

    public SinglyLinkedListEnumerator(SinglyLinkedListNode<T> head)
    {
        Head = head;
        Curr = null;
    }
    public SinglyLinkedListEnumerator(SinglyLinkedListNode<object> head)
    {
        throw new NotImplementedException();
    }

    public bool MoveNext()
    {
        if (Head is null)
        {
            return false;
        }

        if (Curr is null)
        {
            Curr = Head;
            return true;
        }

        if (Curr.Next!=null)
        {
            Curr = Curr.Next;
            return true;
        }

        return false;
    }

    public void Reset()
    {
        Curr = null;
        Head = null;
    }

    

    public void Dispose()
    {
        Head = null;
    }
}