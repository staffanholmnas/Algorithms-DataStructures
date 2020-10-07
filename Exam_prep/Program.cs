using System;

namespace Exam_prep
{
    class Program
    {
        static void Main(string[] args)
        {
            Rooms r = new Rooms();
            int[,] house = {
            {1,1,1,1,1,1,1,1},
            {1,0,1,0,1,0,0,1},
            {1,1,1,0,1,0,1,1},
            {1,0,1,0,1,0,0,1},
            {1,1,1,1,1,1,1,1},
            };
            Console.WriteLine(r.Calculate(house)); // 4
        }
    }
}
