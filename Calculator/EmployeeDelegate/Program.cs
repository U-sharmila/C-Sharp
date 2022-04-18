using System;
using Employee_Management_System;
namespace EmployeeDelegate
{
    public delegate void Employee_Delegate();
    internal class delegates
    {
        static void Main(string[] args)
        {
            Employee emp=new Manager("Rishi", "Malhotra", "Manager", 234500);
            emp.CalculateSalary();
            Employee_Delegate empDlg = new Employee_Delegate(emp.DisplayManagerdetails);
            empDlg();
        }  
    }
}
