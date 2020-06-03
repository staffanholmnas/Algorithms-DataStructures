using System;

namespace Part5
{
    class Program
    {
        static void Main(string[] args)
        {
            Communication com = new Communication(6);
            com.AddConnection(1, 2);
            com.AddConnection(2, 3);
            com.AddConnection(1, 3);
            com.AddConnection(3, 4);
            com.AddConnection(5, 6);
            Console.WriteLine(com.Examine(1, 4)); // true
            Console.WriteLine(com.Examine(2, 5)); // false
            Console.WriteLine(com.Examine(5, 6)); // true
        }
    }
}
