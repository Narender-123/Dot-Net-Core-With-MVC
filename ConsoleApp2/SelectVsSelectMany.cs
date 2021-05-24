using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class SelectVsSelectMany
    {
        static void Main1()
        {
            //Here we Subjects property in the Student1 class whichis a collection of strings.
            //Use of Select :
            IEnumerable<List<string>> Subjects1 = Student1.GetAllStudents().Select(stu => stu.Subjects);
            foreach (List<string> subjects in Subjects1)
            {
                foreach (string subject in subjects)
                {
                    Console.WriteLine(subject);
                }
            }

            //Use Of Select Many :
            IEnumerable<string> Subjects2 = Student1.GetAllStudents().SelectMany(stu => stu.Subjects);
            foreach (string subject in Subjects2)
            {
                Console.WriteLine(subject);
            }
        }
    }
    }
