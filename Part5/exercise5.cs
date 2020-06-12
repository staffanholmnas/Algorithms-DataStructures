using System.Text;
using System.Collections.Generic;

namespace Part5
{
    public class Labyrinth
    {
        public string Search(char[,] laby)
        {
            // Finds the shortest path using BFS and prints the directions and the distance. Commented out code 
            // finds the shortest path using node objects instead, but doesn't print directions.
            
            int n = laby.GetLength(0); // Amount of rows.
            int m = laby.GetLength(1); // Amount of columns.
            int startY = 0;
            int startX = 0;
            int endY = 0;
            int endX = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (laby[i, j] == 'x')
                    {
                        startY = i;
                        startX = j;
                    }
                    if (laby[i, j] == 'y')
                    {
                        endY = i;
                        endX = j;
                    }
                }
            }

            bool[,] visited = new bool[n, m];
            int[] rows = { -1, 0, 0, 1 };
            int[] columns = { 0, -1, 1, 0 };
            StringBuilder route = new StringBuilder("", n * m);
            Queue<int> queueX = new Queue<int>();
            Queue<int> queueY = new Queue<int>();
            int[,] previousX = new int[n, m];
            int[,] previousY = new int[n, m];

            previousX[startY, startX] = -1;

            visited[startY, startX] = true;
            queueY.Enqueue(startY);
            queueX.Enqueue(startX);

            while (queueX.Count != 0)
            {
                int currentY = queueY.Dequeue();
                int currentX = queueX.Dequeue();

                // Up
                int neighborY = currentY - 1;
                int neighborX = currentX;
                if (!visited[neighborY, neighborX] && laby[neighborY, neighborX] != '#')
                {
                    visited[neighborY, neighborX] = true;
                    previousY[neighborY, neighborX] = currentY;
                    previousX[neighborY, neighborX] = currentX;
                    queueX.Enqueue(neighborX);
                    queueY.Enqueue(neighborY);
                }

                // Down
                neighborY = currentY + 1;
                if (!visited[neighborY, neighborX] && laby[neighborY, neighborX] != '#')
                {
                    visited[neighborY, neighborX] = true;
                    previousY[neighborY, neighborX] = currentY;
                    previousX[neighborY, neighborX] = currentX;
                    queueX.Enqueue(neighborX);
                    queueY.Enqueue(neighborY);
                }

                // Left
                neighborY = currentY;
                neighborX = currentX - 1;
                if (!visited[neighborY, neighborX] && laby[neighborY, neighborX] != '#')
                {
                    visited[neighborY, neighborX] = true;
                    previousY[neighborY, neighborX] = currentY;
                    previousX[neighborY, neighborX] = currentX;
                    queueX.Enqueue(neighborX);
                    queueY.Enqueue(neighborY);
                }

                // Right
                neighborX = currentX + 1;
                if (!visited[neighborY, neighborX] && laby[neighborY, neighborX] != '#')
                {
                    visited[neighborY, neighborX] = true;
                    previousY[neighborY, neighborX] = currentY;
                    previousX[neighborY, neighborX] = currentX;
                    queueX.Enqueue(neighborX);
                    queueY.Enqueue(neighborY);
                }
            }

            if (!visited[endY, endX])
            {
                return "Cannot find a path!";
            }

            int y = endY;
            int x = endX;
            int dist = 0;

            while (previousX[y, x] != -1)
            {
                if (previousY[y, x] == y - 1)
                {
                    route.Insert(0, "D");
                    dist++;
                }
                else if (previousY[y, x] == y + 1)
                {
                    route.Insert(0, "U");
                    dist++;
                }
                else if (previousX[y, x] == x - 1)
                {
                    route.Insert(0, "R");
                    dist++;
                }
                else
                {
                    route.Insert(0, "L");
                    dist++;
                }
                int swap = y;
                y = previousY[y, x];
                x = previousX[swap, x];
            }

            return route.ToString() + "\nShortest distance is " + dist.ToString();
            
            // ---------------------------------------------------
            // BFS, finds the shortest distance using nodes and a neater code, but doesn't print directions.

            /*       
            int n = laby.GetLength(0); // Amount of rows.
            int m = laby.GetLength(1); // Amount of columns.
            int startY = 0;
            int startX = 0;
            int endY = 0;
            int endX = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (laby[i, j] == 'x')
                    {
                        startY = i;
                        startX = j;
                    }
                    if (laby[i, j] == 'y')
                    {
                        endY = i;
                        endX = j;
                    }
                }
            }
            Position root = new Position(startY, startX); // Start position.
            Position destination = new Position(endY, endX); // End position.
            bool[,] visited = new bool[n, m];
            visited[root.x, root.y] = true;
            int[] rows = { -1, 0, 0, 1 };
            int[] columns = { 0, -1, 1, 0 };
            Queue<QNode> queue = new Queue<QNode>();
            QNode node = new QNode(root, 0); 
            queue.Enqueue(node);
            while (queue.Count != 0)
            {
                QNode current = queue.Peek();
                Position pos = current.pos;
                if (pos.x == destination.x && pos.y == destination.y)
                {
                    return current.distance.ToString(); // Shortest distance.
                }
                queue.Dequeue();
                for (int i = 0; i < 4; i++)
                {
                    int row = pos.x + rows[i];
                    int col = pos.y + columns[i];
                    if ((row >= 0) && (row <= n) && (col >= 0) && (col <= m) 
                    && !visited[row, col] && laby[row, col] != '#')
                    {
                        visited[row, col] = true;
                        Position newPos = new Position(row, col);
                        QNode neighbor = new QNode(newPos, current.distance + 1);
                        queue.Enqueue(neighbor);
                    }
                }
            }
            return "Cannot be found";
            */
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
