using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Department1
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public static List<Department1> GetAllDepartments()
        {
            return new List<Department1>
            {
                new Department1{ Id = 1, Name = "IT"},
                new Department1 { Id = 2, Name = "HR" },
                new Department1{ Id = 3, Name = "Payroll"}
        };
        }
    }
}
