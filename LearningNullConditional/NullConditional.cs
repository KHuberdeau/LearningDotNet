using System;

namespace LearningNullConditional
{
    class Person
    {
        public string Name { get; set; }
    }
    class NullConditional
    {
        static void Main(string[] args)
        {
            Person person = new Person() { Name = "Tim" }; //what if this was null
            Console.WriteLine(person.Name);
        }
    }
}
