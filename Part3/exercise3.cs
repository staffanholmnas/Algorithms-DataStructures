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
            
            Console.WriteLine("---");
            SortQ(t);
            Console.WriteLine("---");
            foreach (var item in t)
            {
                Console.WriteLine(item);
            }

            DateTime end = DateTime.Now;
            Console.WriteLine("Time this took: " + end.Subtract(start));
        }

        public int[] SortM(int[] t)
        {
            int a = 0;
            int b = t.Length;
            int k = (a + b) / 2;
            int[] array1 = new int[k];
            int[] array2 = new int[b - k];

            if (t.Length == 1)
            {
                
                return t;
            }

            for (int i = 0; i <= t.Length - 1; i++)
            {
                if (i < k)
                {
                    array1[i] = t[i];
                }
                else
                {
                    array2[i - k] = t[i];
                }
            }
           
            SortM(array1);
            SortM(array2);
    
           return Merge(array1, array2);
         
            
        }

        public int[] Merge(int[] a, int[] b)
        {
            Console.WriteLine("---");
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("///");
            foreach (var item in b)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("+++");
            int[] c = new int[a.Length + b.Length];
            for (int i = 0; i <= a.Length - 1; i++)
            {
                if (a[i] <= b[i])
                {
                    c[i] = a[i];
                    c[i + 1] = b[i];
                }
                else
                {
                    c[i] = b[i];
                    c[i + 1] = a[i];
                }
               
            }
             foreach (var item in c)
                {
                    Console.WriteLine(item);
                }

            return c;
        }

        public int[] SortQ(int[] t)
        {
            if (t[0] >= t[t.Length - 1])
            {
                return t;
            }
            int k = Pivot(t);
            int[] a = new int [k];
            int[] b = new int [t.Length - k];
            SortQ(a);
            SortQ(b);

            return t;
        }
        public int Pivot(int[] t)
        {
            int k = 0;
            return k;
        }
    }
}

/*
            int j = 0;
            int k = 0;
            int[] c = new int[a.Length + b.Length];
            int[] helper = new int[a.Length + b.Length];
            for (int i = 0; i <= c.Length - 1; i++)
            {
                if (b[0] > b[b.Length - 1] || ((a[0]) <= a[a.Length - 1]) && (c[a[0]] <= c[b[0]]))
                {
                    helper[i] = a[j];
                    j++;
                }
                else
                {
                    helper[i] = b[k];
                    k++;
                }
            }
            for (int i = 0; i <= c.Length - 1; i++)
            {
                c[i] = helper[i];
            }
*/
