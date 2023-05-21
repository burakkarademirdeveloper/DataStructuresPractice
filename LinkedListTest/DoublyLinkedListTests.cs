using LinkedListClassLibrary.DoublyLinkedList;
using Xunit;
namespace LinkedListTest;

public class DoublyLinkedListTests
{
    private DoublyLinkedList<int> _list;

    public DoublyLinkedListTests()
    {
        _list = new DoublyLinkedList<int>(new int[] {23,46,58,96});
    }
    
    [Theory]
    [InlineData(8)]
    public void AddFirstTest(int value)
    {
        _list.AddFirst(value);
        Assert.Equal(value, _list.Head.Value);
    }
    
    [Theory]
    [InlineData(8)]
    public void AddLastTest(int value)
    {
        _list.AddLast(value);
        Assert.Equal(value, _list.Tail.Value);
    }
    
}