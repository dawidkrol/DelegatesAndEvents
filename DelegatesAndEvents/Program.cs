using DelegatesTraining;
using EventsTraining;
using System;
using System.Collections.Generic;
using EventsTraining.Version2;

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

            //Item item = new Item { Name = "Car", price = 50_000 };
            //Item item2 = new Item { Name = "Cat", price = 10 };
            //Item.PriceChanged += Item_PriceChanged;
            //item.PriceEvent += Item_PriceEvent;
            //item.price = 20_000;
            //item2.price = 5;

            //Console.WriteLine(item.price);

            //Func<int, int> sqr = (x) => x * x;
            //Console.WriteLine(sqr(3));

            EventsTraining.Version2.Item item = new EventsTraining.Version2.Item(15,"Apple");
            item.PropertyChanged += Item_PropertyChanged;
            item.price = 10.1M;
            Console.WriteLine(item.Name);
            item.Name = "Name";
        }

        private static void Item_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Console.WriteLine($"{e.PropertyName} had changed");
        }

        private static void Item_PriceEvent(object sender, decimal e) => Console.WriteLine("Throwing price");

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
