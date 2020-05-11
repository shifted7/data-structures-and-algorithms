using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    class Graph<T>
    {
        public Dictionary<GraphNode<T>, List<Edge<T>>> AdjacencyList { get; set; }

        private int _size { get; set; }
        public Graph()
        {
            AdjacencyList = new Dictionary<GraphNode<T>, List<Edge<T>>>();
        }

        public GraphNode<T> AddNode(T value)
        {
            GraphNode<T> node = new GraphNode<T>(value);
            AdjacencyList.Add(node, new List<Edge<T>>());
            _size++;
            return node;
        }

        public void AddDirectedEdge(GraphNode<T> a, GraphNode<T> b, int weight)
        {
            AdjacencyList[a].Add(new Edge<T>
            {
                Node = b,
                Weight = weight
            });
        }

        public void AddUndirectedEdge(GraphNode<T> a, GraphNode<T> b, int weight)
        {
            AddDirectedEdge(a, b, weight);
            AddDirectedEdge(a, b, weight);
        }

        public void GetAllVertices()
        {
            List<GraphNode<T>> nodes = new List<GraphNode<T>>();

            foreach (var node in AdjacencyList)
            {
                nodes.Add(node.Key);
            }
        }
    }
}
