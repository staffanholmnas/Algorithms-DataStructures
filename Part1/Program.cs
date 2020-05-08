using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tables t = new Tables();
            Console.WriteLine(t.Calculate(new int[] { 1, 2, 3, 2 })); // 18
            Console.WriteLine(t.Calculate(new int[] { 5 })); // 5
            Console.WriteLine(t.Calculate(new int[] { 4, 2, 9, 1, 9, 2, 5 })); // 323
        }
    }
}
