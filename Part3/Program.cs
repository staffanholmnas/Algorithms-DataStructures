using System;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Sorting s = new Sorting();
            int[] sortMe = Randomizer(4);
            int[] sortMeLarge = Randomizer(1000000);
            int[] example = new int[] {5,1,2,9};
            s.QuickSort(example);
          //  s.MergeSort(example);
          //  s.QuickSort(sortMeLarge);
          //  s.MergeSort(sortMeLarge);*/
            BinarySearch b = new BinarySearch();
            int[] example = new int[] { 4, 1, 8, 5 };
            Console.WriteLine(b.Find(new int[] { 4, 1, 8, 5 }, 2)); // false
            Console.WriteLine(b.Find(new int[] { 0, 0 }, 0)); // true
            Console.WriteLine(b.Find(new int[] { 4, 1, 8, 5, 8, 7, 4, 2, 3 }, 2)); // true
            Console.WriteLine(b.Find(new int[] { 0 }, 0)); // true
            Console.WriteLine(b.Find(Randomizer(100000), 3)); // ?

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
