using Queue;

namespace QueueTest;

public class UnitTest1
{
    [Fact]
    public void QueueTest1()
    {
        var queue = new ArrayQueue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Dequeue();
        Assert.Equal(2,queue.Count);
        
    }
}