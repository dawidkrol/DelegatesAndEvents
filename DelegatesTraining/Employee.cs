using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesTraining
{
#pragma warning disable CS1591
    public class Employee
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public decimal Paymant { get; set; }
        public static string operator +(Employee a, Employee b) => a.Name + b.Name;
        public override string ToString()
        {
            return $"{Name} {SurName}";
        }
    }
}
