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
        public Queue<PriorityQueueNode<T>> prQueue { get; }
        public int Count => prQueue.Count;

        public T Dequeue()
        {
            return prQueue.OrderBy(item => item.Priority).First().Item;
        }

        public void Enqueue(uint priority, T item)
        {
            prQueue.Enqueue(new PriorityQueueNode<T>(priority, item));
        }
    }
}
