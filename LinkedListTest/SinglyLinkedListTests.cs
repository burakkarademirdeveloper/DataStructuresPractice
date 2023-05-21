using LinkedListClassLibrary.SinglyLinkedList;

namespace LinkedListTest;

public class SinglyLinkedListTests
{
    
    private SinglyLinkedList<int> _list;

    public SinglyLinkedListTests()
    {
        _list = new SinglyLinkedList<int>(new int[] {1, 2, 3});
    }
    
    [Fact]
    public void CountTest()
    {
        int count = _list.Count;
        Assert.Equal(3, count);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void AddFirstTest(int value)
    {
        _list.AddFirst(value);
        Assert.Equal(value, _list.Head.Value);
    }
    
    [Fact]
    public void AddLastTest()
    {
        _list.AddLast(4);
        Assert.Equal(4, _list.Count);
    }

    [Fact]
    public void AddBeforeTest()
    {
        _list.AddBefore(_list.Head.Next, 5);
        Assert.Equal(5, _list.Head.Next.Value);
    }
    
    [Fact]
    public void AddAfterTest()
    {
        _list.AddAfter(_list.Head.Next, 5);
        Assert.Equal(5, _list.Head.Next.Next.Value);
    }

    [Fact]
    public void RemoveFirstTest()
    {
        _list.RemoveFirst();
        Assert.Equal(2, _list.Head.Value);
    }

    
}