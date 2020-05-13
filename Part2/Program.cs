using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            algoCompare finder = new algoCompare();

            string randomNumber = finder.CreateInput(10);

            Console.WriteLine(finder.algo1(randomNumber));
            Console.WriteLine(finder.algo2(randomNumber));
        }
        
    }
}
