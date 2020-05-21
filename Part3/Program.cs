using System;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorting s = new Sorting();
            int[] sortMe = Randomizer(4);
            int[] sortMeLarge = Randomizer(1000000);
            int[] example = new int[] {5,1,2,9};
            s.QuickSort(example);
          //  s.MergeSort(example);
          //  s.QuickSort(sortMeLarge);
          //  s.MergeSort(sortMeLarge);
        }
        public static int[] Randomizer(int n)
        {
            Random random = new Random();
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                // integers between 1 and 1000 are enough for us
                arr[i] = random.Next(1, 1001);
            }
            return arr;
        }
    }
}
