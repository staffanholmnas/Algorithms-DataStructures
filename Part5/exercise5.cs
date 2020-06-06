using System.Text;
using System;
using System.Collections.Generic;

namespace Part5
{
    public class Labyrinth
    {
        public string Search(char[,] laby)
        {
            int n = laby.GetLength(0);
            int m = laby.GetLength(1);
            int y = 1, x = 1;
            int area = m * n;
            //Console.WriteLine(n);
            //Console.WriteLine(m);
            bool[,] visited = new bool[n, m];
            int[] distance = new int[area];
            char root = laby[1, 1];
            char[] neighbor = new char[4];
            char up = laby[y - 1, x], down = laby[y + 1, x], left = laby[y, x - 1], right = laby[y, x + 1];
            char destination = laby[1, 4];
            char node = '0';
            //Console.WriteLine(root);
            //Console.WriteLine(destination);
            Queue<char> queue1 = new Queue<char>();
            //Queue<char> queue2 = new Queue<char>();
            StringBuilder route = new StringBuilder("", area);

            queue1.Enqueue(root);

            visited[y, x] = true;
            distance[0] = 0;
            while (queue1.Count > 0)    // node == destination?
            {
                node = queue1.Dequeue();

                neighbor[0] = up;
                neighbor[1] = down;
                neighbor[2] = left;
                neighbor[3] = right;

                // replace laby with neighbors to node.
                foreach (char i in neighbor)
                {
                    Console.WriteLine(i);
                   
                }
                // if visted = true
                // if wall = true
                // if node == destination break?
                // queue.enqueue(neighbor)
                // visited[neighbor] = true
                // distance[neighbor] = distance[node] +1
                // implement route somehow

            }




            return route.ToString();
        }
    }
}

/*queue.Enqueue(laby[1, 1]);
            visited[1, 1] = true;
            distance[0] = 0;
            while (queue.Count != 0)
            {
                char node = queue.Dequeue();

                foreach (var item in laby)
                {
                    Console.WriteLine(item);
                    if (visited[x, y] == true)
                    {
                        continue;
                    }
                    queue.Enqueue(item);
                    visited[x, y] = true;
                    distance[item] = distance[node] + 1;
                    route.Append("D");
                }
            }*/
//------------------------------------------------------------------------------
// Below is DFS and kind of works...

/*  int n = laby.GetLength(0);
    int m = laby.GetLength(1);
    int x = 1, y = 1;
    int area = m * n;
    //Console.WriteLine(n);
    //Console.WriteLine(m);
    bool[,] visited = new bool[n + 1, m + 1];
    int[] distance = new int[area + 1];
    char root = laby[y, x];
    char destination = laby[1, 4];
    //Console.WriteLine(root);
    //Console.WriteLine(destination);
    Queue<char> queue = new Queue<char>();
    StringBuilder route = new StringBuilder("", area);

    Find(y, x, route, visited, n, laby);

    return route.ToString();
}

public void Find(int y, int x, StringBuilder route, bool[,] visited, int n, char[,] laby)
{
    if (y < 0 || x < 0 || y >= n || x >= n)
    {  
        return;
    }
    if (laby[y, x] == 'y')
    { 
        return;
    }
    if (laby[y, x] == '#')
    {  
        return;
    }
    if (visited[y, x] == true)
    {
        return;
    }

    visited[y, x] = true;

    if (visited[y - 1, x] == true)
    {
        route.Append("D");  
    }
    if (visited[y, x - 1] == true)
    {
        route.Append("R");  
    }
    if (visited[y, x + 1] == true)
    {
        route.Append("L");  
    }
    if (visited[y + 1, x] == true)
    {
        route.Append("U");  
    }

    Find(y - 1, x, route, visited, n, laby);
    Find(y, x + 1, route, visited, n, laby);
    Find(y, x - 1, route, visited, n, laby);
    Find(y + 1, x, route, visited, n, laby); */
