using System;

namespace Part3
{
    public class SmallestDifference
    {
        public int Calculate(int[] t)
        {
            
            // Sorts the array with an Insertion sort algorithm. 
            InsertionSort(t);

            int smallestDiff = 10000001, diff = 0;

            if (t.Length == 1)
            {
                return 0;
            }
            for (int i = 0; i < t.Length - 1; i++)
            {
                diff = t[i + 1] - t[i];

                if (diff < smallestDiff)
                {
                    smallestDiff = diff;
                }
            }
            return smallestDiff;
        }

        public int[] InsertionSort(int[] t)
        {
            int swapper = 0;
            for (int i = 1; i <= t.Length - 1; i++)
            {
                int j = i - 1;
                while (j >= 0 && t[j] > t[j + 1])
                {
                    // swap(array[j], array[j+1])
                    swapper = t[j];
                    t[j] = t[j + 1];
                    t[j + 1] = swapper;
                    j -= 1;
                }
            }
            return t;
        }
    }
}