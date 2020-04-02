using System;
using System.Collections.Generic;
using System.Text;

namespace MultiBracketValidation.Classes
{
    public class Node
    {
        public string Char { get; set; }
        public Node Next { get; set; }
        public Node(string input)
        {
            Char = input;
        }
    }
}
