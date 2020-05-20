using System;

namespace Part3
{
    public class Sorting
    {
        public void MergeSort(int[] t)
        {
            DateTime start = DateTime.Now;

            foreach (var item in t)
            {
                Console.WriteLine(item);
            }

            SortM(t);

            foreach (var item in t)
            {
                Console.WriteLine(item);
            }

            DateTime end = DateTime.Now;
            Console.WriteLine("Time this took: " + end.Subtract(start));
        }

        public void QuickSort(int[] t)
        {
            DateTime start = DateTime.Now;

            foreach (var item in t)
            {
                Console.WriteLine(item);
            }


            DateTime end = DateTime.Now;
            Console.WriteLine("Time this took: " + end.Subtract(start));
        }

        public void SortM(int[] t)
        {
            int a = 0;
            int b = t.Length - 1;
            int k = (a + b) / 2;
            int[] array1 = new int[k];
            int[] array2 = new int[t.Length - k];
            
            if (t.Length == 1)
            {
                return;
            }

            for (int i = 0; i <= t.Length - 1; i++)
            {
                if (i <= k)
                {
                    array1[i] = t[i];
                }
                else
                {
                    array2[i] = t[i];
                }
            }

            SortM(array1);
            SortM(array2);
            
            Merge(array1,array2);
        }

        public int[] Merge(int[] a, int[] b)
        {
            int[] c = new int[a.Length + b.Length];

            
            return c;
        }
    }
}