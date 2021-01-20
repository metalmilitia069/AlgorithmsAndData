using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSolution2Algorithms
{
    class StackLinkedListBased<T> : IEnumerable<T>
    {
        private readonly SinglyLinkedList<T> _list = new SinglyLinkedList<T>();

        private int Count => _list.Count;
        public bool IsEmpty => Count == 0;
        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }
            return _list.Head.Value;
        }

        public void Pop()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }
            _list.RemoveFirst();
        }

        public void Push(T value)
        {
            _list.AddFirst(value);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
