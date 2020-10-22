namespace Exam_prep
{
    using System.Collections.Generic;
    using System;
    public class Flights
    {
        public int n;
        public int totalPrice;

        //public Weight weight;
        public List<Edge> edges;
        public Flights()
        {
            this.edges = new List<Edge>();
            this.n = 1;
            this.totalPrice = 0;
        }

        public void AddConnection(string departure, string destination, int price)
        {
            // Out of time, sorry!!

            
            this.totalPrice += price; 

            int nodeDepart = this.n, nodeDest = this.n + 1;
            foreach (Edge edge in this.edges)
            {
                if (departure == edge.beginning.city)
                {
                    nodeDepart = edge.beginning.node;
                    //Console.WriteLine(edge.beginning.city + " " + nodeDepart);
                }
               

                if (destination == edge.end.city)
                {
                    nodeDest = edge.end.node;
                    //Console.WriteLine(edge.end.city + " " + nodeDest);
                }
               

            }
            Node departureNode = new Node(departure, nodeDepart);
            Node destinationNode = new Node(destination, nodeDest);
            //this.weight = new Weight(price);
            this.edges.Add(new Edge(departureNode, destinationNode, price));
            //this.edges.Add(new Edge(destinationNode, departureNode, price));
            this.n++;
            Console.WriteLine(departureNode.city + " " + departureNode.node);
            Console.WriteLine(destinationNode.city + " " + destinationNode.node);
            //Console.WriteLine(this.n + " " + price);
        }

        public int RoutePrice(string departure, string destination)
        {
            int x = 0, y = 0;
            foreach (Edge edge in this.edges)
            {
                if (departure == edge.beginning.city)
                {
                    x = edge.beginning.node;
                }
                if (destination == edge.end.city)
                {
                    y = edge.end.node;
                }
            }
            Console.WriteLine(x + "-------------------->" + y);
            // Bellman-Ford's algorithm.
            int[] distance = new int[n + 1];
            for (int i = 0; i < distance.Length; i++) distance[i] = 9999999;
            distance[x] = 0;

            while (true)
            {
                bool change = false;
                foreach (Edge edge in this.edges)
                {
                    if (distance[edge.beginning.node] != 9999999 &&
                    (distance[edge.beginning.node] + edge.weight) < distance[edge.end.node])
                    {
                        distance[edge.end.node] = (distance[edge.beginning.node] + edge.weight);
                        change = true;
                    }
                }
                if (change == false) break;
            }

            Console.WriteLine(this.totalPrice + " total price");
            Console.WriteLine(distance[y]);
            return this.totalPrice - distance[y];
        }
    }

    public class Edge
    {
        public Node beginning, end;
        public int weight;

        public Edge(Node beginning, Node end, int weight)
        {
            this.beginning = beginning;
            this.end = end;
            this.weight = weight;
        }
    }

    // Weight objects not used.
    public class Weight
    {
        public int weight = 9999999;
        public int price;

        public Weight(int price)
        {
            this.price = price;
        }
    }

    public class Node
    {
        public int node;
        public string city;

        public Node(string city, int node)
        {
            this.city = city;
            this.node = node;
        }
    }
}
