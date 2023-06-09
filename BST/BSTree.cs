﻿public class BSTree<T> where T: IComparable
{
    public Node<T> Root;

    public BSTree()
    {
        Root = null;
    }

    public BSTree(Node<T> node)
    {
        Root = node;
    }

    public void Add(T item)
    {
        var newNode = new Node<T>() { Item = item };
        if (Root == null)
        {
            Root = newNode;
        }
        else
        {
            var current = Root;
            Node<T> parent;
            while (true)
            {
                parent = current;
                if (item.CompareTo(current.Item) < 0)
                {
                    current = current.Left;
                    if (current == null)
                    {
                        parent.Left = newNode;
                        break;
                    }
                }
                else
                {
                    current = current.Right;
                    if (current == null)
                    {
                        parent.Right = newNode;
                        break;
                    }
                }
            }
        }
    }
    public static void InOrder(Node<T> root)
    {
        if (root != null)
        {
            InOrder(root.Left);
            root.Display();
            InOrder(root.Right);
        }
    }
    public static List<T> InOrderTraversal(Node<T> root)
    {
        List<T> res = new List<T>();
        var s = new Stack<Node<T>>();
        Node<T> currentNode = root;
        bool done = false;
        while (!done)
        {
            if (currentNode != null)
            {
                s.Push(currentNode);
                currentNode = currentNode.Left;
            }
            else
            {
                if (s.Count == 0)
                {
                    done = true;
                }
                else
                {
                    currentNode = s.Pop();
                    res.Add(currentNode.Item);
                    currentNode = currentNode.Right;
                }
            }
        }
        return res;
    }

    public static void PreOrder(Node<T> root)
    {
        //Düğüm - Left- Right
        if (root != null)
        {
            root.Display();
            PreOrder(root.Left);
            PreOrder(root.Right);
        }
    }
    public static void PreOrderIterative(Node<T> root)
    {
        if (root == null)
        {
            return;
        }
        var s = new Stack<Node<T>>();
        s.Push(root);
        while (s.Count > 0)
        {
            var current = s.Pop();
            current.Display();
            if (current.Right != null)
            {
                s.Push(current.Right);
            }
            if (current.Left != null)
            {
                s.Push(current.Left);
            }
        }
    }

    public static void Leaf(Node<T> root)
    {
        if (root != null)
        {
            if (root.Left == null && root.Right == null)
            {
                root.Display();
            }
            Leaf(root.Left);
            Leaf(root.Right);
        }
    }
}