using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSolution2Algorithms
{
    class TreeNode<T> where T : IComparable<T>
    {
        public T Value { get; set; }
        public TreeNode<T> Right { get; set; }
        public TreeNode<T> Left { get; set; }

        public TreeNode(T value)
        {
            Value = value;
        }

        public void Insert(T newvalue)
        {
            int compare = newvalue.CompareTo(Value);
            if (compare==0)
            {
                return;
            }
            if (compare<0)
            {
                if (Left == null)
                {
                    Left = new TreeNode<T>(newvalue);
                }
                else
                {
                    Left.Insert(newvalue);
                }                
            }
            else
            {
                if (Right == null)
                {
                    Right = new TreeNode<T>(newvalue);
                }
                else
                {
                    Right.Insert(newvalue);
                }
            }
        }

        public TreeNode<T> Get(T value)
        {
            int compare = value.CompareTo(Value);

            if (compare == 0)
            {
                return this;
            }
            if (compare < 0)
            {
                if (Left != null)
                {
                    return Left.Get(value);
                }
            }
            else
            {
                if (Right != null)
                {
                    return Right.Get(value);
                }
            }

            return null;
        }

        public IEnumerable<T> TraverseInOrder()
        {
            var list = new List<T>();
            InnerTraverse(list);
            return list;
        }

        private void InnerTraverse(List<T> list)
        {
            if (Left != null)
            {
                Left.InnerTraverse(list);
            }
            list.Add(Value);

            if (Right != null)
            {
                Right.InnerTraverse(list);
            }
        }

        public T Mininum()
        {
            if (Left != null)
            {
                return Left.Mininum();
            }
            return Value;
        }

        public T Maximum()
        {
            if (Right != null)
            {
                return Right.Maximum();
            }
            return Value;
        }

    }
}
