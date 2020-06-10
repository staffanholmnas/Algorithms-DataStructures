using System.Collections.Generic;
using System;

namespace Exercise1
{
    public class ShortestPath
    {
        public int n;
        public List<Edge> edges;

        public ShortestPath(int n)
        {
            this.n = n;
            this.edges = new List<Edge>();
        }
        public void AddRoad(int a, int b, int d)
        {
            edges.Add(new Edge(a, b, d));
            edges.Add(new Edge(b, a, d));
        }
        public int Calculate(int x, int y)
        {
            int[] distance = new int[n + 1];
            for (int i = 0; i < distance.Length; i++) distance[i] = int.MaxValue;
            distance[x] = 0;
            
            while (true)
            {
                bool change = false;
                foreach (Edge edge in edges)
                {
                    if (distance[edge.beginning] != int.MaxValue &&
                    (distance[edge.beginning] + edge.weight) < distance[edge.end])
                    {
                        distance[edge.end] = (distance[edge.beginning] + edge.weight);
                        change = true;
                    }
                }
                if (change == false) break;
            }
            return distance[y];
        }
    }
    public class Edge
    {
        public int beginning, end, weight;

        public Edge(int beginning, int end, int weight)
        {
            this.beginning = beginning;
            this.end = end;
            this.weight = weight;
        }
    }
}