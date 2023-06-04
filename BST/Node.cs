public class Node<T>
{
    public T Item;
    public Node<T> Left;
    public Node<T> Right;

    public Node()
    {
        
    }

    public void Display() =>
        Console.Write($"{Item}  ");
    
}