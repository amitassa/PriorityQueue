using System;
using System.Collections.Generic;
using System.Text;
using PriorityQueue.Abstract;

namespace PriorityQueue
{
    class PriorityQueue<T> : IPriorityQueue<T>
    {
        public Queue<> prQueue { get; }
        public int Count => throw new NotImplementedException();

        public T Dequeue()
        {
            throw new NotImplementedException();
        }

        public void Enqueue(uint priority, T item)
        {
            throw new NotImplementedException();
        }
    }
}
