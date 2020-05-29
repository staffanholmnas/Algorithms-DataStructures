using System;

namespace Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList myLinks = new LinkedList();
            myLinks.AddLast(1);
            myLinks.AddFirst(2);
            myLinks.AddLast(3);
            Console.WriteLine(myLinks); // for example: 2, 1, 3
            myLinks.RemoveFirst();
            Console.WriteLine(myLinks); // for example: 1, 3
            Console.WriteLine(myLinks.GetNode(0)); // 1
            Console.WriteLine(myLinks.GetNode(1)); // 3
        }
    }
}
