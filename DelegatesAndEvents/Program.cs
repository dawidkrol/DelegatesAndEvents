using DelegatesTraining;
using EventsTraining;
using System;
using System.Collections.Generic;

namespace DelegatesAndEvents
{
    class Program
    {
        delegate void Del(int a);
        static void Main(string[] args)
        {
            //Console.WriteLine(Counting.PayDay(GetEmployees(), Message, Discount));

            //Console.WriteLine($"Cost after discount {Counting.PayDay(GetEmployees(), (x) =>Console.WriteLine($"Full cost {x:C2}"), Discount):C2}");

            //Console.WriteLine($"Sum of employees {Counting.Employees(GetEmployees(),Message)}");

            //Del e = Message;
            //e += Mess;
            //e(15);

            Item item = new Item { Name = "Car", price = 50_000 };
            Item item2 = new Item { Name = "Cat", price = 10 };
            Item.PriceChanged += Item_PriceChanged;
            item.price = 20_000;
            item2.price = 5;
        }

        private static void Item_PriceChanged(object sender, PriceChangedEventArgs e)
        {
            Console.WriteLine($"Price update\nOld price: {e.OldPrice:C2} \nNew price: {e.NewPrice:C2}");
        }

        public static List<Employee> GetEmployees()
        {
            List<Employee> output = new List<Employee>();

            output.Add(new Employee { Name = "Dawid", SurName = "Król", Paymant = 10_000M });
            output.Add(new Employee { Name = "John", SurName = "Smith", Paymant = 5_000M });
            output.Add(new Employee { Name = "Adam", SurName = "Lincoln", Paymant = 2_000M });

            return output;
        }

        public static void Message<T>(T mess)
        {
            Console.WriteLine(mess);
        }

        public static void Mess(int a)
        {
            Console.WriteLine($"Mess: {a}");
        }

        public static decimal Discount(int number, decimal cost)
        {
            return cost - (number * 500);
        }
    }
}
