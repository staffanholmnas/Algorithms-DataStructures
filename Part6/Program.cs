using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            ShortestPath s = new ShortestPath(5);
            s.AddRoad(1, 2, 7);
            s.AddRoad(2, 4, 2);
            s.AddRoad(1, 3, 6);
            s.AddRoad(3, 4, 5);
            s.AddRoad(4, 5, 3);
            Console.WriteLine(s.Calculate(1, 5)); // 12
        }
    }
}
