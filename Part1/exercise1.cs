using System.Linq;

namespace Part1
{
    public class Numbers
    {
        public int Sum(int x)
        {
            
            // For smaller numbers, this could be done using only variables. Pseudocode below:
            
            // sumOfHundreds = x / 100
            // remainderOfHundreds = x % 100
            // sumOfTens = remainderOfHundreds / 10
            // sumOfOnes = remainderOfHundreds % 10
            // total = sumOfHundreds + sumOfTens + sumOfOnes

            // For n < 1 billion, this loop does the same: 

            int sum = 0;
            int n = 1000000000;
            
            for (int i = 0; n >= 1; i++)
            {
                sum += x / n;
                x = x % n;
                n /= 10;
            }
            
            return sum;
        }
    }
}