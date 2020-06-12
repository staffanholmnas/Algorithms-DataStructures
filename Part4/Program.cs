using System;
using System.Collections.Generic;

namespace Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bs = new BinarySearchTree();
            bs.Add(5); // Becomes your root
            bs.Add(4); // Goes to the left
            bs.Add(6); // Goes to the right
            Console.WriteLine(bs.Height()); // 1
            bs.Add(3);
            bs.Add(1);
            bs.Add(7);
            Console.WriteLine(bs.Height()); // 3
        }
        static void RandomNodes(BinarySearchTree tree)
        {
            // Quite efficient up to 100000
            int hundrerThousand = 100000;
            Random random = new Random();
            List<int> nodeList = new List<int>();
            // Add all the numbers to the nodelist
            for (int i = 1; i < hundrerThousand + 1; i++)
            {
                nodeList.Add(i);
            }
            // Add them to the tree in random order
            while (nodeList.Count > 1)
            {
                // All the numbers left at the list
                int remove = random.Next(1, nodeList.Count);
                // Add from the index "remove"
                tree.Add(nodeList[remove]);
                // remove the number from index "remove"
                nodeList.RemoveAt(remove);
            }
            // Add the last one, remove from the list
            tree.Add(nodeList[0]);
            nodeList.RemoveAt(0);
        }
    }
}
