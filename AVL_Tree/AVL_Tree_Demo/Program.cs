using System;

namespace AVLTreeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            RunApplication();
        }

        public static void RunApplication()
        {
            AVLTree avlTree = new AVLTree();
            avlTree.Insert(10);
            avlTree.Insert(5);
            avlTree.Insert(15);
            avlTree.Insert(3);
            avlTree.Insert(8);

            Console.WriteLine("AVL Tree root: " + avlTree.GetRoot());
        }
    }

    // AVL tree node definition
    public class AVLNode
    {
        public int Data;
        public AVLNode Left;
        public AVLNode Right;
        public int Height;

        public AVLNode(int data)
        {
            Data = data;
            Left = null;
            Right = null;
            Height = 1;
        }
    }

    // AVL tree implementation
    public class AVLTree
    {
        private AVLNode root;

        // Function to get the height of a node
        private int GetHeight(AVLNode node)
        {
            return node != null ? node.Height : 0;
        }

        // Function to update the height of a node
        private void UpdateHeight(AVLNode node)
        {
            if (node != null)
            {
                node.Height = Math.Max(GetHeight(node.Left), GetHeight(node.Right)) + 1;
            }
        }

        // Function to perform right rotation
        private AVLNode RotateRight(AVLNode y)
        {
            AVLNode x = y.Left;
            AVLNode T2 = x.Right;

            x.Right = y;
            y.Left = T2;

            UpdateHeight(y);
            UpdateHeight(x);

            return x;
        }

        // Function to perform left rotation
        private AVLNode RotateLeft(AVLNode x)
        {
            AVLNode y = x.Right;
            AVLNode T2 = y.Left;

            y.Left = x;
            x.Right = T2;

            UpdateHeight(x);
            UpdateHeight(y);

            return y;
        }

        // Function to get the balance factor of a node
        private int GetBalanceFactor(AVLNode node)
        {
            return node != null ? GetHeight(node.Left) - GetHeight(node.Right) : 0;
        }

        // Function to insert a node into the AVL tree
        public void Insert(int data)
        {
            root = Insert(root, data);
        }

        private AVLNode Insert(AVLNode node, int data)
        {
            // Perform standard BST insert
            if (node == null)
            {
                return new AVLNode(data);
            }

            if (data < node.Data)
            {
                node.Left = Insert(node.Left, data);
            }
            else if (data > node.Data)
            {
                node.Right = Insert(node.Right, data);
            }
            else
            {
                return node; // Duplicate nodes are not allowed
            }

            // Update height of the current node
            UpdateHeight(node);

            // Get the balance factor to check if the node became unbalanced
            int balance = GetBalanceFactor(node);

            // Left Left Case
            if (balance > 1 && data < node.Left.Data)
            {
                return RotateRight(node);
            }

            // Right Right Case
            if (balance < -1 && data > node.Right.Data)
            {
                return RotateLeft(node);
            }

            // Left Right Case
            if (balance > 1 && data > node.Left.Data)
            {
                node.Left = RotateLeft(node.Left);
                return RotateRight(node);
            }

            // Right Left Case
            if (balance < -1 && data < node.Right.Data)
            {
                node.Right = RotateRight(node.Right);
                return RotateLeft(node);
            }

            return node;
        }

        // Example method to get the root of the AVL tree
        public int GetRoot()
        {
            return root != null ? root.Data : -1; // Return -1 if tree is empty
        }
    }
}
