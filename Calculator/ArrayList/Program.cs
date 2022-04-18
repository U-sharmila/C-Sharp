using System;
using System.Collections;
namespace ArrayLists
{
    class Employee
    {
        public int empId;
        public string empName;
        public double Salary;
        public int empid()
        {
            return this.empId;
        }
        public string empname()
        {
            return this.empName;
        }
        public double salary()
        {
            return this.Salary;
        }
    }

    class EmployeeCollection
    {
        static void Main()
        {

            ArrayList EmpList = new ArrayList();
            
            EmpList.Add(new Employee());
            ((Employee)EmpList[0]).empId = 78;
            ((Employee)EmpList[0]).empName = "Anvi";
            ((Employee)EmpList[0]).Salary = 80000;
            
            EmpList.Add(new Employee());
            ((Employee)EmpList[1]).empId = 54;
            ((Employee)EmpList[1]).empName = "Olivia";
            ((Employee)EmpList[1]).Salary = 70000;


            foreach (Employee emp in EmpList)
            {
                Console.WriteLine("Employee ID : {0}, Employee Name : {1}, Employee Dept : {2}", emp.empid(), emp.empname(), emp.salary());

            }


        }
    }
}
