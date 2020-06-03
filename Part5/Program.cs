using System;

namespace Part5
{
    class Program
    {
        static void Main(string[] args)
        {
            Components k = new Components(6);
            k.AddConnection(1, 2);
            k.AddConnection(2, 3);
            k.AddConnection(1, 3);
            k.AddConnection(3, 4);
            k.AddConnection(5, 6);
            Console.WriteLine(k.Calculate()); // 2
        }
    }
}
