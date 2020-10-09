using System;

namespace Exam_prep
{
    class Program
    {
        static void Main(string[] args)
        {
            Flights f = new Flights();
            f.AddConnection("helsinki", "tampere", 100);
            f.AddConnection("tampere", "oulu", 100);
            f.AddConnection("oulu", "vaasa", 100);
            f.AddConnection("helsinki", "turku", 500);
            f.AddConnection("turku", "vaasa", 700);
            Console.WriteLine(f.RoutePrice("helsinki", "vaasa")); // 1200
        }
    }
}
