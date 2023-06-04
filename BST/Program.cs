

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

BSTree<int>.InOrder(bst.Root); // 7 15 18 25 78 86 90
Console.WriteLine("-----InOrder Recursive"); 
BSTree<int>.InOrderTraversal(bst.Root) // 7 15 18 25 78 86 90
    .ForEach(item => Console.Write(item + "  "));
Console.WriteLine("-----InOrder Iterative");
BSTree<int>.PreOrder(bst.Root); // 25 15 7 18 78 90 86
Console.WriteLine("-----PreOrder Recursive");
BSTree<int>.PreOrderIterative(bst.Root);// 25 15 7 18 78 90 86
Console.WriteLine("-----PreOrder Iterative");
BSTree<int>.Leaf(bst.Root); // 7 18 86
Console.WriteLine("-----Leaf");