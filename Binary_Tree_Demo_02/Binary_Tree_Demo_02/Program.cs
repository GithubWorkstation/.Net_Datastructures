using System;

namespace BinaryTreeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            RunApplication();
        }

        public static void RunApplication()
        {
            BinaryTree tree = new BinaryTree();
            tree.Insert(10);
            tree.Insert(5);
            tree.Insert(15);
            tree.Insert(3);
            tree.Insert(8);

            Console.WriteLine("Searching for 15: " + tree.Search(15));


            Console.WriteLine("Minimum value: " + tree.FindMin());
        }
    }

    // Binary tree node definition
    public class Node
    {
        public int Data;
        public Node Left;
        public Node Right;

        public Node(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }

    // Binary tree implementation
    public class BinaryTree
    {
        private Node root;

        public BinaryTree()
        {
            root = null;
        }

        // Function to insert a node into the binary tree
        public void Insert(int data)
        {
            root = Insert(root, data);
        }

        private Node Insert(Node node, int data)
        {
            if (node == null)
            {
                return new Node(data);
            }
            if (data < node.Data)
            {

                node.Left = Insert(node.Left, data);

            }
            else if (data > node.Data)
            {
                node.Right = Insert(node.Right, data);
            }
            return node;
        }

        // Function to search for a node in the binary tree
        public bool Search(int data)
        {
            return Search(root, data);
        }

        private bool Search(Node node, int data)
        {
            if (node == null)
            {
                return false;
            }
            if (data == node.Data)
            {
                return true;
            }
            else if (data < node.Data)
            {
                return Search(node.Left, data);
            }
            else
            {
                return Search(node.Right, data);
            }
        }

        // Function to find the minimum value in the binary tree
        public int? FindMin()
        {
            return FindMin(root);
        }

        private int? FindMin(Node node)

        {
            if (node == null)
            {

                return null;
            }

            while (node.Left != null)
            {
                node = node.Left;
            }
            return node.Data;
        }
    }
}
