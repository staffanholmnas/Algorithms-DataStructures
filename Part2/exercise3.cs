namespace Part2
{
    public class Changes
    {
        public int Calculate(int[] t)
        {
            int sum = 0;

            for (int i = 1; i <= t.Length - 1; i++)
            {
                // If a number is the same as the one before it...
                if (t[i] == t[i - 1])
                {
                    // ...add the adjacent numbers together. Add 1 to sum.
                    if (i < t.Length - 1)
                    {
                        t[i] = t[i - 1] + t[i + 1];
                        sum++;
                    }
                    // Unless it's the last integer, then add only the previous one. Add 1 to sum.
                    else
                    {
                        t[i] = t[i - 1] + t[i];
                        sum++;
                    }
                }
            }

            return sum;
        }
    }
}