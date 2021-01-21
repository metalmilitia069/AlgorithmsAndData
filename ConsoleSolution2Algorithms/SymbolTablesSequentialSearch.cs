using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSolution2Algorithms
{
    class SymbolTablesSequentialSearch<TKey, TValue>
    {
        //NOT FINISHED!!!!!!!!!!

        private class SequentialNode
        {
            public TKey Key {get;}
            public TValue Value { get; set; }
            public SequentialNode Next { get; set; }

            public SequentialNode(TKey key, TValue value, SequentialNode next)
            {
                Key = key;
                Value = value;
                Next = next;
            }
        }

        private SequentialNode _first;
        private readonly EqualityComparer<TKey> _comparer;

        public int Count { get; set; }

        public SymbolTablesSequentialSearch()
        {
            _comparer = EqualityComparer<TKey>.Default;
        }
        
    }
}
