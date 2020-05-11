using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    class Edge<T>
    {
        public int Weight { get; set; }
        public GraphNode<T> Node { get; set; }
    }
}
