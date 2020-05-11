using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    class GraphNode<T>
    {
        public T Value { get; set; }
        public GraphNode(T value)
        {
            Value = value;
        }
    }
}
