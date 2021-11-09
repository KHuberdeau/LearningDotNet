using System;

namespace LearningNulls
{
    class Nulls
    {
        static void Main(string[] args)
        {
            int? s = null;
            int s2 = s ?? 2;

            Console.WriteLine(s2);
        }
    }
}
