using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSolution2Algorithms
{
    class SinglyLinkedList<T> : IEnumerable<T>
    {
        public NodeReview2<T> Head { get; set; }
        public NodeReview2<T> Tail { get; set; }

        public int Count { get; set; }

        public void AddFirst(T value)
        {
            AddFirst(new NodeReview2<T>(value));
        }

        private void AddFirst(NodeReview2<T> nodeReview2)
        {
            //save off the current head
            NodeReview2<T> temp = Head;

            Head = nodeReview2;
            Head.Next = temp;

            Count++;

            if (Count == 1)
            {
                Tail = Head;
            }
        }

        public void AddLast(T value)
        {
            AddLast(new NodeReview2<T>(value));
        }

        private void AddLast(NodeReview2<T> nodeReview2)
        {
            if (IsEmpty)
            {
                Head = nodeReview2;                
            }
            else
            {
                Tail.Next = nodeReview2;                
            }

            Tail = nodeReview2;

            Count++;
        }

        private bool IsEmpty => Count == 0;

        

        public void RemoveFirst()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }

            Head = Head.Next;
            if (Count == 1)
            {
                Tail = null;
            }

            Count--;
        }

        public void RemoveLast()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }

            if (Count == 1)
            {
                Head = Tail = null;
            }
            else
            {
                //find the penultimate node
                var current = Head;
                while (current.Next != Tail)
                {
                    current = current.Next;
                }

                current.Next = null;
                Tail = current;
            }

            Count--;
        }

        

        public void PrintList()
        {
            if (Count != 0)
            {
                Console.WriteLine(Head.Value);
                NodeReview2<T> nnext = Head.Next;
                while (nnext != null)
                {
                    Console.WriteLine(nnext.Value);
                    nnext = nnext.Next;
                }
            }


        }

        public IEnumerator<T> GetEnumerator()
        {
            NodeReview2<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }    

    public class NodeReview2<T>
    {
        public T Value { get; set; }
        public NodeReview2<T> Next { get; set; }

        public NodeReview2(T value)
        {
            Value = value;
        }
    }
}
