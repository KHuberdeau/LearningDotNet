using System;
using System.Collections.Generic;

namespace LearningStack
{
    class Stacks
    {
        static void Main(string[] args)
        {
            Stack<String> pancakes = new Stack<string>();

            pancakes.Push("First pancake made");
            pancakes.Push("Second pancake made");
            pancakes.Push("Last pancake made");

            //foreach (var pancake in pancakes)
            //{
            //    Console.WriteLine(pancakes);
            //}

            Console.WriteLine(pancakes.Pop());
            Console.WriteLine(pancakes.Peek());
            Console.WriteLine(pancakes.Peek());
        }
    }
}
