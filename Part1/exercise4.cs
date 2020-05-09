namespace Part1
{
    using System;
    public class LuckyNumbers
    {
        public int Calculate(int a, int b)
        {
            Console.WriteLine("---------------");
            int sum = 0;
            int sum2 = 0;
            int total = 0;

            for (int i = 1; i < a; i *= 10)
            {
                sum =  2 + sum * 2; 
                Console.WriteLine (sum);
            }    
            Console.WriteLine("---------------");
            for (int i = 1; i < b; i *= 10)
            {
                sum2 =  2 + sum2 * 2; 
                Console.WriteLine (sum2);
            }    

            total = sum2 - sum;
            Console.WriteLine("---------------");
            return total;
            
        }
    }
}


/*  if (b >= 10)
            {
                sum += 2;
            }
            if (b >= 100)
            {
                sum += 4;
            }
            if (b >= 1000)
            {
                sum += 8;
            }
            if (b >= 10000)
            {
                sum += 16;
            }  */

          /*  int index = 1;
            while (index <= b)
            {
                sum2 *= 2; 
                index *= 10;
            }*/
            
//sum2 = 2 + sum2 * 2; 
