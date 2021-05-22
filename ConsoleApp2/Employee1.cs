using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Employee1
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int  AnnualSalary  { get; set; }

        public static List<Employee1> GetAllEmployees() 
        {
            List<Employee1> employees = new List<Employee1>
            {
                new Employee1
                {
                    Id = 101,
                    FirstName = "Steve",
                    LastName = "Smith",
                    Gender = "Male",
                     AnnualSalary  = 50000
                },
                new Employee1
                {
                    Id = 102,
                    FirstName = "Ricky",
                    LastName = "ponting",
                    Gender = "Male",
                     AnnualSalary  = 60000
                },
                new Employee1
                {
                    Id = 103,
                    FirstName = "Ellyse",
                    LastName = "Perry",
                    Gender = "Female",
                     AnnualSalary  = 80000
                },
                new Employee1
                {
                    Id = 104,
                    FirstName = "Mitcheal",
                    LastName = "Johnson",
                    Gender = "Male",
                     AnnualSalary  = 54000
                },
                new Employee1
                {
                    Id = 105,
                    FirstName = "Shane",
                    LastName = "Watson",
                    Gender = "Male",
                     AnnualSalary  = 90000
                },
                new Employee1
                {
                    Id = 106,
                    FirstName = "Beth",
                    LastName = "Monney",
                    Gender = "Feale",
                    AnnualSalary   = 95000
                }
            };
            return employees;
        }
    }
}
