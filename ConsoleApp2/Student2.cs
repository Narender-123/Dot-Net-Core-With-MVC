using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Student2
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }

        public static List<Student2> GetAllStudents()
        {
            List<Student2> students = new List<Student2>
        {
            new Student2
            {
                StudentID= 101,
                Name = "Tom",
                TotalMarks = 800
            },
            new Student2
            {
                StudentID= 102,
                Name = "Mary",
                TotalMarks = 900
            },
            new Student2
            {
                StudentID= 103,
                Name = "Valarie",
                TotalMarks = 800
            },
            new Student2
            {
                StudentID= 104,
                Name = "John",
                TotalMarks = 800
            },
        };

            return students;
        }
    }
}
