using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSolution2Algorithms
{
    class NodeReview
    {
        public int Value { get; set; }
        public NodeReview Next { get; set; }


        public static void PrintLinkedList(NodeReview node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }

    }

    
}
