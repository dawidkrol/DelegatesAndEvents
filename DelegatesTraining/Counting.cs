using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegatesTraining
{
    public class Counting
    {
        public static decimal PayDay(List<Employee> employees, Action<decimal> action, Func<int, decimal, decimal> func)
        {
            decimal fullCost = employees.Sum(x => x.Paymant);
            //Koszty całkowite
            action(fullCost);
            //Odliczanie kosztów
            decimal output = func(employees.Count, fullCost);

            return output;
        }
        public static int Employees(List<Employee> employees, Action<Employee> e)
        {
            int output = 0;
            foreach (var employee in employees)
            {
                e(employee);
                output++;
            }
            return output;
        }
    }
}
