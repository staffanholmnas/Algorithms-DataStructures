using System.Text;
using System;
using System.Collections.Generic;

namespace Part5
{
    public class Labyrinth
    {
        public string Search(char[,] laby)
        {
            // Returns directions for a correct path to the distination, but not necessarily the shortest. 
            // The distance is always the shortest, however, since BFS is used.
            // I could not combine these two to return directions for a correct shortest path.

            int n = laby.GetLength(0); // Amount of rows.
            int m = laby.GetLength(1); // Amount of columns.
            StringBuilder route = new StringBuilder("", n * m);
            Position root = new Position(1, 1); // Start position.
            Position destination = new Position(1, 4); // End position.
            bool[,] visited = new bool[n, m];
            visited[root.x, root.y] = true;
            int[] rows = { -1, 0, 0, 1 };
            int[] columns = { 0, -1, 1, 0 };
            string[] direction = { "U", "L", "R", "D" };
            Queue<QNode> queue = new Queue<QNode>();
            QNode node = new QNode(root, 0); // Distance is zero.
            queue.Enqueue(node);

            int dist = ShortestDistance(laby, n, m, route, destination, visited, rows, columns, queue, node, direction);

            Queue<QNode> queue2 = new Queue<QNode>();
            QNode node2 = new QNode(root, 0); // Distance is zero.
            queue2.Enqueue(node2);
            bool[,] visited2 = new bool[n, m];
            visited2[root.x, root.y] = true;

            string path = PrintPath(laby, n, m, route, destination, visited2, queue2, node2);

            return path + "\nThe shortest distance is " + dist;
        }
        public int ShortestDistance(char[,] laby, int n, int m, StringBuilder route, Position destination,
        bool[,] visited, int[] rows, int[] columns, Queue<QNode> queue, QNode node, String[] direction)
        {
            while (queue.Count != 0)
            {
                QNode current = queue.Peek();
                Position pos = current.pos;

                if (pos.x == destination.x && pos.y == destination.y)
                {
                    return current.distance; // Shortest distance.
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
                        // route.Append(direction[i]);  -Doesn't always work. Adds too many directions for longer paths.
                    }
                }
            }

            return 0;
        }
        public string PrintPath(char[,] laby, int n, int m, StringBuilder route, Position destination,
        bool[,] visited, Queue<QNode> queue, QNode node)
        {
            while (queue.Count != 0)
            {
                QNode current = queue.Peek();
                Position pos = current.pos;

                if (pos.x == destination.x && pos.y == destination.y)
                {
                    return route.ToString(); // Path
                }

                queue.Dequeue();

                if ((pos.x - 1 >= 0) && (pos.x - 1 <= n) && (pos.y >= 0) && (pos.y <= m) && laby[pos.x - 1, pos.y] != '#'
                && !visited[pos.x - 1, pos.y])
                {
                    Position newPos = new Position(pos.x - 1, pos.y);
                    QNode neighbor = new QNode(newPos, current.distance + 1);
                    queue.Enqueue(neighbor);
                    visited[pos.x - 1, pos.y] = true;
                    route.Append("U");
                }
                else if ((pos.x >= 0) && (pos.x <= n) && (pos.y + 1 >= 0) && (pos.y + 1 <= m) && laby[pos.x, pos.y + 1] != '#'
                && !visited[pos.x, pos.y + 1])
                {
                    Position newPos = new Position(pos.x, pos.y + 1);
                    QNode neighbor = new QNode(newPos, current.distance + 1);
                    queue.Enqueue(neighbor);
                    visited[pos.x, pos.y + 1] = true;
                    route.Append("R");
                }
                else if ((pos.x >= 0) && (pos.x <= n) && (pos.y - 1 >= 0) && (pos.y - 1 <= m) && laby[pos.x, pos.y - 1] != '#'
                && !visited[pos.x, pos.y - 1])
                {
                    Position newPos = new Position(pos.x, pos.y - 1);
                    QNode neighbor = new QNode(newPos, current.distance + 1);
                    queue.Enqueue(neighbor);
                    visited[pos.x, pos.y - 1] = true;
                    route.Append("L");
                }

                else if ((pos.x + 1 >= 0) && (pos.x + 1 <= n) && (pos.y >= 0) && (pos.y <= m) && laby[pos.x + 1, pos.y] != '#'
                && !visited[pos.x + 1, pos.y])
                {
                    Position newPos = new Position(pos.x + 1, pos.y);
                    QNode neighbor = new QNode(newPos, current.distance + 1);
                    queue.Enqueue(neighbor);
                    visited[pos.x + 1, pos.y] = true;
                    route.Append("D");
                }
            }

            return "Cannot be found";
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

// ---------------------------------------------------
// BFS, finds the shortest path, but prints the directions incorrectly...
/*
            int n = laby.GetLength(0); // Amount of rows.
            int m = laby.GetLength(1); // Amount of columns.
            StringBuilder route = new StringBuilder("", n * m);
            Position root = new Position(1, 1); // Start position.
            Position destination = new Position(3, 5); // End position.
            bool[,] visited = new bool[n, m];
            visited[root.x, root.y] = true;
            int[] rows = { -1, 0, 0, 1 };
            int[] columns = { 0, -1, 1, 0 };
            string[] direction = { "U", "L", "R", "D" };
            Queue<QNode> queue = new Queue<QNode>();
            QNode node = new QNode(root, 0); // Distance is zero.
            queue.Enqueue(node);

            while (queue.Count != 0)
            {
                QNode current = queue.Peek();
                Position pos = current.pos;

                if (pos.x == destination.x && pos.y == destination.y)
                {
                    return route.ToString(); // current.distance.ToString();
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
                        route.Append(direction[i]);
                    }
                }
            }
            return "Cannot be found";
            */
