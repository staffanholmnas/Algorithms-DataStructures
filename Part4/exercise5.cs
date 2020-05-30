using System;

namespace Part4
{
    public class BinarySearchTree
    {
        public BNode root;

        public BinarySearchTree()
        {
            this.root = null;
        }
        // The results are saved in exercise5.md.
        // I had to google around a bit to help me learn to implement the code for 
        // some of these methods. I didn't want to use the Node class from previous exercises because I
        // wanted the variable names to be left and right instead of previous and next.
        public void Add(int x)
        {

            BNode newNode = new BNode();
            newNode.value = x;

            if (this.root == null)
            {
                this.root = newNode;
            }
            else
            {
                BNode current = this.root;
                BNode parent;
                while (true)
                {
                    parent = current;
                    if (x < current.value)
                    {
                        current = current.left;

                        if (current == null)
                        {
                            parent.left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.right;

                        if (current == null)
                        {
                            parent.right = newNode;
                            break;
                        }
                    }
                }
            }
        }

        // SearchNode is useful when I want to find the level or a position of a value. 
        // I used it for fixing bugs and help me understand the code. 
        public void SearchNode(int value)
        {
            BNode current = this.root;
            Search(current, value);
        }

        public BNode Search(BNode node, int value)
        {
            Console.WriteLine(node.value);
            if (node == null)
            {

                return null;
            }
            if (node.value == value)
            {
                return node;
            }
            if (value < node.value)
            {

                return Search(node.left, value);
            }
            else
            {
                return Search(node.right, value);
            }
        }

        public int Height()
        {
            BNode current = this.root;
            return HeightOfTree(current);

        }
        public int HeightOfTree(BNode node)
        {
            if (node == null)
            {
                return -1;
            }
            int left = HeightOfTree(node.left);
            int right = HeightOfTree(node.right);
            if (left > right)
            {
                return left + 1;
            }
            else
            {
                return right + 1;
            }
        }

        // I used printNodes for troubleshooting as well...
        public void printNodes()
        {
            BNode current = this.root;
            printAllNodes(current);

        }
        public void printAllNodes(BNode parent)
        {

            if (parent != null)
            {
                Console.WriteLine(parent.value);
                printAllNodes(parent.left);
                printAllNodes(parent.right);
            }
        }

        public class BNode
        {
            public int value;
            public BNode left;
            public BNode right;
        }
    }
}
