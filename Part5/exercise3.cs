using System.Collections.Generic;

namespace Part5
{
    public class Components
    {
        public int n;
        public List<int>[] graph;

        public Components(int n)
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
        public int Calculate()
        {
            bool[] visited = new bool[n];

            int searchMe = 1, sum = 0;

            foreach (bool item in visited)
            {
                if (item == false)
                {
                    Search(searchMe, visited);
                    sum++;
                }
                searchMe++;
            }
            
            return sum;
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