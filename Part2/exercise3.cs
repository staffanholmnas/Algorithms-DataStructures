namespace Part2
{
    public class Changes
    {
        public int Calculate(int[] t)
        {
            int sum = 0;

            for (int i = 1; i <= t.Length - 1; i++)
            {
                if (t[i] == t[i - 1])
                {
                    if (i < t.Length - 1)
                    {
                        t[i] = t[i - 1] + t[i + 1];
                        sum++;
                    }
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