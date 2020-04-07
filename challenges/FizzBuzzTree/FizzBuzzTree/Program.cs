using System;

namespace FizzBuzzTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
		public void FizzBuzzTree(Tree tree)
		{
			int rootValue = (Int32)tree.Root.Value;
			if(rootValue % 15 == 0)
			{
				tree.Root.Value = "FizzBuzz";
			}
			else if (rootValue % 3 == 0)
			{
				tree.Root.Value = "Fizz";
			}
			else if (rootValue % 5 == 0)
			{
				tree.Root.Value = "Buzz";
			}
			else
			{
				tree.Root.Value = $"{tree.Root.Value}";
			}
			if(tree.Root.Left != null)
			{
				tree.SubTree = new Tree();
				tree.SubTree.Root = tree.Root.Left;
				FizzBuzzTree(tree.SubTree);
			}
			if(tree.Root.Right != null)
			{
				tree.SubTree = new Tree();
				tree.SubTree.Root = tree.Root.Right;
				FizzBuzzTree(tree.SubTree);
			}
		}
	}
	public class Node
	{
		public Object Value {get; set;}
		public Node Left {get; set;}
		public Node Right {get; set;}
	}

	public class Tree
	{
		public Node Root {get; set;}
		public Tree SubTree {get; set;}
	}


}
