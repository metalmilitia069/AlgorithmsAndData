using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSolution2Algorithms
{
    class DoublyLinkedList<T>
    {
        public DoublyNode<T> Head { get; set; }
        public DoublyNode<T> Tail { get; set; }
        public int Count { get; set; }
        public bool IsEmpty => Count == 0;

        public void AddFirst(T value)
        {
            AddFirst(new DoublyNode<T>(value));
        }

        private void AddFirst(DoublyNode<T> doublyNode)
        {
            DoublyNode<T> temp = Head;
            Head = doublyNode;
            Head.Next = temp;

            if (IsEmpty)
            {
                Tail = Head;
            }
            else
            {
                temp.Previous = Head;
            }
            Count++;
        }

        private void AddLast(T value)
        {
            AddLast(new DoublyNode<T>(value));
        }

        private void AddLast(DoublyNode<T> doublyNode)
        {
            if (IsEmpty)
            {
                Head = doublyNode;
                Tail = doublyNode;
            }
            else
            {
                Tail.Next = doublyNode;
                doublyNode.Previous = Tail;
            }
            Tail = doublyNode;
            Count++;
        }

        public void RemoveFirst()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }
            Head = Head.Next;

            Count--;

            if (IsEmpty)
            {
                Tail = null;
            }
            else
            {
                Head.Previous = null;
            }
        }

        public void RemoveLast()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }

            if (Count == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Tail.Previous.Next = null;
                Tail = Tail.Previous;
            }

            Count--;
        }

        public void PrintList()
        {
            if (Count != 0)
            {
                Console.WriteLine(Head.Value);
                DoublyNode<T> nnext = Head.Next;
                while (nnext != null)
                {
                    Console.WriteLine(nnext.Value);
                    nnext = nnext.Next;
                }
            }


        }
    }

    class DoublyNode<T>
    {
        public DoublyNode<T> Next { get; set; }
        public DoublyNode<T> Previous { get; set; }

        public T Value { get; set; }

        public DoublyNode(T value)
        {
            Value = value;
        }
    }
}
