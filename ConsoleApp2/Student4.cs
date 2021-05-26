using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Student4
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }

        public static List<Student4> GetAllStudetns()
        {
            List<Student4> listStudents = new List<Student4>
        {
            new Student4 { StudentID= 101, Name = "Tom", TotalMarks = 800 },
            new Student4 { StudentID= 102, Name = "Mary", TotalMarks = 900 },
            new Student4 { StudentID= 103, Name = "Pam", TotalMarks = 800 },
            new Student4 { StudentID= 104, Name = "John", TotalMarks = 800 },
            new Student4 { StudentID= 105, Name = "John", TotalMarks = 800 },
            new Student4 { StudentID= 106, Name = "Brian", TotalMarks = 700 },
            new Student4 { StudentID= 107, Name = "Jade", TotalMarks = 750 },
            new Student4 { StudentID= 108, Name = "Ron", TotalMarks = 850 },
            new Student4 { StudentID= 109, Name = "Rob", TotalMarks = 950 },
            new Student4 { StudentID= 110, Name = "Alex", TotalMarks = 750 },
            new Student4 { StudentID= 111, Name = "Susan", TotalMarks = 860 },
        };

            return listStudents;
        }
    }
}

