using System;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            Inversions inv = new Inversions();
            int[] t = inv.Create(4, 6);
            foreach (int i in t)
            {
                Console.Write(i + " ");  // 2 1 3 5 4
            }
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
