using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;

namespace LearningAsyncAwayStart
{
    class AsyncAways
    {
        static void Main(string[] args)
        {
            Console.WriteLine("downloading file");
            Download();
            Console.ReadLine();

        }

        static async void Download()
        {
            HttpClient client = new HttpClient();
            var data = await client.GetStringAsync("http://Reddit.com/r/MagicArena");
            Console.WriteLine("Download Complete" + data);
        }
    }
}
