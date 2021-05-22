using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class RestrictionOperator
    {
        static void Main1()
        {
            //Implementation of Restriction Opeartor by using Lembda Expression in the Where Operator---------------------------------
            int[] numbers = {5,2,4,8,9,6,2,5,8,5};
            IEnumerable<int> result = numbers.Where(x => (x % 2)==0);
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //Implementation of Restriction Opeartor by using Func(Deligate Function) Directely in the Where Operator---------------------------------
            //The Lembda Expression Wil Confirm the Signature of the Func that is input is ot type int and Return is bool
            Func<int, bool> predicate = x => x % 2 == 0;
            IEnumerable<int> result1 = numbers.Where(predicate);
            foreach (int i in result1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //Implementation of Restriction Opeartor by using Lembda Expression calling a Method in the Where Operator---------------------------------
            IEnumerable<int> result2 = numbers.Where(num => IsEven(num));
            foreach (int i in result2)
            {
                Console.WriteLine(i);
            }

            //Implementation of Restriction Opeartor by TSQL Like Queries------------------------------------------------------------------------------
            IEnumerable<int> result3 = from num in numbers
                                       where num % 2 == 0
                                       select num;
            foreach (int i in result3)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //Implementation of Restriction Operator Called Select(Is Used to Project new Type/Anonymous Type)----------------------------------------
            var result4 = numbers
                .Select((num,index) => new {Value = num, Index = index})
                .Where(item => item.Value%2==0);
            foreach (var item in result4)
            {
                Console.WriteLine(item.Value+"-"+item.Index);
            }
            Console.WriteLine();
            //---------------------------------------------
            var result5 = numbers
                .Select((num, index) => new { Value = num, Index = index })
                .Where(item => item.Value % 2 == 0)
                .Select(item => item.Value);
            foreach (int i in result5)
            {
                Console.WriteLine(i);
            }
        }
        private static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
    }
}
