using System;

namespace Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            SmallestDistance s = new SmallestDistance();
            s.Add(3);
            s.Add(8);
            Console.WriteLine(s.Calculate()); // 5
            s.Add(20);
            Console.WriteLine(s.Calculate()); // 5
            s.Add(9);
            Console.WriteLine(s.Calculate()); // 1
        }
    }
}
