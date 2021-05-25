using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class OrderingOperator
    {
        static void Main1() {
            //The Student List Before applyin the Sorting Ordering Operator
            Console.WriteLine("Before Sorting the List of Student :");
            IEnumerable<Student2> students0 = Student2.GetAllStudents();
            foreach (Student2 student in students0)
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine();

            //Orderby Operator in Linq Query:
            Console.WriteLine("After Sorting(Ascending) the List of Student :");
            IOrderedEnumerable<Student2> students1 = Student2.GetAllStudents().OrderBy(stu => stu.Name);
            foreach (Student2 student in students1)
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine();

            //OrderByDescending Operator in Linq Query:
            Console.WriteLine("After Sorting(Descending) the List of Student :");
            IOrderedEnumerable<Student2> students2 = Student2.GetAllStudents().OrderByDescending(stu => stu.Name);
            foreach (Student2 student in students2)
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine();

            //OrderBy Operator in Sql Like Query:
            Console.WriteLine("After Sorting(Ascending) the List of Student using Sql Like Queires:");
            IEnumerable<Student2> students3 = from student in Student2.GetAllStudents()
                                              orderby student.Name
                                              select student;
            foreach (Student2 student in students3)
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine();

            //OrderBy Operator in Sql Like Query:
            Console.WriteLine("After Sorting(Descending) the List of Student using Sql Like Queires:");
            IEnumerable<Student2> students4 = from student in Student2.GetAllStudents()
                                              orderby student.Name descending
                                              select student;
            foreach (Student2 student in students2)
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine();

        }
    }
}
