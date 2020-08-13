using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using PriorityQueue.Abstract;

namespace PriorityQueue
{
    class PriorityQueue<T> : IPriorityQueue<T>
    {
        public List<PriorityQueueNode<T>> prQueue = new List<PriorityQueueNode<T>>();
        public int Count => prQueue.Count;

        public T Dequeue()
        {
            PriorityQueueNode<T> node = prQueue.OrderBy(item => item.Priority).First();
            prQueue.Remove(node);
            return node.Item;
        }

        public void Enqueue(uint priority, T item)
        {
            prQueue.Add(new PriorityQueueNode<T>(priority, item));
        }
    }
}
