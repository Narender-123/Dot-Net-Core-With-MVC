using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class InnerJoinOperator
    {
        static void Main1()
        {
            //Here we wanna to get All the Information about an employee
            //Linq Syntax:
            var employees1 = Employee5.GetAllEmployees()
                                     .Join(Department1.GetAllDepartments(),
                                     emp => emp.DepartmentId,
                                     dept => dept.Id,
                                     (employee,department) => new           //Here we get a Combnation of the Employee and Department as result of Join
                                     {
                                         EmployeeName  = employee.Name,
                                         DepartmentName = department.Name       //In the End we get IEnumerable<AnonymousType(Employee)>
                                     });
            //Sql Like Syntax:
            var employees2 = from emp in Employee5.GetAllEmployees()
                             join dept in Department1.GetAllDepartments()
                             on emp.DepartmentId equals dept.Id
                             select new
                             {
                                 EmployeeName = emp.Name,
                                 DepartmentName = dept.Name
                             };

            //Now We have to Loop throug all the Anonymous Type in the result Collection
            foreach (var employee in employees2)
            {
                Console.WriteLine(employee.EmployeeName+"\t\t"+employee.DepartmentName);
            }
        }
    }
}
