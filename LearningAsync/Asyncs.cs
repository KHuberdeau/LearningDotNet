using System;
using System.Threading;
using System.Threading.Tasks;

namespace LearningAsync
{
    class Asyncs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Downloading file");
            Download();
            Console.ReadLine();
        }

        static void Download()
        {
            Task.Run(() => {
                Thread.Sleep(3000);
                Console.WriteLine("Download Complete");
            });
        }
    }
}
