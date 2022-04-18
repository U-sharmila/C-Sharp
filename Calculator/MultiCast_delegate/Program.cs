using System;
using Employee_Management_System;

namespace MultiCast_delegate
{
    public delegate void EmployeeDelegate();
    public class Program
    {
        static void Main()
        {
            Employee emp1 = new Manager("Rishi", "Malhotra", "Manager", 234500);
            emp1.CalculateSalary();
            Employee emp2 = new MarketingExecutive("Aditi", "Suresh", "Marketing Executive", 234500, 10);
            emp2.CalculateSalary();
            EmployeeDelegate empDlg = new EmployeeDelegate(emp1.DisplayManagerdetails);
            empDlg += emp2.DisplayMarketingExecdetails;
            empDlg();
        }
       
        
        
    }
}
