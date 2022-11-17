using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_No10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Employee e1 = new Employee("emp1", 23000);
            //Employee e2 = new Employee("emp2", 24000);
            //Employee e3 = new Employee("emp3", 24000);
            //Console.WriteLine(e1);
            //Console.WriteLine(e2);
            //Console.WriteLine(e3);
            //Console.WriteLine(Employee.TotalCount());



            Employee e1 = new Employee("emp1", 23000);
            Employee e2 = new Employee("emp2", 24000);
            Employee e3 = new Employee("emp3", 24000);
            e1.CalculateSalary();
            e2.CalculateSalary();
            e3.CalculateSalary();
            Console.WriteLine(e1);
            Console.WriteLine(e2);
            Console.WriteLine(e3);
            Console.WriteLine(Employee.TotalCount());



            //Student s1 = new Student("Yogini", 67, 45, 56);
            //Student s2 = new Student("Dhanu", 70, 84, 58);
            //Student s3 = new Student("Saloni", 55, 79, 90);
            //s1.Calculate();
            //s2.Calculate();
            //s3.Calculate();

            //Console.WriteLine(s1);
            //Console.WriteLine(s2);
            //Console.WriteLine(s3);
            //Console.WriteLine(Student.TotalCount());

        }
    }
}


