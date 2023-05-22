// See https://aka.ms/new-console-template for more information

var _queue = new Queue<ToDo>();

_queue.Enqueue(new ToDo()
{
    Time = 4.00,
    Describe = "Okula git."
});

_queue.Enqueue(new ToDo()
{
    Time = 2.00,
    Describe = "Unity çalış."
});

foreach (var item in _queue)
{
    Console.WriteLine(item);
}
Console.WriteLine("----------------------------------------------");

var result = _queue.Dequeue();
Console.WriteLine(result + " Tamamlandı.");

foreach (var item in _queue)
{
    Console.WriteLine(item);
}