using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Substrings subs = new Substrings();
            Console.WriteLine(subs.Calculate("aybabtu", "bab")); // 1
            Console.WriteLine(subs.Calculate("aaaaa", "aa")); // 4
            Console.WriteLine(subs.Calculate("monkey", "banana")); // 0
        }
    }
}
