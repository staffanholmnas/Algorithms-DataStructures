namespace Part2
{
    public class Split
    {
        public int Calculate(int[] t)
        {
            int splitSum = 0;
            int sumLeft = 0;
            int sumRight = 0;
            int[] subArray1 = new int[t.Length - 1];
            int[] subArray2 = new int[t.Length - 1];

            // Add sums on the left to subArray1.
            for (int i = 0; i <= t.Length - 1; i++)
            {
                if (i < subArray1.Length)
                {
                    sumLeft += t[i];
                    subArray1[i] = sumLeft;
                }
            }

            // Add sums on the right to subArray2.
            for (int i = t.Length - 1; i >= 0; i--)
            {
                sumRight += t[i];
                if (i > 0)
                {
                    subArray2[i - 1] = sumRight;
                }
            }

            // Check if the sums of both sub arrays are equal at the same index.
            for (int i = 0; i <= subArray1.Length - 1; i++)
            {
                if (subArray1[i] == subArray2[i])
                {
                    splitSum++;
                }
            }
            
            return splitSum;
        }
    }
}