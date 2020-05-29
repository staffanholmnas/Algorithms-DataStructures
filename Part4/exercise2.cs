using System;

namespace Part4
{
    public class CircleGame
    {
        public int Last(int n)
        { 
            double power = 0;
            int sum = 1;

            for (int i = 2; i <= n; i *= 2)
            {
                power++;
            }

            power = Math.Pow(2, power);
          
            for (int i = (int)power; i < n; i++)
            {
                sum += 2;
            }
          
            return sum;
        }
    }
}