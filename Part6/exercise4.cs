using System.Collections.Generic;

namespace Exercise4
{
    public class ShortestPath
    {
        public int n;
        public int[,] graph;

        public ShortestPath(int n)
        {
            this.n = n;
            this.graph = new int[n + 1, n + 1];
        }
        public void AddRoad(int a, int b, int d)
        {
            graph[a, b] = d;
            graph[b, a] = d;
        }
        public int[] Calculate(int x, int y)
        {
             // Dijkstra's algorithm.
            int[] distance = new int[n + 1];
            bool[] QSet = new bool[n + 1];
            int[] visitedNodes = new int[n + 1]; // Stores nodes visited along shortest path.

            for (int i = 0; i < n + 1; i++)
            {
                distance[i] = int.MaxValue;
                QSet[i] = false;
            }

            distance[x] = 0;
            visitedNodes[x] = 0;

            for (int i = 0; i < n - 1; i++)
            {
                int min = int.MaxValue;
                int minDist = 0;

                for (int j = 0; j < n + 1; j++)
                {
                    if (QSet[j] == false && distance[j] <= min)
                    {
                        min = distance[j];
                        minDist = j;
                    }
                }

                QSet[minDist] = true;

                for (int k = 0; k < n + 1; k++)
                {
                    if (!QSet[k] && graph[minDist, k] != 0 && distance[minDist] != int.MaxValue &&
                    distance[minDist] + graph[minDist, k] < distance[k])
                    {
                        visitedNodes[k] = minDist;
                        distance[k] = distance[minDist] + graph[minDist, k];
                    }
                }
            }

            return visitedNodes;
        }
        public List<int> Create(int x, int y)
        {
            List<int> list = new List<int>();

            int[] visitedNodes = Calculate(x, y);

            GetPath(y, visitedNodes, list); // Recursively go through the array and add nodes to the list.

            return list;
        }

        public void GetPath(int y, int[] visitedNodes, List<int> list)
        {
            if (y == 0)
            {
                return;
            }
            GetPath(visitedNodes[y], visitedNodes, list);
            list.Add(y);
        }
    }
}