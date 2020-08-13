using System;
using System.Collections.Generic;
using System.Text;

namespace PriorityQueue
{
    class PriorityQueueNode
    {
        public uint Priority { get; }
        public object Item { get;}
        public PriorityQueueNode(uint priority, object item)
        {
            Priority = priority;
            Item = item;
        }
    }
}
