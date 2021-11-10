using System;

namespace LearningExceptions
{
    class Exceptions
    {
        static void Main(string[] args)
        {
            try
            {
                string s = null;
                var l = s.Length;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
