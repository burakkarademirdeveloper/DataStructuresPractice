// See https://aka.ms/new-console-template for more information

using StackClassLibrary;

Console.WriteLine("Hello, World!");

string message = "Hi Github!";
var stack = new StackClassLibrary.ArrayStack<char>();
for(int i = 0; i < message.Length; i++)
{
    stack.Push(message[i]);
}

var a = stack.Count;
for(int i=0 ; i < a; i++)
{
    Console.WriteLine(stack.Pop());
}