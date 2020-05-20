namespace Part3
{
    using System;
    public class PrintHello
    {
        public void Hello(int n)
        {
            if (n <= 0)
            {
                return;
            }
            else
            {
                Console.WriteLine("Hello!");
                Hello(n - 1);
            }
        }
    }
}