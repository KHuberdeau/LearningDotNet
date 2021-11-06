using System;
using System.Collections.Generic;

namespace LearningLists
{
    class Lists
    {
        static void Main(string[] args)
        {
            List<String> customers = new List<String>();

            customers.Add("Kim");
            customers.Add("John");
            customers.Add("Tim");

            Console.WriteLine(customers.Count);

            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine(customers[1]);
        }
    }
}
