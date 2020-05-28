using System;

namespace Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList myLinks = new LinkedList();
            //myLinks.RemoveLast();
            //myLinks.RemoveFirst();
            myLinks.AddFirst(5);
            myLinks.AddFirst(4);
            myLinks.AddFirst(3);
            myLinks.AddFirst(2);
            
            
            myLinks.AddFirst(1);

            myLinks.printNodes();

            //myLinks.AddLast(6);
            Console.WriteLine(myLinks); // for example: 2, 1, 3

            myLinks.RemoveLast();
            //myLinks.RemoveFirst();
            Console.WriteLine(myLinks); 
            myLinks.printNodes();
            //myLinks.RemoveFirst();
            //Console.WriteLine(myLinks);
            //myLinks.RemoveLast();
            //Console.WriteLine(myLinks);
            //myLinks.RemoveLast();
            //Console.WriteLine(myLinks); // for example: 1, 3
            //Console.WriteLine(myLinks.GetNode(0)); // 1
            //Console.WriteLine(myLinks.GetNode(1)); // 3
        }
    }
}
