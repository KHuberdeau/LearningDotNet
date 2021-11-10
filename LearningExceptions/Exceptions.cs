using System;
using System.Text;

namespace LearningExceptions
{
    class Person
    {
        private String name;

        public String Name
        {
            get { return name; }
            set 
            {
                try
                {
                    if (value == null)
                        throw new NullReferenceException("name must have a value");
                    name = value;
                }
                catch (Exception)
                {
                    Console.WriteLine("name cannot be null");
                    throw;
                }
            }
        }

    }
    class Exceptions
    {
        static void Main(string[] args)
        {
            try
            {
                var person = new Person();
                person.Name = null;
            }
            catch (EncoderFallbackException ex)
            {
                Console.WriteLine(ex);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
