using System;
using System.Collections.Generic;
using System.Text;

namespace PriorityQueue
{
    class PriorityQueueNode<T>
    {
        public uint Priority { get; }
        public T Item { get;}
        public PriorityQueueNode(uint priority, T item)
        {
            Priority = priority;
            Item = item;
        }
    }
}
