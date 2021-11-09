using System;
using System.Collections.Generic;

namespace LearningHashSet
{
    class HashSets
    {
        static void Main(string[] args)
        {
            var myHash = new HashSet<String>();

            myHash.Add("hello");
            myHash.Add("hello");

            String[] s = new string[] { "hello" };

            Console.WriteLine(myHash.Count);
            Console.WriteLine(myHash.Overlaps(s));
        }
    }
}
