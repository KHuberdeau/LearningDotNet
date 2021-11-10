using System;

namespace LearningExceptionFilters
{
    class PersonException : Exception
    {
        public PersonException(String name)
        {
            Name = name;
        }
        public String Name { get; set; }
    }

    class ExceptionFilters
    {
        static void Main(string[] args)
        {
            try
            {
                //throw new PersonException("Kim");
                throw new PersonException("Bob");

            }
            catch (PersonException ex) when (ex.Name == "Kim")
            {
                Console.WriteLine("its from Kim, lets ignore it");
            }
            catch (PersonException ex) when (ex.Name == "Bob")
            {
                Console.WriteLine("its from Bob, lets do something");
            }
        }
    }
}
