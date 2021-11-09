using System;
using System.Collections.Generic;

namespace LearningQueue
{
    class Queues
    {
        static void Main(string[] args)
        {
            Queue<int> myQueue = new Queue<int>();

            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);

            //foreach (var item in myQueue)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Peek());
        }
    }
}
