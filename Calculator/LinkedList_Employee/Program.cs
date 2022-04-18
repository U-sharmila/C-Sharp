using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Employee
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }
    public class Employees
    {
        public static void Main()
        {
            Employee employee1 = new Employee()
            {
                EmpId = 100,
                Name = "Olivia",
                Salary = 50000
            };
            Employee employee2 = new Employee()
            {
                EmpId = 102,
                Name = "Jeo been",
                Salary = 60000
            };
            Employee employee3 = new Employee()
            {
                EmpId = 102,
                Name = "Lee Song",
                Salary = 70000
            };
            Employee employee4 = new Employee()
            {
                EmpId = 102,
                Name = "Siddharth",
                Salary = 50000
            };
            List<Employee> employees = new List<Employee>(2);
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            
            foreach (Employee employee in employees)
            {
                Console.WriteLine("EmpId ={0}, Name={1}, Salary={2}", employee.EmpId, employee.Name, employee.Salary);
            }
            Console.Write("Total number of Employees: ");
            Console.WriteLine(employees.Count);

        }
    }
    }

        
