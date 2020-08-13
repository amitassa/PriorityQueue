using System;
using PriorityQueue.Abstract;

namespace PriorityQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue<string> prQueue = new PriorityQueue<string>();
            prQueue.Enqueue(1, "a");
            prQueue.Enqueue(2, "b");
            prQueue.Enqueue(3, "c"); 
            prQueue.Enqueue(4, "d");
            prQueue.Enqueue(2, "e");
            prQueue.Enqueue(1, "f");
            prQueue.Enqueue(5, "g");
            prQueue.Enqueue(8, "h");

            Console.WriteLine(prQueue.Dequeue());
            Console.WriteLine(prQueue.Count);
            Console.WriteLine(prQueue.Dequeue());
            Console.WriteLine(prQueue.Dequeue());
        }
    }
}
