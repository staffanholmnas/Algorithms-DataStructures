using System;

namespace Exam_prep
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers num = new Numbers();
            Console.WriteLine(num.Steps(11)); // 5
            Console.WriteLine(num.Steps(15)); // 5
            Console.WriteLine(num.Steps(2)); // 2
        }
    }
}
