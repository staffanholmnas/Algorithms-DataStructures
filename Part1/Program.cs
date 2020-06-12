using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            LuckyNumbers luck = new LuckyNumbers();
            Console.WriteLine(luck.Calculate(1, 10)); // 2
            Console.WriteLine(luck.Calculate(1, 10)); // 2
            Console.WriteLine(luck.Calculate(123, 321)); // 0
            Console.WriteLine(luck.Calculate(1, 1000000)); // 126

            Console.WriteLine(luck.Calculate(73350, 33373100)); // 222
            Console.WriteLine(luck.Calculate(36000, 733777)); // 64
            Console.WriteLine(luck.Calculate(3500, 700000)); // 76
            Console.WriteLine(luck.Calculate(75, 37737377)); // 357
            Console.WriteLine(luck.Calculate(0, 300000000)); // 510
        }
    }
}
