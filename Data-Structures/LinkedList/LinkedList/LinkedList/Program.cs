using System;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LinkedList Started");
        }

        /// <summary>
        /// Merges two link lists, modifying them so that they both point to the head node of the same, merged list, and returns that head node.
        /// </summary>
        /// <param name="List1">The first link list, which will have its first node as the first node of the merged link list</param>
        /// <param name="List2">The second link list to merge, which will have its first node as the second node of the merged link list</param>
        /// <returns>The head of the new, merged list, which both list1 and list2 now reference</returns>
        public static Node MergeLists(LinkList List1, LinkList List2)
        {
            List1.Current = List1.Head;
            List2.Current = List2.Head;
            if(List1.Head == null)
            {
                Console.WriteLine("List 1 empty, merge would have no effect. Returning List 2.");
                return List2.Head;
            } else if(List2.Head == null){
                Console.WriteLine("List 2 empty, merge would have no effect. Returning List 1.");
                return List1.Head;
            }
            while(List1.Current != null && List2.Current != null)
            {
                List2.Head = List2.Current.Next; // Hold on to the next node of list 2, so we don't lose it to Garbage Collection
                List2.Current.Next = List1.Current.Next; // Connect the list 2 node to the next node of list 1, so we don't lose it to Garbage Collection
                List1.Current.Next = List2.Current; // Connect the node of list 1 to the node of list 2
                List2.Current = List2.Head; // Advance the current of list 2 to the head
                List1.Current = List1.Current.Next.Next; // Advance the current of list 1 to the next node, skipping the node we just added
            }
            List1.Current = List1.Head; // Reset the current of list 1 back to the head
            List2.Head = List1.Head; // Set the (now empty) List 2's head to the head of list 1. Both lists now reference the same list.
            return List1.Head;
        }
    }

}
