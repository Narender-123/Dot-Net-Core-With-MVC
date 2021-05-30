using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Employee5
    {
        public int ID { get; set; }
        public String Name { get; set; }
        
        //This is the key(Joining Key) Which we look it into the Depament with id
        public int DepartmentId { get; set; }

        public static List<Employee5> GetAllEmployees()
        {
            return new List<Employee5>
            {
                new Employee5 { ID = 1, Name = "Mark", DepartmentId = 1 },
                new Employee5 { ID = 2, Name = "Steve", DepartmentId = 2 },
                new Employee5 { ID = 3, Name = "Ben", DepartmentId = 1 },
                new Employee5 { ID = 4, Name = "Philip", DepartmentId = 1 },
                new Employee5 { ID = 5, Name = "Mary", DepartmentId = 2 },
                new Employee5 { ID = 6, Name = "Valarie", DepartmentId = 2 },
                new Employee5 { ID = 7, Name = "John", DepartmentId = 1 },
                new Employee5 { ID = 8, Name = "Pam", DepartmentId = 1 },
                new Employee5 { ID = 9, Name = "Stacey", DepartmentId = 2 },
                new Employee5 { ID = 10, Name = "Andy", DepartmentId = 1},
                new Employee5 { ID = 11, Name = "Bernard"}
            };
        }
    }
}
