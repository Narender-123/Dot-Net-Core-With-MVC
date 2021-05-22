using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main1()
        {
            try
            {
                //This Context is Responsibel For Making a Connection to the Database(it resolves a database)
                EmployeeDBContext context = new EmployeeDBContext();
                IEnumerable<Department> depratments = context.Departments.Where(dept => dept.Name == "IT" || dept.Name == "HR");
                foreach (Department dept in depratments)
                {
                    Console.WriteLine("Depratment Name =" + dept.Name);
                    IEnumerable<Employee> employees = dept.Employees.Where(emp => emp.Gender == "Male");
                    foreach (Employee emp in employees)
                    {
                        Console.WriteLine("\tEmployee Name = " + emp.FirstName + " " + emp.LastName);
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ae) { }

            //EmployeeDBContext context = new EmployeeDBContext();

            //IEnumerable<Department> departments = context.Departments
            //    .Where(dept => dept.Name == "IT" || dept.Name == "HR");

            //foreach (Department department in departments)
            //{
            //    Console.WriteLine("Department Name = " + department.Name);
            //    foreach (Employee employee in department
            //        .Employees.Where(emp => emp.Gender == "Female"))
            //    {
            //        Console.WriteLine("\tEmployee Name = " + employee.FirstName
            //            + " " + employee.LastName);
            //    }
            //    Console.WriteLine();
            //}

        }
    }
}
