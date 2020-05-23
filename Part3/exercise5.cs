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
            int maxInversions = Sum(n - 1); // Example: max inversions for n = 4 is 3 + 2 + 1 = 6.

            for (int i = 0; i <= a.Length - 1; i++)
            {
                a[i] = i + 1;
            }

            if (k <= 0)
            {
                return a;
            }

            if (k >= maxInversions)
            {
                Console.WriteLine("Max number of inversions for n = " + n + " is " + maxInversions);
                GetInversions(a, maxInversions);
                return a;
            }

            else
            {
                GetInversions(a, k);
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
        public int[] GetInversions(int[] a, int k)
        {
            int indexReducer = 2;
            int index = 0;
            int inversions = 0;

            while (inversions <= k - 1)
            {
                Swapper(a, index);

                // When the end is reached the index is reset and lenght is reduced, so next time loop one number less.
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
}