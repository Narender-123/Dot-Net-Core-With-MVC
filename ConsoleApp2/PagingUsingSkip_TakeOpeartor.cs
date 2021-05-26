//https://jasonwatmore.com/post/2018/10/17/c-pure-pagination-logic-in-c-aspnet

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class PagingUsingSkip_TakeOpeartor
    {
        static void Main()
        {
            IEnumerable<Student4> students = Student4.GetAllStudetns();
            do
            {
                int total = students.Count();
                int pageSize = 3;
                int totalPages = (int)Math.Ceiling((decimal)total / (decimal)pageSize);
                int pageNumber = 0;
                Console.WriteLine("Plz Enter the Page Number From 1 to " + totalPages);
                if (int.TryParse(Console.ReadLine(), out pageNumber))
                {
                    if (pageNumber >= 1 && pageNumber <= totalPages)
                    {
                        IEnumerable<Student4> students0 = students.Skip((pageNumber - 1) * pageSize).Take(pageSize);
                        Console.WriteLine();
                        Console.WriteLine("Display Page Number: " + pageNumber);
                        foreach (Student4 student in students0)
                        {
                            Console.WriteLine(student.StudentID + "\t" + student.Name + "\t" + student.TotalMarks);
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Page number must be an integer between 1 and " + totalPages);
                    }
                }
                else
                {
                    Console.WriteLine("Page number must be an integer between 1 and " + totalPages);
                }
            } while (true);
        }
    }
}
