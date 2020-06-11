using System;

namespace Exercise2
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
        public int Calculate(int x, int y)
        {
            // Dijkstra's algorithm.
            int[] distance = new int[n + 1];
            bool[] QSet = new bool[n + 1];

            for (int i = 0; i < n + 1; i++)
            {
                distance[i] = int.MaxValue;
                QSet[i] = false;
            }

            distance[x] = 0;

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
                        distance[k] = distance[minDist] + graph[minDist, k];
                    }
                }
            }

            return distance[y];
        }
    }
}