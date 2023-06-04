// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

var list = new List<int>() { 25, 15, 78,7,18,90,86 };
var bst = new BSTree<int>();
foreach (var item in list)
{
    bst.Add(item);
}
Console.WriteLine(bst.Root.Item);
Console.WriteLine(bst.Root.Left.Item);
Console.WriteLine(bst.Root.Left.Left.Item);
Console.WriteLine(bst.Root.Left.Right.Item);
Console.WriteLine(bst.Root.Right.Item);
Console.WriteLine(bst.Root.Right.Right.Item);
Console.WriteLine(bst.Root.Right.Right.Left.Item);

/*
        (25)
       /   \
    (15)   (78)
    /  \     \
  (7) (18)   (90)
             /
           (86) 
 */