using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class PartioningOpertors
    {
        static void Main1()
        {
            String[] countries = { "Australia", "Canada", "Germany", "US", "India", "UK", "Italy" };


            //Take method returns a specified number of elements from the start of the collection.---------------------------------------------------------------------------
            //The number of items to return is specified using the count parameter this method expects.
            IEnumerable<string> countries0 = countries.Take(3);
            IEnumerable<string> countries1 = (from country in countries
                                              select country).Take(3);
            IEnumerable<string> countries2 = countries.Take(3);

            foreach (string country in countries2)
            {
                // Console.WriteLine(country);
            }

            //Skip method skips a specified number of elements in a collection and then returns the remaining elements. The number of items to skip is specified using the count parameter this method expects. 
            IEnumerable<string> countries3 = countries.Skip(3);

            foreach (string country in countries3)
            {
                //Console.WriteLine(country);

            }

            //TakeWhile method returns elements from a collection as long as the given condition specified by the predicate is true.
            IEnumerable<string> countries4 = countries.TakeWhile(country => country.Length>2);

            foreach (string country in countries4)
            {
                //Console.WriteLine(country);

            }

            //SkipWhile method skips elements in a collection as long as the given condition specified by the predicate is true, and then returns the remaining elements.
            IEnumerable<string> countries5 = countries.SkipWhile(country => country.Length > 2);

            foreach (string country in countries5)
            {
                Console.WriteLine(country);

            }
        }
    }
}
