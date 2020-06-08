using System.Text;
using System;
using System.Collections.Generic;

namespace Part5
{
    public class Labyrinth
    {
        public string Search(char[,] laby)
        {
            int n = laby.GetLength(1); // Row.
            int m = laby.GetLength(0); // Column.
            Console.WriteLine(n);
            Console.WriteLine(m);
            StringBuilder route = new StringBuilder("", n * m);
            Position root = new Position(1, 1); // Start position.
            Position destination = new Position(1, 4); // End position.
            bool[,] visited = new bool[m, n];
            visited[root.x, root.y] = true;
            Queue<QNode> queue = new Queue<QNode>();
            QNode node = new QNode(root, 0); // Distance is zero.
            queue.Enqueue(node);

            while (queue.Count != 0)
            {
                QNode current = queue.Peek();
                Position pos = current.pos;

                if (pos.x == destination.x && pos.y == destination.y)
                {
                    return route.ToString(); // current.distance
                }

                queue.Dequeue();

                int left = pos.x - 1;
                int down = pos.y + 1;
                int up = pos.y - 1;
                int right = pos.x + 1;

                if (Validate(left, pos.y, m, n) && laby[left, pos.y] != '#' && !visited[left, pos.y])
                {
                    
                    Position newPos = new Position(left, pos.y);
                    QNode neighbor = new QNode(newPos, current.distance + 1);
                    queue.Enqueue(neighbor);
                    visited[left, pos.y] = true;
                    route.Append("U");
                }
                else if (Validate(right, pos.y, m, n) && laby[right, pos.y] != '#' && !visited[right, pos.y])
                {
                    
                    Position newPos = new Position(right, pos.y);
                    QNode neighbor = new QNode(newPos, current.distance + 1);
                    queue.Enqueue(neighbor);
                    visited[right, pos.y] = true;
                    route.Append("D");
                } 
                else if (Validate(pos.x, down, m, n) && laby[pos.x, down] != '#' && !visited[pos.x, down])
                {
                    
                    Position newPos = new Position(pos.x, down);
                    QNode neighbor = new QNode(newPos, current.distance + 1);
                    queue.Enqueue(neighbor);
                    visited[pos.x, down] = true;
                    route.Append("R");
                }
                else if (Validate(pos.x, up, m, n) && laby[pos.x, up] != '#' && !visited[pos.x, up])
                {
                    
                    Position newPos = new Position(pos.x, up);
                    QNode neighbor = new QNode(newPos, current.distance + 1);
                    queue.Enqueue(neighbor);
                    visited[pos.x, up] = true;
                    route.Append("L");
                }
                
                
            }
            return "Cannot be found";
        }
        static bool Validate(int row, int col, int m, int n) // Check that the path stays inside the maze.
        {
            return (row >= 0) && (row <= n) && (col >= 0) && (col <= m);
        }
    }
    public class Position
    {
        public int x;
        public int y;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public class QNode
    {
        public Position pos;
        public int distance;

        public QNode(Position pos, int distance)
        {
            this.pos = pos;
            this.distance = distance;
        }
    }
}
// BFS doesn't work...
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

//--------------------------------------------------------------------------
// BFS start
/*
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
                    if (root == destination)
                    {
                        break;
                    }

                }
                // if node == destination break?

                // if visted = true
                // if wall = true

                // queue.enqueue(neighbor)
                // visited[neighbor] = true
                // distance[neighbor] = distance[node] +1
                // implement route somehow

            }




            return route.ToString();
        }
    }
}
*/
//---------------------------------------------------------------------------
// BFS, can calculate shortest distance... 
/*
 public string Search(char[,] laby)
        {
            int n = laby.GetLength(1); // Row.
            int m = laby.GetLength(0); // Column.
            int[] getRowNum = {-1, 0, 0, 1};
            int[] getColNum = {0, -1, 1, 0};
            StringBuilder route = new StringBuilder("", n * m);
            Position root = new Position(1, 1); // Start position.
            Position destination = new Position(1, 4); // End position.
            bool[,] visited = new bool[n, m];

            visited[root.x, root.y] = true;
            Queue<QNode> queue = new Queue<QNode>();
            QNode node = new QNode(root, 0); // Distance is zero.
            queue.Enqueue(node);

            while (queue.Count != 0)
            {
                QNode current = queue.Peek();
                Position pos = current.pos;

                if (pos.x == destination.x && pos.y == destination.y)
                {
                    return current.distance.ToString(); // current.distance
                }

                queue.Dequeue();

                for (int i = 0; i < 4; i++)
                {
                    int row = pos.x + getRowNum[i];
                    int col = pos.y + getColNum[i];

                    if (Validate(row, col, n, m) && laby[row, col] != '#' && !visited[row, col])
                    {
                        visited[row, col] = true;
                        Position newPos = new Position(row, col);
                        QNode neighbor = new QNode(newPos, current.distance + 1);
                        queue.Enqueue(neighbor);
                    }
                }
            }

            return "Cannot be found";
        }
        static bool Validate(int row, int col, int n, int m) // Check that the path stays inside the maze.
        {
            return (row >= 0) && (row < n) && (col >= 0) && (col < m);
        }
    }
    public class Position
    {
        public int x;
        public int y;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public class QNode
    {
        public Position pos;
        public int distance;

        public QNode(Position pos, int distance)
        {
            this.pos = pos;
            this.distance = distance;
        }
    }
}
*/
