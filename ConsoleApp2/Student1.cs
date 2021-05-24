using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Student1
    {               
        public string Name { get; set; }
        public string  Gender { get; set; }
        public List<string> Subjects { get; set; }

        public static List<Student1> GetAllStudents()
        {
            List<Student1> students = new List<Student1>
            {
                new Student1
                {
                    Name ="Narender",
                    Gender ="Male",
                    Subjects = new List<string>{"C#","Java","Python","C++"}
                },
                new Student1
                {
                    Name ="Jitender",
                    Gender ="Male",
                    Subjects =new List<string>{"Asp.net","Asp.net Core","Ado.net"}
                },new Student1
                {
                    Name ="Harshit Verma",
                    Gender ="Male",
                    Subjects =new List<string>{"C#","Java","Python", "WCF", "SQL Server"}
                },new Student1
                {
                    Name ="Deepak Tanwar",
                    Gender ="Male",
                    Subjects =new List<string>{"PHP","Html","CSS","JavaScript","Ajax","Jquery","Mysql"}
                },new Student1
                {
                    Name ="Reema Tandon",
                    Gender ="Female",
                    Subjects =new List<string>{"JavaScript","Node.js","React"}
                },new Student1
                {
                    Name ="Mina Sharma",
                    Gender ="Female",
                    Subjects =new List<string>{"DataScience","AI","Python"}
                }
            };
            return students;
        }
    }
}
