// See https://aka.ms/new-console-template for more information

using LinkedListClassLibrary.SinglyLinkedList;

Console.WriteLine("Hello, World!");


var node1 = new SinglyLinkedListNode<int>(1);
var node2 = new SinglyLinkedListNode<int>(2);
var node3 = new SinglyLinkedListNode<int>(3);

node1.Next = node2;
node2.Next = node3;

AddLast(node1, 5);
AddFirst(ref node1, 4);
Traverse(node1);




static void AddLast<T>(SinglyLinkedListNode<T> head, T value)
{
    if (head is null)
        throw new ArgumentNullException();
    
    var newNode = new SinglyLinkedListNode<T>(value);
    var current = head;
    while (current.Next != null)
    {
        current = current.Next;
    }
    current.Next = newNode;
}

static void AddFirst<T>(ref SinglyLinkedListNode<T> head, T value)
{
    if (head is null)
        throw new ArgumentNullException();
    
    var newNode = new SinglyLinkedListNode<T>(value);
    newNode.Next = head;
    head = newNode;
}

static void Traverse<T>(SinglyLinkedListNode<T> head)
{
    var current = head;
    if (current is null)
    {
        throw new Exception("Liste elemanı bitti.");
    }
    while (current!= null)
    {
            
        Console.WriteLine(current.Value);
        current = current.Next;
    }
}

public class SinglyLinkedListNode<T>
{
    public T Value { get; set; }
    public SinglyLinkedListNode<T> Next { get; set; }

    public SinglyLinkedListNode(T value)
    {
        Value = value;
    }
}

