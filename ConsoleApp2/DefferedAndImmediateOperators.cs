using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Student5
    {
        public int StudentID { get; set; }
        public string  Name { get; set; }
        public int TotalkMarks { get; set; }
    }
    class DefferedAndImmediateOperators
    {
        static void Main1()
        {
            List<Student5> students = new List<Student5>
            {
                new Student5{ StudentID = 101, Name = "Narender", TotalkMarks=800},
                new Student5{ StudentID = 102, Name = "Deepak", TotalkMarks=800},
                new Student5{ StudentID = 103, Name = "Jitender", TotalkMarks=800},
                new Student5{ StudentID = 104, Name = "Harshit", TotalkMarks=800},
                new Student5{ StudentID = 105, Name = "Akshay", TotalkMarks=900},
                new Student5{ StudentID = 106, Name = "Abhishek", TotalkMarks=700},
                new Student5{ StudentID = 107, Name = "Pushpendra", TotalkMarks=1100}
            };

            // LINQ Query is only defined here and is not executed at this point----------------------------------------------------------------------------------------
            // If the query is executed at this point, the student0 should not display Tim
            IEnumerable<Student5> students1 = from stu in students
                                              where stu.TotalkMarks == 800
                                              select stu;
            students.Add(new Student5 { StudentID = 108, Name = "Tim", TotalkMarks = 800 });
            //The above query id defined with deffreed/lazy operators thats why it not excecute Immedatily, It Excecute at the time of iteration
            foreach (Student5 student in students1)
            {
                Console.WriteLine(student.Name+"\t"+student.TotalkMarks);
            }
            Console.WriteLine("========================================================================================================================================");

            //Immediate Operators will exceute the Query Immediately----------------------------------------------------------------------------------------------------
            IEnumerable<Student5> students2 = (from stu in students
                                              where stu.TotalkMarks == 800
                                              select stu).ToList();
            students.Add(new Student5 { StudentID = 108, Name = "Pop", TotalkMarks = 800 });
            foreach (Student5 student in students2)
            {
                Console.WriteLine(student.Name + "\t" + student.TotalkMarks);
            }
        }
    }
}
