using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Split s = new Split();
            Console.WriteLine(s.Calculate(new int[] { 1, 2, -1, 4, 0 })); // 1
            Console.WriteLine(s.Calculate(new int[] { 1, 2, 3, 4, 5 })); // 0
            Console.WriteLine(s.Calculate(new int[] { 0, 0, 0, 0, 0 })); // 4
        }
    }
}
