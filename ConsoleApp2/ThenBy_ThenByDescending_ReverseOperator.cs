//OrderBy or OrderByDescending work fine when we want to sort a collection just by one value or expression. 
//If want to sort by more than one value or expression, that's when we use ThenBy or ThenByDescending along with OrderBy or OrderByDescending.
//OrderBy or OrderByDescending performs the primary sort. ThenBy or ThenByDescending is used for adding secondary sort. Secondary Sort operators (ThenBy or ThenByDescending ) can be used more than once in the same LINQ query.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ThenBy_ThenByDescending_ReverseOperator
    {
        static void  Main()
        {
            //The Linq Query to Get All the Students--------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Before Sorting:");
            IEnumerable<Student3> students0 = Student3.GetAllStudetns();
            foreach (Student3 stu in students0)
            {
                Console.WriteLine(stu.TotalMarks+"\t"+stu.Name+"\t"+stu.StudentID);
            }
            Console.WriteLine();

            //+++++++++++++++++++++++++++++++++++++++++++++++++Sorting By Using Primary and Secondary Sort +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            //a) Sorts Students first by TotalMarks in ascending order(Primary Sort)
            //b) The 4 Students with TotalMarks of 800, will then be sorted by Name in ascending order(First Secondary Sort)
            //c) The 2 Students with Name of John, will then be sorted by StudentID in ascending order(Second Secondary Sort)
            Console.WriteLine("Sorted Order by using Linq:");
            IOrderedEnumerable<Student3> students1 = Student3.GetAllStudetns().OrderBy(stu => stu.TotalMarks).ThenBy(stu => stu.Name).ThenByDescending(stu => stu.StudentID);
            foreach (Student3 stu in students1)
            {
                Console.WriteLine(stu.TotalMarks + "\t" + stu.Name + "\t" + stu.StudentID);
            }
            Console.WriteLine();

            //Implementation of above Query by Using Sql Like Query-----------------------------------------------------------------------------------------------------
            Console.WriteLine("Sorted Order by using Sql Like Queries:");
            IOrderedEnumerable<Student3> students2 = from stu in Student3.GetAllStudetns()
                                                     orderby stu.TotalMarks, stu.Name, stu.StudentID descending
                                                     select stu;
            foreach (Student3 stu in students2)
            {
                Console.WriteLine(stu.TotalMarks + "\t" + stu.Name + "\t" + stu.StudentID);
            }
            Console.WriteLine();

            //Reversing of the Collection of Student--------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Before Revsering:");
            IEnumerable<Student3> students3 = Student3.GetAllStudetns();
            foreach (Student3 stu in students3)
            {
                Console.WriteLine(stu.StudentID + "\t" + stu.Name + "\t" + stu.TotalMarks);
            }
            Console.WriteLine();

            Console.WriteLine("After Revsering:");
            IEnumerable<Student3> result0 = students3.Reverse();
            foreach (Student3 stu in result0)
            {
                Console.WriteLine(stu.StudentID + "\t" + stu.Name + "\t" + stu.TotalMarks);
            }
        }
    }
}
