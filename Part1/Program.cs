using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Substrings subs = new Substrings();
            subs.Calculate("aybabtu", "bab"); // 1
            subs.Calculate("aaaaa", "aa"); // 4
            subs.Calculate("monkey", "banana"); // 0
        }
    }
}
