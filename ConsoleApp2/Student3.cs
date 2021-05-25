using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Student3
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }

        public static List<Student3> GetAllStudetns()
        {
            List<Student3> listStudents = new List<Student3>
        {
            new Student3
            {
                StudentID= 101,
                Name = "Tom",
                TotalMarks = 800
            },
            new Student3
            {
                StudentID= 102,
                Name = "Mary",
                TotalMarks = 900
            },
            new Student3
            {
                StudentID= 103,
                Name = "Pam",
                TotalMarks = 800
            },
            new Student3
            {
                StudentID= 104,
                Name = "John",
                TotalMarks = 800
            },
            new Student3
            {
                StudentID= 105,
                Name = "John",
                TotalMarks = 800
            },
        };

            return listStudents;
        }
    }
}
