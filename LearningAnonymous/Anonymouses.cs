using System;
using System.Threading;
using System.Threading.Tasks;

namespace LearningAnonymous
{
    class Anonymouses
    {
        static void Main(string[] args)
        {
            Console.WriteLine("downloading file");
            Download();
            Console.ReadLine();

        }

        static void Download()
        {
            Network.Download((message) => Console.WriteLine("Download complete " + message));
        }
    }

    // Imaginary external network library

    class Network
    {
        static public void Download(Action<String> callback)
        {
            Task.Run(() => {
                Thread.Sleep(3000);
                callback("completed");
            });
        }
    }
}
}
