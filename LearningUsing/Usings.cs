using System;

namespace LearningUsing
{
    class Usings
    {
        class MyResource : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine("Disposing our resource");
            }
        }
        static void Main(string[] args)
        {
            using(var resource = new MyResource())
            {
                Console.WriteLine("Using my resource");
            }
            Console.WriteLine("Finished");
        }
    }
}
