using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_No10
{
    public class Employee
    {
        private int id;
        private string name;
        private double basicsalary, hra, da, pf, netpaid;
        private static int count;

        public Employee(string name, double basicsalary)
        {
            count++;
            this.id = count;
            this.name = name;
            this.basicsalary = basicsalary;
        }
        public void CalculateSalary()
        {
            hra = (basicsalary * 40) / 100;
            da = (basicsalary * 20) / 100;
            pf = (basicsalary * 12) / 100;
            netpaid = (hra + da + basicsalary) - pf;
        }

        public static string TotalCount()
        {
            return $"Total count is {count}";
        }

        public override string ToString()
        {
            return $"Id :{id} Name :{name} Salary : {basicsalary} Netpaid : {netpaid}";
        }
    }
}
