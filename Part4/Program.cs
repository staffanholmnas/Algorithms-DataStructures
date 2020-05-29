using System;

namespace Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            CircleGame g = new CircleGame();
            Console.WriteLine(g.Last(7)); // 7
            Console.WriteLine(g.Last(4)); // 1
            Console.WriteLine(g.Last(123)); // 119
        }
    }
}
