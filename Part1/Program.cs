using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();
            Console.WriteLine(numbers.Sum(4075));
            Console.WriteLine(numbers.Sum(3));
            Console.WriteLine(numbers.Sum(999999999));
        }
    }
}
