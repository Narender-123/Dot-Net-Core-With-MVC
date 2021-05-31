using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class CrossJoin
    {
        static void Main()
        {
            //Sql Like Syntax:
            var result1 = from e in Employee5.GetAllEmployees()
                         from d in Department1.GetAllDepartments()
                         select new
                         {
                             e,
                             d
                         };
            //By Using SelectMany Opeartor or Extension Method
            var result2 = Employee5.GetAllEmployees().SelectMany(e => Department1.GetAllDepartments(),          //This will associate each employee with all the Departments
                                                                (e, d) => new { e, d });                                       //Now we have a List<Emp,Dep> in a Cross Join Format

            //By using Join Extension Method:
            var result3 = Employee5.GetAllEmployees().Join(Department1.GetAllDepartments(),
                                                           e => true,
                                                           d => true,
                                                           (e, d) => new { e, d });

            Console.WriteLine("Total Count = " + result3.Count());
            foreach (var combo in result3)
            {
               
                Console.WriteLine(combo.e.Name+"\t\t\t"+combo.d.Name);
            }
            Console.WriteLine("/////////////////////////////////////");

        }
    }
}
