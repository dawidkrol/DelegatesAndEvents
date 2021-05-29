using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesTraining
{
    public class Counting
    {
        public static decimal PayDay(List<Employee> employees,Action<decimal> action,Func<int,decimal,decimal> func)
        {
            decimal fullCost = employees.Sum(x => x.Paymant);
            //Koszty całkowite
            action(fullCost);
            //Odliczanie
            decimal output = func(employees.Count,fullCost);
            return output;
        }
    }
}
