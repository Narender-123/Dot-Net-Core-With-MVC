//GroupBy operator belong to Grouping Operators category.
//This operator takes a flat sequence of items, organize that sequence into groups (IGrouping<K, V>) based on a specific key and return groups of sequences.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class GroupingOpeartor
    {
        static void Main1()
        {
            //Example 1: Get Employee Count By Department-----------------------------------------------------------------------------------------------
            //GroupBy creates and returns a sequence of IGrouping<K,V>
            var employeeGroups11 = Employee4.GetAllEmployees().GroupBy(emp => emp.Department); //This is the Sequence of Groups
            var employeeGroups12 = from employee in Employee4.GetAllEmployees()
                                 group employee by employee.Department;

            //Here Every group having a key and all the Employees having that key is the part of that group
            //group share the same key bcoz they have same type/motive
            foreach (var group in employeeGroups12)
            {
                Console.WriteLine("{0}-{1}",group.Key,group.Count());
            }
            Console.WriteLine("");

            //Example 2: Get Employee Count of Male Employee By Department-----------------------------------------------------------------------------------------------
            foreach (var group in employeeGroups11)
            {
                Console.WriteLine("{0}=>Female:{1}", group.Key, group.Count(x => x.Gender=="Female"));
                //Console.WriteLine("{0}=>Max Salary={1}", group.Key, group.Max(x => x.Salary));
                //Console.WriteLine("{0}=>Min Salary={1}", group.Key, group.Min(x => x.Salary));
                //Console.WriteLine("{0}=>Total Salary={1}", group.Key, group.Sum(x => x.Salary));

            }

            //Example 3: Get Employee Count By Department and also each employee and department name-----------------------------------------------------------
            foreach (var group in employeeGroups12)
            {
                Console.WriteLine("{0}-{1}", group.Key, group.Count());
                Console.WriteLine("------------------------");
                foreach (Employee4 employee in group)
                {
                    Console.WriteLine(employee.Name +"\t\t"+employee.Department);
                }
                Console.WriteLine(); Console.WriteLine();
            }

            //Example 4: Get Employee Count By Department and also each employee and department name. Data should be sorted first by Department in ascending order and then by Employee Name in ascending order.
            var employeeGroups13 = from employee in Employee4.GetAllEmployees()
                                   group employee by employee.Department into eGroup
                                   orderby eGroup.Key
                                   select new
                                   {
                                       Key = eGroup.Key,
                                       Employees = eGroup.OrderBy(x => x.Name)
                                   };
            foreach (var group in employeeGroups13)
            {
                Console.WriteLine("{0}-{1}", group.Key, group.Employees.Count());
                Console.WriteLine("------------------------");
                foreach (Employee4 employee in group.Employees)
                {
                    Console.WriteLine(employee.Name + "\t\t" + employee.Department);
                }
                Console.WriteLine(); Console.WriteLine();
            }
            Console.WriteLine("Grouping by Multiple Keys");

            //Grouping by multiple keys: In LINQ, an anonymous type is usually used when we want to group by multiple keys.------------------------------------
            // Task1 => Group employees by Department and then by Gender.
            //Task2 => The employee groups should be sorted first by Department and then by Gender in ascending order.
            //Task3 = >Also, employees within each group must be sorted in ascending order by Name.

            //Linq Synatx:
            var employeeGroups14 = Employee4.GetAllEmployees()
                .GroupBy(emp => new { emp.Department, emp.Gender})              //This Line Create Four Groups by the Combinations of two keys(Department and Gender)
                .OrderBy(group => group.Key.Department).ThenBy(group => group.Key.Gender)
                .Select(group => new 
                {
                    Dept = group.Key.Department,
                    Gender = group.Key.Gender,
                    Employees = group.OrderBy(emp => emp.Name)
                });

            //SQL Like Syntax:
            var employeeGroups15 = from employee in Employee4.GetAllEmployees()
                                   group employee by new { employee.Department, employee.Gender } into egroup
                                   orderby egroup.Key.Department, egroup.Key.Gender
                                   select new
                                   {
                                       Dept = egroup.Key.Department,
                                       Gender = egroup.Key.Gender,
                                       Employees = egroup.OrderBy(emp => emp.Name)
                                   };


            foreach (var group in employeeGroups15)
            {
                Console.WriteLine("{0} Department {1} Employee Count = {2}", group.Dept,group.Gender,group.Employees.Count());
                Console.WriteLine("----------------------------------------");
                foreach(var employee in group.Employees)
                {
                    Console.WriteLine(employee.Name+"\t\t"+employee.Gender+"\t\t"+employee.Salary);
                }
                Console.WriteLine(); Console.WriteLine();
            }

        }
    }
}
