using System;

namespace Exam_prep
{
    class Program
    {
        static void Main(string[] args)
        {
            ShortenArray s = new ShortenArray();
            int[] array1 = { 1, 2, 2, 1, 1, 1, 3 };
            int[] array2 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] array3 = { 1, 1, 1, 1, 2, 2, 2, 2 };
            int[] array4 = { 1, 2, 3, 4, 4, 3, 2, 1 };
            int[] array5 = { 1, 2, 1, 1, 2, 2, 1, 1, 2, 2, 1 };
            int[] array6 = { 2, 1, 1, 3 };
            Console.WriteLine(s.Calculate(array1)); // 1
            Console.WriteLine(s.Calculate(array2)); // 8
            Console.WriteLine(s.Calculate(array3)); // 0
            Console.WriteLine(s.Calculate(array4)); // 0
            Console.WriteLine(s.Calculate(array5)); // 3
            Console.WriteLine(s.Calculate(array6)); // 2
        }
    }
}
