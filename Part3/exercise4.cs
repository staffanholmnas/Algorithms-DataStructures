using System;

namespace Part3
{
    public class BinarySearch
    {
        public bool Find(int[] t, int x)
        {
            Array.Sort(t);
        
            int a = 0;
            int b = t.Length - 1;
            
            while (a <= b)
            {
                int k = ((a + b) / 2);
                if (t[k] == x)
                {
                   return true;
                }
                if (t[k] < x)
                {
                    a = k + 1;
                }
                if (t[k] > x)
                {
                    b = k - 1;
                }
            }
            return false;
        }
    }
}