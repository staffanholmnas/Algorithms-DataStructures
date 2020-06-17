namespace Exercise3

{
    public class ShortestPath
    {
        public int n;
        public int[,] distance;
        public int max = 999999999;
        public bool calculated = false;

        public ShortestPath(int n)
        {
            this.n = n;
            this.distance = new int[this.n + 1, this.n + 1];

            // Add infinity to all edges in distance matrix instead of zeros. Distance[node,node] = 0. 
            for (int i = 1; i <= this.n; i++)
            {
                for (int j = 1; j <= this.n; j++)
                {
                    this.distance[i, j] = max;

                    if (i == j)
                    {
                        this.distance[i, j] = 0;
                    }
                }
            }
        }

        public void AddRoad(int a, int b, int d)
        {
            this.distance[a, b] = d;
            this.distance[b, a] = d;
        }
        public int Calculate(int x, int y)
        {
            // Floyd-Warshall algorithm.

            if (this.calculated == false) // Only calculate if needed.
            {
                for (int k = 1; k <= this.n; k++)
                {
                    for (int i = 1; i <= this.n; i++)
                    {
                        for (int j = 1; j <= this.n; j++)
                        { 
                            this.distance[i, j] = System.Math.Min(this.distance[i, j], this.distance[i, k] + this.distance[k, j]);
                        }
                    }
                }

                this.calculated = true;
            }

            // Return the distance.
            if (this.distance[x, y] < max) return this.distance[x, y];

            return -1;
        }
    }
}