using System;

namespace LearningFinally
{
    class Finally
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Connected to database");

            try
            {
                throw new Exception("error while accessing database resource");
            }
            catch (Exception)
            {
                Console.WriteLine("exception caught");
            }
            finally
            {
                Console.WriteLine("disconnecting database");
            }
        }
    }
}
