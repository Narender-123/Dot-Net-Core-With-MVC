using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class SelectManyOperator2
    {
        //SelectMany Operator belong to Projection Operators category. It is used to project each element of a sequence to an IEnumerable<T> and flattens the resulting sequences into one sequence.
        static void Main1()
        {
            //Return all the Subject List------------------------------------------------------------------------------------------------------------------------------------------------------------------
            IEnumerable<string> Subjects10 = Student1.GetAllStudents().SelectMany(stu => stu.Subjects); //This will return all the subjects of all the students repeatidly
            IEnumerable<string> Subjects11 = Student1.GetAllStudents().SelectMany(stu => stu.Subjects).Distinct();
            foreach (string subject in Subjects11)
            {
                //Console.WriteLine(subject);
            }

            //Return all the Subjects by using a SQl Query Like Patteren-------------------------------------------------------------------------------------------------------------------------------------
            IEnumerable<string> Subjects20 = from student in Student1.GetAllStudents()
                                           from subject in student.Subjects
                                           select subject;          //This will return all the subjects of all the students repeatidly

            IEnumerable<string> Subjects21 = (from student in Student1.GetAllStudents()
                                            from subject in student.Subjects
                                            select subject).Distinct();          //This will return all the subjects of all the students repeatidly
            foreach (string subject in Subjects21)
            {
                //Console.WriteLine(subject);
            }

            //How we write all the Subjects- Student Name Side by side by using Linq Query----------------------------------------------------------------------------------------------------------------------
            var result30 = Student1.GetAllStudents().SelectMany(stu => stu.Subjects, (student, subject) => new
            {
                StudentName = student.Name,
                SubjectName = subject
            });
            foreach (var v in result30)
            {
                Console.WriteLine("{0} - {1} ", v.StudentName, v.SubjectName);
            }
            Console.WriteLine(result30.Count());

            //How we write all the Subjects- Student Name Side by side by using Sql Like Query--------------------------------------------------------------------------------------------------------------------
            var result31 = from student in Student1.GetAllStudents()
                           from subject in student.Subjects
                           select new {SubjectName = student.Name, StudentName = subject};
            
            foreach (var v in result31)
            {
               //Console.WriteLine("{0} - {1} ", v.StudentName, v.SubjectName);
            }
           // Console.WriteLine(result31.Count());

            //Write the Alphabet Series and the Numbers in the String Array---------------------------------------------------------------------------------------------------------------------------------------
            String[] stringArray = 
            {
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
                "0123456789"
            };

            IEnumerable<char> result1 = stringArray.SelectMany(s => s);
            foreach (char c in result1)
            {
                //Console.WriteLine(c);
            }

            //we can also rewrite the above result by using Sql Like Patteren-------------------------------------------------------------------------------------------------------------------------------------
            IEnumerable<char> result2 = from chs in stringArray
                                        from ch in chs
                                        select ch;
            foreach (char ch in result2)
            {
                //Console.WriteLine(ch);
            }

        }
    }
}
