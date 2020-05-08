namespace Part1
{
    public class Tables
    {
        public int Calculate(int[] t)
        {
            if (t.Length == 1)
            {
                return t[0];
            }

            int[] a = new int[t.Length - 1];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = t[i] + t[i + 1];
            }

            return Calculate(a); // recursion
        }
    }
}