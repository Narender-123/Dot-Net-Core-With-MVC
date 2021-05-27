using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Student6
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }
    }

    public class Employee2
    {
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public string City { get; set; }
    }
    class ConversionOpeartors
    {
        static void Main()
        {
            //Here we Convert the array of int to List<int> by using ToList() method which is Standered Query Operator of Category ConversionType
            Console.WriteLine("List<string> items are here:");
            int[] numbers = { 8,9,7,5,6,5,6,7};
            List<int> numbers1 = numbers.ToList();  //This also Exceute the Query Immedaitly
            foreach (int num in numbers1)
            {
                Console.Write(num+"\t");
            }
            Console.WriteLine();

            //Here we Convert the List<String> to Array of String by Using ToArray()
            //Before casting we had to get the Countries in Ascending Order
            Console.WriteLine("Array of string items are here:");
            List<string> countries = new List<String> { "US", "India", "UK", "Australia", "Canada" };
            String[] countries1 = (from country in countries
                                  orderby country ascending
                                  select country).ToArray();
            foreach (string country in countries1)
            {
                Console.Write(country + "\t");
            }
            Console.WriteLine();


            //ToDictionary operator extracts all of the items from the source sequence and returns a new Dictionary.------------------------------------------------------
            //This operator causes the query to be executed immediately. This operator does not use deferred execution.
            List<Student6> students = new List<Student6>
            {
                new Student6 { StudentID= 101, Name = "Tom", TotalMarks = 800 },
                new Student6 { StudentID= 102, Name = "Mary", TotalMarks = 900 },
                new Student6 { StudentID= 103, Name = "Pam", TotalMarks = 800 }
            };

            Console.WriteLine("Dictionary items are Here");
            //Key and Value Pair is StudentId and Name
            Dictionary<int,string> kvps0 = students.ToDictionary(stu => stu.StudentID, stu => stu.Name);
            foreach (KeyValuePair<int,string> kvp in kvps0)
            {
                Console.WriteLine(kvp.Key + "\t\t" + kvp.Value);
            }
            Console.WriteLine();

            //Key and Value Pair is StudentId and StudentObject
            Dictionary<int, Student6> kvps1 = students.ToDictionary(stu => stu.StudentID, stu => stu);
            Dictionary<int, Student6> kvps2 = students.ToDictionary(stu => stu.StudentID);              //The Two Queies are similar
            foreach (KeyValuePair<int, Student6> kvp in kvps1)
            {
                Console.WriteLine(kvp.Key + "\t\t" + kvp.Value.Name+"\t\t"+kvp.Value.TotalMarks);
            }
            Console.WriteLine();


            //ToLookup creates a Lookup. Just like a dictionary, a Lookup is a collection of key/value pairs.------------------------------------------------------------
            //A dictionary cannot contain keys with identical values, where as a Lookup can.
            //A Lookup is used to group of Certain items/employees based on the specific Col/Key inside the Collection.
            //Inside Lookup a group share the Coommon Key(which is the Criteria of grouping)
            
            List<Employee2> employees = new List<Employee2>
            {
                new Employee2() { Name = "Ben", JobTitle = "Developer", City = "London" },
                new Employee2() { Name = "John", JobTitle = "Sr. Developer", City = "Bangalore" },
                new Employee2() { Name = "Steve", JobTitle = "Developer", City = "Bangalore" },
                new Employee2() { Name = "Stuart", JobTitle = "Sr. Developer", City = "London" },
                new Employee2() { Name = "Sara", JobTitle = "Developer", City = "London" },
                new Employee2() { Name = "Pam", JobTitle = "Developer", City = "London" }
            };

            Console.WriteLine("Employee Group by Jobtitle");
            //Grouping of employess by their Job Title (i.e same jobTitle employees are grouped at one place)
            var employeesByJobTitle = employees.ToLookup(emp => emp.JobTitle);
            Console.WriteLine(); Console.WriteLine();
            foreach (var kvp in employeesByJobTitle)
            {
                Console.WriteLine(kvp.Key+": ");
                //Lookup employees by JobTitle
                foreach (var emp in employeesByJobTitle[kvp.Key])
                {
                    Console.WriteLine(emp.Name+"\t\t"+emp.JobTitle+"\t\t"+emp.Name);
                }
            }

            //Cast<T> Operator: Cast operator attempts to convert all of the items within an existing collection to another type and return them in a new collection.
            //If an item fails conversion an exception will be thrown. This method uses deferred execution.
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add("Abc");

            //Cast: Differed exceution it Follows and also Convert into the Specified type and Throw Exception
            IEnumerable<int> items1 = list.Cast<int>();
            //OfType : OfType operator will return only elements of the specified type. The other type elements are simply ignored and excluded from the result set
            IEnumerable<int> items2 = list.OfType<int>();
            foreach (int item in items2) 
            {
                Console.WriteLine(item);
            }


            //The main use of AsQueryable operator is unit testing to mock a queryable data source using an in-memory data source. We will discuss this operator in detail with examples in unit testing video series.
            EmployeeDBDataContext db = new EmployeeDBDataContext(); //Creating a Connection to the Database we are used
            var result = db.Employee3s
                .Where(emp => emp.Gender == "Male")
                .AsEnumerable()
                .OrderByDescending(emp => emp.Salary)
                .Take(5);
            Console.WriteLine("Top 5 Salaries of Male Employees");
            foreach (var emp in result)
            {
                Console.WriteLine(emp.Id + "\t\t" + emp.Name + "\t\t" + emp.Salary);
            }

        }
    }
}
