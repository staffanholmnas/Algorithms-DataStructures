namespace Part2
{
    using System;
    using System.Text;
    public class algoCompare
    {
        /*  // Copy paste this into main program:

            algoCompare finder = new algoCompare();

            string randomNumber = finder.CreateInput(10);

            Console.WriteLine(finder.algo1(randomNumber));
            Console.WriteLine(finder.algo2(randomNumber));*/
        public int algo1(string a)
        {
            // Time efficiency O(n^2)

            DateTime start = DateTime.Now;

            int sum = 0;
            
            for (int i = 0; i <= a.Length -1; i++)
            {
                for (int j = i + 1; j <= a.Length - 1; j++)
                {
                    if (a[i].ToString() == "0" && a[j].ToString() == "1")
                    {
                        sum += 1;
                    }
                }
            }

            DateTime end = DateTime.Now;
            Console.WriteLine("Time this took: " + end.Subtract(start));
            Console.WriteLine("Time elapsed: " + (end.Ticks - start.Ticks) / 10000.0 + " milliseconds");
            return sum;
        }

        public int algo2(string a)
        {
            // Time efficiency O(n)

            DateTime start = DateTime.Now;

            int sum = 0;
            int zeros = 0;

            for (int i = 0; i <= a.Length - 1; i++)
            {
                if (a[i].ToString() == "0")
                {
                    zeros++;
                }
                else
                {
                    sum += zeros;
                }
            }

            DateTime end = DateTime.Now;
            Console.WriteLine("Time this took: " + end.Subtract(start));
            Console.WriteLine("Time elapsed: " + (end.Ticks - start.Ticks) / 10000.0 + " milliseconds");
            return sum;
        }
        public string CreateInput(int n)
        {

            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                sb.Append(random.Next(0, 2).ToString());
            }
            return sb.ToString();
        }
    }
}