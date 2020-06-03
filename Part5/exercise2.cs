using System.Collections.Generic;
using System;

namespace Part5
{
    public class Connectivity
    {
        public int n;
        public List<int>[] graph;

        public Connectivity(int n)
        {
            this.n = n;
            this.graph = new List<int>[n + 1];

            for (int i = 1; i <= n; i++)
            {
                graph[i] = new List<int>();
            }
        }

        public void AddConnection(int a, int b)
        {
            graph[a].Add(b);
            graph[b].Add(a);

        }
        public int Calculate(int x)
        {
            bool[] visited = new bool[n];

            Search(x, visited);

            int sum = 0;

            foreach (bool item in visited)
            {
                if (item == true)
                {
                    sum++;
                }
            }
            return sum - 1; // The node has visited itself, but we don't count this, so 1 is subtracted. 
        }
        public void Search(int x, bool[] visited)
        {
            if (visited[x - 1] == true)
            {
                return;
            }

            visited[x - 1] = true;

            foreach (int i in graph[x])
            {
                Search(i, visited);
            }
        }
    }
}