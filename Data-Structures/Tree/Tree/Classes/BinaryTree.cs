using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        Node Current;
        
        public Node Add(int value)
        {
            if (Root == null)
            {
                Node node = new Node(value);
                Root = node;
                Current = Root;
                return node;
            }
            if(value <= Current.Value)
            {
                if(Current.Left == null)
                {
                    Node node = new Node(value);
                    Current.Left = node;
                    Current = Root;
                    return node;
                }
                else
                {
                    Current = Current.Left;
                    return Add(value);
                }
            }
            else
            {
                if(Current.Right == null)
                {
                    Node node = new Node(value);
                    Current.Right = node;
                    Current = Root;
                    return node;
                }
                else
                {
                    Current = Current.Right;
                    return Add(value);
                }
            }
        }
    }
}
