using System;
namespace Litwarelib
{
    public class Employee
    {
        int Empno;
        String EmpName;
        double Salary, HRA, TA, DA, PF, TDS, Netsalary, GrossSalary;
        public Employee(int empno, string empname, double salary)
        {
            this.Empno = empno;
            this.EmpName = empname;
            this.Salary = salary;

        }
        public void CalculateGrossSalary(double Salary)
        {
            if (Salary < 5000)
            {
                HRA = 0.10 * Salary;
                TA = 0.05 * Salary;
                DA = 0.15 * Salary;
            }
            else if (Salary >= 5000 && Salary < 10000)
            {
                HRA = 0.15 * Salary;
                TA = 0.10 * Salary;
                DA = 0.20 * Salary;
            }
            else if (Salary >= 10000 && Salary < 15000)
            {
                HRA = 0.20 * Salary;
                TA = 0.15 * Salary;
                DA = 0.25 * Salary;
            }
            else if (Salary >= 15000 && Salary < 20000)
            {
                HRA = 0.25 * Salary;
                TA = 0.20 * Salary;
                DA = 0.30 * Salary;
            }
            else
            {
                HRA = 0.30 * Salary;
                TA = 0.25 * Salary;
                DA = 0.35 * Salary;
            }
            GrossSalary = Salary + HRA + TA + DA;
            CalculateSalary(GrossSalary);
        }
        public void CalculateSalary(double GrossSalary)
        {
            PF = 0.10 * GrossSalary;
            TDS = 0.18 * GrossSalary;
            Netsalary = GrossSalary - (PF + TDS);
        }
        public void Displaydetails()
        {
            Console.WriteLine();
            Console.WriteLine("Employee details:");
            Console.WriteLine();
            Console.WriteLine("Employee name: {0}", EmpName);
            Console.WriteLine("Employee No:   {0}", Empno);
            Console.WriteLine("Salary:        {0}", Salary);
            Console.WriteLine("HRA:           {0}", HRA);
            Console.WriteLine("TA:            {0}", TA);
            Console.WriteLine("DA:            {0}", DA);
            Console.WriteLine("PF:            {0}", PF);
            Console.WriteLine("TDS:           {0}", TDS);
            Console.WriteLine("Net Salary:    {0}", Netsalary);
            Console.WriteLine("Gross Salary:  {0}", GrossSalary);
        }
      
    }
}
