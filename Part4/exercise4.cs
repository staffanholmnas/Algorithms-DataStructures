using System;

namespace Part4
{
    public class Order
    {
        // Due to time constraints, I got help from the internet (quite reluctantly).
        // I modified code I found on geeksforgeeks.com, originally contributed by 29AjayKumar.
        // This code implements recursion to print the post-order.
        public void Create(int[] a, int[] b)
        {
            printPostOrder(b, a, b.Length);
        }
        
        public void printPostOrder(int[] inO, int[] pre, int n)
        {
            // The left and right subtrees can be found by searching for the root in inO[],
            // which always is the first value of pre[]. So pre[0].
            int root = search(inO, pre[0], n);

            // Print the left subtree recursively.  
            int[] ar;
            if (root != 0)
            {
                ar = new int[n - 1];
                Array.Copy(pre, 1, ar, 0, n - 1); // Copies the array to another array.
                printPostOrder(inO, ar, root);
            }

            // Print the right subtree recursively.  
            if (root != n - 1)
            {
                ar = new int[n - (root + 1)];
                Array.Copy(inO, root + 1, ar, 0, n - (root + 1));
                int[] ar1 = new int[n - (root + 1)];
                Array.Copy(pre, root + 1, ar1, 0, n - (root + 1));
                printPostOrder(ar, ar1, n - root - 1);
            }

            // Print the root.  
            Console.Write(pre[0] + " ");
        }
        public int search(int[] a, int x, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (a[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
