using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinqDeom1
{
    public class Student1
    {
        public int Id { get; set; }
        public String  Name { get; set; }
        public String  Gender { get; set; }

        public static List<Student1> GetAllStudents() 
        {
            List<Student1> students = new List<Student1>();
            //----------------------------------------------
            Student1 s1 = new Student1
            {
                Id = 101,
                Name = "Narender Tanwar",
                Gender = "Male"
            };
            students.Add(s1);

            Student1 s2 = new Student1
            {
                Id = 102,
                Name = "Deepak Tanwar",
                Gender = "Male"
            };
            students.Add(s2);

            Student1 s3 = new Student1
            {
                Id = 103,
                Name = "John",
                Gender = "Male"
            };
            students.Add(s3);

            Student1 s4 = new Student1
            {
                Id = 104,
                Name = "Jenny",
                Gender = "FeMale"
            };
            students.Add(s4);

            //----------------------------------------------
            return students;
        }
    }
}