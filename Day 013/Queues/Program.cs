using System;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            //defining  queue of integers
            Queue<int> queue =new Queue<int>();
            queue.Enqueue(1);
            //printing the element at the front of the queue
            Console.WriteLine("The value at the front of the queue is : {0}", queue.Peek());
            queue.Enqueue(2);
            Console.WriteLine("The value at the front of the queue is : {0}", queue.Peek());
            queue.Enqueue(3);
            int queueItem= queue.Dequeue();
            Console.WriteLine("The value at the front of the queue is : {0}", queue.Peek());
        }
    }
}