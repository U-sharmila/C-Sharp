using System;
using Litwarelib;

namespace Employee_Details
{
    class program
    {
        static void Main()
        {
            int eno;
            string ename;
            double Sal;
            Console.WriteLine("enter employee No: ");
            eno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter employee Name: ");
            ename = Console.ReadLine();
            Console.WriteLine("enter employee Salary: ");
            Sal = Convert.ToDouble(Console.ReadLine());
            Employee e = new Employee(eno, ename, Sal);
            e.CalculateGrossSalary(Sal);
            e.Displaydetails();

        }
    }
}