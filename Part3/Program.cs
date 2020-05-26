using System;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            SmallestDifference s = new SmallestDifference();
            Console.WriteLine(s.Calculate(new int[] { 4, 1, 8, 5 })); // 1
            Console.WriteLine(s.Calculate(new int[] { 1, 10, 100 })); // 9
            Console.WriteLine(s.Calculate(new int[] { 1, 1, 1, 1, 1 })); // 0
            Console.WriteLine(s.Calculate(Randomizer(10))); // depends on random
        }
        public static int[] Randomizer(int n)
        {
            Random random = new Random();
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                // Integers between 1 and 1000 are enough for us, 10000000 was used for exercise 3.
                arr[i] = random.Next(1, 10000001);
            }
            return arr;
        }
    }
}
