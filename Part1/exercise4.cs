namespace Part1
{
    using System;
    public class LuckyNumbers
    {
        public int Calculate(int a, int b)
        {
            DateTime start = DateTime.Now;

            Console.WriteLine("------------------------------");

            int sumA = 0;
            int sumB = 0;
            int total = 0;

            if (a <= 7)
            {
                sumA = CheckInterval(0, a);
            }
            else
            {
                sumA = GetAlgo(a);
            }
            if (b <= 7)
            {
                sumB = CheckInterval(0, b);
            }
            else
            {
                sumB = GetAlgo(b);
            }

            sumB = GetNarrowInterval(b, sumB);

            sumA = GetNarrowInterval(a, sumA);

            total = sumB - sumA;

            DateTime end = DateTime.Now;
            Console.WriteLine("Time elapsed: " + (end.Ticks - start.Ticks) / 10000.0 + " milliseconds");

            return total;

        }
        public static int GetAlgo(int a)
        {
            // Used to quikly calculate lucky numbers. For example: numbers outside of 33...33 and 77...77,
            // or numbers between 37...7 and 73...3.

            int sum = 0;
            for (int i = 10; i <= a; i *= 10)
            {
                sum = 2 + sum * 2;
            }
            return sum;
        }
        public static int CheckInterval(int a, int b)
        {
            // Used for iterating through numbers in small intervals e.g. 7773, 7777.
            // Not used for larger series, because it is VERY slow.

            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                if (!i.ToString().Contains(1.ToString()) && !i.ToString().Contains(2.ToString()) &&
                !i.ToString().Contains(4.ToString()) && !i.ToString().Contains(5.ToString())
                && !i.ToString().Contains(6.ToString()) && !i.ToString().Contains(8.ToString())
                && !i.ToString().Contains(9.ToString()) && !i.ToString().Contains(0.ToString()))
                {
                    sum++;
                }
            }
            return sum;
        }
        public static int GetBaseNumber(int a)
        {
            int sum = 1;
            for (int i = 10; i <= a; i *= 10)
            {
                sum *= 10;
            }
            return sum;
        }

        public static int GetNarrowInterval(int c, int sumC)
        {
            // Creates narrow intervals so that the algorithm above can be used for most numbers.
            
            int number = GetBaseNumber(c);

            double number1 = 0;
            double number2 = 0;
            int number3 = 0;

            number1 = number * ((double)10 / 3);
            number1 = Convert.ToInt32(number1); // Creates lower bound, e.g. 33333
            number2 = number * ((double)70 / 9);
            number2 = Convert.ToInt32(number2); // Creates upper bound, e.g. 77777
            number2--;

            if (c < number1)
            {
                sumC = GetAlgo(number);
            }

            if (c > number2)
            {
                sumC = GetAlgo(number * 10);
            }

            if (c >= number1 && c <= number2)
            {

                for (int i = 1; i < number; i *= 10)
                {
                    number3 = Convert.ToInt32(number1);

                    number1 = number1 + (number / i) * 4; // Creates next upper bound, e.g. 37777, and so on...

                    if (c >= number1 && c <= number2)
                    {
                        sumC += ((GetAlgo(number * 10)) - (GetAlgo(number))) / 2;
                        sumC += CheckInterval(Convert.ToInt32(number1), c);
                    }

                    number2 = number2 - (number / i) * 4; // Creates next lower bound, e.g. 73333, and so on...

                    if (c >= number3 && c <= number2)
                    {
                        sumC += CheckInterval(number3, c);
                    }

                    if (i == 1) // If number is between e.g. 3777 and 7333, caluculate using only algorithms.
                    {
                        if (c > number2 && c < number1) 
                        {
                            sumC += ((GetAlgo(number * 10)) - (GetAlgo(number))) / 2; 
                        }
                    }
                }
            }
            return sumC;
        }
    }
}