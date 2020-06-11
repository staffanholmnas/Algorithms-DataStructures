namespace Exercise3
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
            // Floyd-Warshall algorithm.
            int[,] distance = new int[n + 1, n + 1];
            int max = int.MaxValue;

            // Copy matrix to distance matrix, add infinity instead of zeros. Distance[node,node] = 0. 
            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < n + 1; j++)
                {
                    distance[i, j] = graph[i,j];
                    if (graph[i,j] == 0)
                    {
                        distance[i,j] = max;
                    }
                    if (i == j)
                    {
                        distance[i,j] = 0;
                    }
                }
            }

            // Algorithm.
            for (int k = 0; k < n + 1; k++)
            {
                for (int i = 0; i < n + 1; i++)
                {
                    for (int j = 0; j < n + 1; j++)
                    {
                        if (distance[i,k] != max && distance[k,j] != max &&
                        distance[i,k] + distance[k,j] < distance[i,j])
                        {
                            distance[i,j] = distance[i,k] + distance[k,j];
                        }
                    }
                }
            }

            // Print the distance.
            int print = 0;
            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < n + 1; j++)
                {
                    if (i == x && j == y)
                    {
                        print = distance[i,j];
                    }
                }
            }

            return print;
        }
    }
}