using System;

namespace Part5
{
    class Program
    {
        static void Main(string[] args)
        {
            Connectivity c = new Connectivity(6);
            c.AddConnection(1, 2);
            c.AddConnection(2, 3);
            c.AddConnection(1, 3);
            c.AddConnection(3, 4);
            c.AddConnection(5, 6);
            Console.WriteLine(c.Calculate(1)); // 3
        }
    }
}
