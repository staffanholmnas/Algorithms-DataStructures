using System;

namespace Part3
{
    public class BinarySearch
    {
        public bool Find(int[] t, int x)
        {
            Array.Sort(t);
            int k = (t.Length / 2);

            while (true)
            {
                if (t[k] == x)
                {
                    return true;
                }
                
            }

            
        }
    }
}