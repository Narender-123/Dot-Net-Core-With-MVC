using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ProgRestrictionOperator1
    {
        static void Main() 
        {
            //Here we Use Select Standered Query Operator to return a new List 
            IEnumerable<int> result1 = Employee1.GetAllEmployees().Select(emp => emp.Id);
            foreach (int id in result1)
            {
                Console.WriteLine(id);
            }

            //Here we use Select Operator to Project new type(Anonymous type) from the Existing list 
            var result2 = Employee1.GetAllEmployees().Select(emp => new {FirstName = emp.FirstName, LastName = emp.LastName });
            foreach (var item in result2)
            {
                Console.WriteLine("Employee Name = "+item.FirstName+" "+item.LastName);
            }

            //Here we compute the FullName and the MonthlySalary of all Employees and project these two new computed Parameters into an anonymous type
            var result3 = Employee1.GetAllEmployees().Select(emp => new 
            {
                FullName = emp.FirstName+emp.LastName,
                MonthlySalary = emp.AnnualSalary/12 
            });
            foreach (var item in result3)
            {
                Console.WriteLine("Employee FullName = " + item.FullName + "\t MonthlySalary= " + item.MonthlySalary);
            }

            //Here Give 10% Bonus to all Employees  Whose Annual salary is Greater than 50000 and project all such Employess FirstName, AnnualSalary and Computed Bonus in Annonymous type
            var result4 = Employee1.GetAllEmployees().Where(emp => emp.AnnualSalary > 50000)
                .Select(emp => new
                {
                    FirstName = emp.FirstName,
                    Salary = emp.AnnualSalary,
                    Bonus = emp.AnnualSalary * 0.1
                }); 
            foreach (var item in result4)
            {
                Console.WriteLine("Employee FirstName = " + item.FirstName + "\t AnnualSalary= " + item.Salary+ "\tBonus="+item.Bonus);
            }
        }
    }
}
