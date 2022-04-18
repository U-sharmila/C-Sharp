using System;
namespace Employee_Management_System
{
    interface IPrintable
    {
        void DisplayManagerdetails();
        void DisplayMarketingExecdetails();
    }

    public class Employee : IPrintable
    {
        public string FirstName, LastName, Designation;
        public float GrossSalary, NetSalary;
        protected Employee()
        {
            this.FirstName = "";
            this.LastName = "";
            this.Designation = "";
            this.GrossSalary = 0.0F;
            this.NetSalary = 0.0F;  
        }

        protected Employee(string FName, string LName, string designation, float Salary)
        {
            this.FirstName = FName;
            this.LastName = LName;
            this.Designation = designation;
            this.NetSalary = Salary;
        }

        public virtual void CalculateSalary()
        {

        }
        public void DisplayManagerdetails()
        {
            Console.WriteLine("EMPLOYEE DETAILS: ");
            Console.WriteLine("NAME: {0} {1}", FirstName, LastName);
            Console.WriteLine("DESIGNATION: {0}", Designation);
            Console.WriteLine("Gross Salary: {0}", GrossSalary);
            Console.WriteLine("Net Salary:{0}\n", NetSalary);
        }
        public void DisplayMarketingExecdetails()
        {
            Console.WriteLine("EMPLOYEE DETAILS: ");
            Console.WriteLine("NAME: {0} {1}", FirstName, LastName);
            Console.WriteLine("DESIGNATION: {0}", Designation);
            Console.WriteLine("Gross Salary: {0}", GrossSalary);
            Console.WriteLine("Net Salary:{0}\n", NetSalary);

        }
    }
    public class Manager: Employee
    {
        private float Petrol_Allowance, Food_Allowance, Other_Allowance;
        public Manager(string FName, string LName, string designation, float Salary):base(FName,LName,designation,Salary)
        {
            this.Petrol_Allowance = 0.08F;
            this.Food_Allowance = 0.13F;
            this.Other_Allowance=0.03F;
        }
        public override void CalculateSalary()
        {
            GrossSalary = (1 + Petrol_Allowance + Food_Allowance + Other_Allowance)* NetSalary;
        }
    }
    public class MarketingExecutive: Employee
    {
        private float Kilometer_Travel, Tour_Allowances, Telephone_Allowances;
        public MarketingExecutive(string FName,string LName,string designation, float Salary,float Kilometers): base(FName, LName, designation, Salary)
        {
            this.Kilometer_Travel = Kilometers;
            this.Tour_Allowances = 5 * this.Kilometer_Travel;
            this.Telephone_Allowances = 1000;
        }
        public override void CalculateSalary()
        {
            GrossSalary = NetSalary + Kilometer_Travel + Tour_Allowances + Telephone_Allowances;
        }
    }
    class EmpManagengement

    {
        static void Main()
        {
            Employee emp;
            emp = new Manager("Rishi", "Malhotra", "Manager", 234500);
            emp.CalculateSalary();
            emp.DisplayManagerdetails();
            emp = new MarketingExecutive("Jennifer", "Morris", "Marketing Executive", 234000,10);
            emp.CalculateSalary();
            emp.DisplayMarketingExecdetails();
        }
    }
}
