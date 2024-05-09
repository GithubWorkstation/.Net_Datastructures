using System;
using System.Collections.Generic;

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


            Console.Write("In-order traversal: ");
            foreach (var item in tree.InOrderTraversal())
            {
                Console.Write(item + " ");
            }
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
            Node newNode = new Node(data);

            if (root == null)
            {
                root = newNode;
            }
            else

            {
                InsertNode(root, newNode);
            }
        }

        private void InsertNode(Node node, Node newNode)
        {
            if (newNode.Data < node.Data)
            {
                if (node.Left == null)
                {
                    node.Left = newNode;
                }
                else
                {
                    InsertNode(node.Left, newNode);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = newNode;
                }
                else
                {
                    InsertNode(node.Right, newNode);
                }
            }
        }

        // Function to perform an in-order traversal of the binary tree
        public List<int> InOrderTraversal()
        {
            List<int> result = new List<int>();
            InOrderTraversal(root, result);
            return result;
        }

        private void InOrderTraversal(Node node, List<int> result)
        {
            if (node != null)
            {

                InOrderTraversal(node.Left, result);
                result.Add(node.Data);
                InOrderTraversal(node.Right, result);
            }
        }
    }
}
