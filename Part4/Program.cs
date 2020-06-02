using System;
using System.Collections.Generic;

namespace Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            Order o = new Order();
            int[] a = { 4, 2, 1, 3, 5 };
            int[] b = { 2, 4, 3, 1, 5 };
            o.Create(a, b); // 2 3 5 1 4
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
