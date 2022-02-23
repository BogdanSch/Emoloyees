using System;
using System.Collections.Generic;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            List<Employee> employees = new List<Employee>()
            {
                new Manager()
                {
                    Name = "Alibaba",
                    Rank = 500,
                    SalesVolume = 1000000,
                    Bonus = 10
                },

                new Manager()
                {
                    Name = "Synok",
                    Rank = 3000,
                    SalesVolume = 10000,
                    Bonus = 1000
                },

                new Security()
                {
                    Name = "Oleg",
                    Rank = 3
                },

                new Security()
                {
                    Name = "Vitia",
                    Rank = 2
                },

                new SEO()
                {
                    Name = "Vladimir Putin",
                    Rank = 5000,
                    SalesVolume = 1010000,
                    Bonus = 7
                },
            };


            foreach (Employee e in employees)
            {
                Console.WriteLine(e);
            }
        }
    }
}
