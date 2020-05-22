using System;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearch b = new BinarySearch();
            Console.WriteLine(b.Find(new int[] { 4, 1, 8, 5 }, 2)); // false
            Console.WriteLine(b.Find(new int[] { 0, 0 }, 0)); // true
            Console.WriteLine(b.Find(new int[] { 4, 1, 8, 5, 8, 7, 4, 2, 3 }, 2)); // true
            Console.WriteLine(b.Find(new int[] { 0 }, 0)); // true
            Console.WriteLine(b.Find(Randomizer(100000), 3)); // Most likely true
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
