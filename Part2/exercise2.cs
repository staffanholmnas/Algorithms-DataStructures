namespace Part2
{
    public class LongestRepetition
    {
        public int Calculate(int[] t)
        {
            int sum = 1;
            int number = 1;

            for (int i = 1; i <= t.Length - 1; i++)
            {
                if (t[i] == t[i - number])
                {

                    number++;
                    sum += 1;
                }
            }
            return sum;
        }
    }
}