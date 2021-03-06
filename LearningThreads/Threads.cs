using System;
using System.Threading;
using System.Threading.Tasks;

namespace LearningThreads
{
    class Threads
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 50; i++)
            {
                Thread mythread = new Thread(new ThreadStart(Work));
                mythread.Start();

                Task.Run(() =>
                {
                    Console.WriteLine("starting task in thread: " + Thread.CurrentThread.ManagedThreadId);
                    Thread.Sleep(3000);
                    Console.WriteLine("task complete");
                });
            }
            Console.ReadLine();
        }

        static void Work()
        {
            Console.WriteLine("starting in thread: " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(3000);
            Console.WriteLine("work complete");
        }
    }
}
