using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class LeftJoinOperator
    {
        static void Main1()
        {
            //Sql Like Syntax :
            var result1 = from e in Employee5.GetAllEmployees()
                         join d in Department1.GetAllDepartments()
                         on e.DepartmentId equals d.Id into eGroup
                         from dept in eGroup.DefaultIfEmpty()
                         select new
                         {
                             EmployeeName = e.Name,
                             DepartmentName = dept == null ? "No Department" : dept.Name,
                         };

            //Extension Method Syntax: Here we Use GroupJoin to Perform the Left Join
            var result2 = Employee5.GetAllEmployees()
                                   .GroupJoin(Department1.GetAllDepartments(),
                                              emp => emp.DepartmentId,
                                              dept => dept.Id,
                                              (emp, depts) => new
                                              {
                                                  emp,
                                                  depts
                                              })
                                   .SelectMany(z => z.depts.DefaultIfEmpty(),
                                               (a, department) => new
                                               {
                                                   EmployeeName = a.emp.Name,
                                                   DepartmentName = department == null ? "Not Having Department" : department.Name
                                               }); 

            foreach (var employee in result1)
            {
                Console.WriteLine(employee.EmployeeName+"\t\t\t"+employee.DepartmentName);
            }
        }
    }
}
