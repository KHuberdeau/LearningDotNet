using System;
using System.Collections;

namespace LearningHashTables
{
    class HashTables
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();

            table.Add("title", "MyWebsite");

            var s = (String)table["title"];
            Console.WriteLine(s);
        }
    }
}
