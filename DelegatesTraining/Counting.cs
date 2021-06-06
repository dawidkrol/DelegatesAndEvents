using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegatesTraining
{
    public class Counting
    {
        /// <summary>
        /// Counting how much monay you need on payday
        /// </summary>
        /// <param name="employees">List of employees</param>
        /// <param name="action">Delegate showing full cost</param>
        /// <param name="func">Delegate which is counting actual cost</param>
        /// <returns>Employees cost after special counting</returns>
        public static decimal PayDay(List<Employee> employees, Action<decimal> action, Func<int, decimal, decimal> func)
        {
            decimal fullCost = employees.Sum(x => x.Paymant);
            //Koszty całkowite
            action(fullCost);
            //Odliczanie kosztów
            decimal output = func(employees.Count, fullCost);

            return output;
        }
        /// <summary>
        /// Counting eployees
        /// </summary>
        /// <param name="employees">List of employees</param>
        /// <param name="e">Delegate, which is showing employees</param>
        /// <returns>Number of employees</returns>
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
