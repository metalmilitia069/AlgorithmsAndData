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
