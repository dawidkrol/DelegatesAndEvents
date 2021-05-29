using DelegatesTraining;
using System;
using System.Collections.Generic;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Counting.PayDay(GetEmployees(), Message, Discount));
            Console.WriteLine($"Cost after discount {Counting.PayDay(GetEmployees(), (x) =>Console.WriteLine($"Full cost {x:C2}"), Discount):C2}");
        }

        public static List<Employee> GetEmployees()
        {
            List<Employee> output = new List<Employee>();

            output.Add(new Employee { Name = "Dawid", SurName = "Król", Paymant = 10_000M });
            output.Add(new Employee { Name = "John", SurName = "Smith", Paymant = 5_000M });
            output.Add(new Employee { Name = "Adam", SurName = "Lincoln", Paymant = 2_000M });

            return output;
        }

        public static void Message(decimal mess)
        {
            Console.WriteLine(mess);
        }

        public static decimal Discount(int number, decimal cost)
        {
            return cost - (number * 500);
        }
    }
}
