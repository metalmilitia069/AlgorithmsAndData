using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSolution2Algorithms
{
    class MaxHeapTest<T> where T : IComparable<T>
    {

        //NOT IMPLEMENTED!!!!!!#################################################

        private const int DefaultCapacity = 4;
        private T[] _heap;

        public int Count { get; private set; }

        public bool IsFull => Count == _heap.Length;
        public bool IsEmpty => Count == 0;

        

        public MaxHeapTest():this(DefaultCapacity)
        {

        }

        private MaxHeapTest(int capacity)
        {
            _heap = new T[capacity];
        }

        public void Insert(T value)
        {
            if (IsFull)
            {
                var newHeap = new T[_heap.Length * 2];
                Array.Copy(_heap, 0, newHeap, 0, _heap.Length);

            }
            _heap[Count] = value;
            Swim(Count);

            Count++;
        }

        //public void Swim(int indexOfSwimmingItem)
        //{
        //    T newValue = _heap[indexOfSwimmingItem];
        //    while (indexOfSwimmingItem > 0 && IsParentLess(indexOfSwimmingItem))
        //    {

        //    }
        //}

        //public bool IsParentLess()
        //{
        //    return newValue.;
        //}
    }
}
