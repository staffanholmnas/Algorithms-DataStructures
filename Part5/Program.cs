using System;

namespace Part5
{
    class Program
    {
        static void Main(string[] args)
        {
            Labyrinth l = new Labyrinth();
            char[,] c =
          { {'#','#','#','#','#','#','#'},
            {'#','x','#','.','y','.','#'},
            {'#','.','#','.','#','.','#'},
            {'#','.','.','.','.','.','#'},
            {'#','#','#','#','#','#','#'} };
            Console.WriteLine(l.Search(c)); // DDRRUUR Shortest distance is 7
        }
    }
}
