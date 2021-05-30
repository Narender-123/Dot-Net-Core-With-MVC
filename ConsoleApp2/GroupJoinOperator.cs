using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class GroupJoinOperator
    {
        static void Main1()
        {
            //Linq Syntax For GroupJoin:
            var employeesByDepartment1 = Department1.GetAllDepartments()
                                                   .GroupJoin(Employee5.GetAllEmployees(),
                                                   d => d.Id,
                                                   e => e.DepartmentId,
                                                   (department, employees) => new 
                                                   {
                                                       Department = department,
                                                       Employees = employees.OrderBy(e => e.Name)
                                                   });

            //Sql Like Syntax For GroupJoin:
            var employeesByDepartment2 = from d in Department1.GetAllDepartments()
                                         join e in Employee5.GetAllEmployees()
                                         on d.Id equals e.DepartmentId into eGroup          //Please note: Group Join uses the join operator and the into keyword to group the results of the join.
                                         select new
                                         {
                                             Department = d,
                                             Employees = eGroup.OrderBy(e => e.Name)
                                         };

            //It Something Like a List<Group> or List<Department having Employeess>
            foreach (var department in employeesByDepartment2)
            {
                Console.WriteLine(department.Department.Name);
                foreach (var employee in department.Employees)
                {
                    Console.WriteLine(" "+employee.Name);
                }
                Console.WriteLine();
            }
        }
    }
}
