using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ElementOperators
    {
        static void Main1()
        {
            //Example 1: Returns the first element from the sequence-------------------------------------------------------------------------------------------
            int[] numbers1 = {1,2,3,4,5,6,7,8};
            int result1 = numbers1.First();
            Console.WriteLine(result1);

            //Example 2: Returns the first element from the sequence based on the Specified Condition in the predicate
            int result2 = numbers1.First(x => x%2==0);
            Console.WriteLine(result2);

            //System.InvalidOperationException is thrown if no element in the array or no matching condition is found

            //FirstOrDefault : This is very similar to First, except that this method does not throw an exception when there are no elements in the sequence or when no element satisfies the condition specified by the predicate.
            int[] numbers2 = { };
            int[] numbers3 = {1,3,5,7,9};
            int result3 = numbers2.FirstOrDefault();
            int result4 = numbers3.FirstOrDefault(x => x%2==0);
            Console.WriteLine(result3+"\t\t"+result4);

            //Last : Very similar to First, except it returns the last element of the sequence.
            //LastOrDefault: Very similar to FirstOrDefault, except it returns the last element of the sequence.
            int result5 = numbers3.Last();
            Console.WriteLine(result5);

            int result6 = numbers2.LastOrDefault();
            Console.Write(result6+" \t\t");

            int result7 = numbers3.LastOrDefault(x => x%2==0);
            Console.WriteLine(result7);

            //ElementAt : Returns an element at a specified index.-----------------------------------------------------------------------------------------------
            //If the sequence is empty or if the provided index value is out of range, then an ArgumentOutOfRangeException is thrown.
            int result8 = numbers1.ElementAt(5);
            Console.WriteLine(result8);

            //int result9 = numbers2.ElementAt(0);  //Exception : Index out of Range
            //int result10 = numbers3.ElementAt(8);  //Exception : Index out of Range

            int result9 = numbers2.ElementAtOrDefault(0);  
            int result10 = numbers3.ElementAtOrDefault(8);
            Console.WriteLine(result9+"\t\t"+result10);

            //Single : There are 2 overloaded versions of this method.
            //The first overloaded version that does not have any parameters returns the only element of the sequence.
            //Single() method throws an exception if the sequence is empty or has more than one element.

            int[] numbers4 = { 8 };
            int result11 = numbers4.Single();   //it also confirms the Single Element is taken or excepted by this method
            Console.WriteLine(result11);

            //int result12 = numbers1.Single(); //Exception: Sequence Contains More than One Element
            // int result13 = numbers2.Single(); //Exception : Sequence Contains no element

            //This method also expect only the Single Elelment of the sequence must satisfiy the Specified Condition
            //The second overloaded version of the Single() method is used to find the only element in a sequence that satisfies a given condition.
            int[] numbers5 = { 1, 3, 4 };
            int result12 = numbers5.Single(x => x%2==0);
            Console.WriteLine(result12);

            //SingleOrDefault : Very similar to Single(), except this method does not throw an exception when the sequence is empty or when no element in the sequence satisfies the given condition. 
            //int result13 = numbers1.SingleOrDefault(x => x%2==0); //Exception: Multiple Elements Satisfies but it throw exception in Case of OrDefault
            int result14 = numbers2.SingleOrDefault();  //For Empty Set
            int result15 = numbers3.SingleOrDefault(x => x%2==0); //For No Single Element Satisfies the Condition
            Console.WriteLine(result14+"\t\t"+result15);

            //DefaultIfEmpty: If the sequence on which this method is called is not empty, then the values of the original sequence are returned.
            //Not Empty Array:
            IEnumerable<int> result16 = numbers1.DefaultIfEmpty();
            foreach (int i in result16) {
                Console.WriteLine(i);
            }

            //Empty Array:
            IEnumerable<int> result17 = numbers2.DefaultIfEmpty();
            IEnumerable<int> result18 = numbers2.DefaultIfEmpty(10);
            foreach (int i in result18)
            {
                Console.WriteLine(i);
            }

            
        }
    }
}
