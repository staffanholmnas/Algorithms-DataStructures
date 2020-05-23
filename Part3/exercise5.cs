using System;

namespace Part3
{
    public class Inversions
    {
        public int[] Create(int n, int k)
        {
            if (n <= 0)
            {
                int[] b = new int[0];
                return b;
            }
            
            int[] a = new int[n];

            for (int i = 0; i <= a.Length - 1; i++)
            {
                a[i] = i + 1;
            }
            if (k <= 0)
            {
                return a;
            }
            if (k >= Sum(n - 1))
            {
                Console.WriteLine("Max number of inversions for n = " + n + " is " + Sum(n - 1));
                Array.Reverse(a);
                return a;
            }
            else
            {
                int indexReducer = 2;
                int index = 0;
                int inversions = 0;

                while (inversions <= k - 1)
                {
                    Swapper(a, index);
                    if (index == a.Length - indexReducer)
                    {
                        index = -1;
                        indexReducer++;
                    }

                    index++;
                    inversions++;
                }
                return a;
            }
        }

        public int Sum(int n)
        {
            if (n == 0) return 0;
            else return Sum(n - 1) + n;
        }
        public int[] Swapper(int[] a, int j)
        {
            int swapper = a[j];
            a[j] = a[j + 1];
            a[j + 1] = swapper;
            return a;
        }
    }
}