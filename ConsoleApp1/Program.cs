using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void main1()
        {
            String name = "Narender";

            //Here we understand what is the Extension method and to make them Extension Method we had to make use of HelperClass(Wrapper Class) that we create 
            String result = name.ChangeFirstLetterCase();

            //Wrapper Class(HelperClass) is Used to get the Desired output
            //String result = StringHelper.ChangeFirstLetterCase(name);

            Console.Write(result+"\n");
            
            Console.WriteLine("List1 By Using Extension Method");
            List<int> Numbers = new List<int> {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30};
            //Linq Extension Method
            IEnumerable<int> result1 = Numbers.Where(n => n%2==0);
            foreach (int number in result1) 
            {
                Console.Write(number+" ");
            }

            Console.WriteLine("\n List1 By Using Helper Method");
            //Helper  Metho Like
            IEnumerable<int> result2 = Enumerable.Where(Numbers,n => n % 2 == 0);
            foreach (int number in result2)
            {
                Console.Write(number + " ");
            }
        }
    }
}
