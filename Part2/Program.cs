﻿using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Changes m = new Changes();
            Console.WriteLine(m.Calculate(new int[] { 1, 1, 2, 2, 2 })); // 2
            Console.WriteLine(m.Calculate(new int[] { 1, 2, 3, 4, 5 })); // 0
            Console.WriteLine(m.Calculate(new int[] { 1, 1, 1, 1, 1 })); // 2
            Console.WriteLine(m.Calculate(new int[] { 0, 0, 0, 0, 0 })); // 2
        }
    }
}
