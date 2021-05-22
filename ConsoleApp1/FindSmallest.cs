using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    class FindSmallest
    {
        static void Main1() 
        {
            int[] Numbers = { 21, 22, 23, 24, 25, 26, 27, 28, 29, 1, 2, 3, 4, 5, 6, 7, 8, 45, 9, 10, 11, 12, 13, 14 };
            
            //Without Using Linq Find the Smallest Number--------------------------------------------------------------
            int? smallest = null;
            foreach (int n in Numbers)
            {
                if (!smallest.HasValue || smallest>n) 
                {
                    smallest = n;
                }
            }
            Console.WriteLine("The Smallest Number = "+smallest);

            //Without Using Linq Find the Smallest Even Number----------------------------------------------------------
            int? smallestEven = null;
            foreach (int n in Numbers)
            {
                //First Check For Even
                if (n%2==0) 
                { 
                    if (!smallestEven.HasValue || smallestEven > n)
                    {
                        smallestEven = n;
                    }
                }
            }
            Console.WriteLine("\nThe SmallestEven Number = " + smallestEven);

            //++++++++++++++++++++++++++++++++++LINQ  Operators (Aggrigate Operators) ++++++++++++++++++++++++++++++++++
            //With Using of Linq Find the Smallest Number---------------------------------------------------------------
            int smallest1 = Numbers.Min();
            Console.Write("\nThe Smallest Number is = "+smallest1);

            //With Using of Linq Find the Greatest Number---------------------------------------------------------------
            int Greatest1 = Numbers.Max();
            Console.Write("\nThe Greatest Number is = " + Greatest1);

            //With Using of Linq Find the GreatestEven Number------------------------------------------------------------
            int GreatestEven1 = Numbers.Where(x => x%2==0).Max();
            Console.Write("\nThe Greatest Even Number is = " + GreatestEven1);

            //With Using of Linq Find the Sum of the Array/Collection/Set/Total------------------------------------------
            int Sum1 = Numbers.Sum();
            Console.Write("\nThe Total Sum of the Numbers  = " + Sum1);

            //With Using of Linq Find the Number of Items/Count---------------------------------------------------------
            int count1 = Numbers.Count();
            Console.Write("\nThe Total Count of the Numbers  = " + count1);


            //With Using Linq Find the Smallest Even Number--------------------------------------------------------------
            int smallestEven1 = Numbers.Where(x => x % 2 == 0).Min();
            Console.WriteLine("\nThe SmallestEven Number = " + smallestEven1);

            //With Using Linq Find the Average of Even Number-------------------------------------------------------------
            double avgEven1 = Numbers.Where(x => x % 2 == 0).Average();
            Console.WriteLine("\nThe Average of Even Number = " + avgEven1);

            //============================================================================================================

            //Find the Shorest Country Characters name Without Using Linq-------------------------------------------------
            string[] Countries = {"Britin","USA","RSA","UK","India" };

            int? shortestCountry = null;
            foreach (string country in Countries) 
            {
                if (!shortestCountry.HasValue || country.Length<shortestCountry)
                {
                    shortestCountry = country.Length;
                }
            }
            Console.WriteLine("Shortest Counrty name has {0} Characters in its Name",shortestCountry);

            //Find the Shorest Country Characters name With Using Linq---------------------------------------------------------
            Console.WriteLine("Shortest Counrty name has {0} Characters in its Name", Countries.Min(country => country.Length));

            //Find the Shorest Country Characters name With Using Linq---------------------------------------------------------
            Console.WriteLine("Greatest Counrty name has {0} Characters in its Name", Countries.Max(country => country.Length));

            //===================Example of Agrregate Function in Linq Aggregate Opertaors=====================================

            //Creation of string Without Using Linq Aggregate() Operator--------------------------------------------------------
            String[] countries1 = {"India", "UK", "Canada", "Britin", "USA", "UK", "RSA", "SL", "China", "Russia", "France"};
            String result3 = String.Empty;
            foreach (String str in countries1 )
            {
                result3 = result3 + str + ", ";
            }
            int lastindex = result3.LastIndexOf(",");
            result3 = result3.Remove(lastindex);
            Console.Write(result3);

            //Creation of string With Using Linq Aggregate() Operator--------------------------------------------------------
            String result4 = countries1.Aggregate((a,b)=>a+", "+b);
            Console.Write("\n"+result4);

            //Calculatoin of running Product of an array---------------------------------------------------------------------
            int[] numbers1 = { 4,5,6,7,8,6};
            int productResult = 1;
            foreach (int n in numbers1) 
            {
                productResult = productResult * n;
            }
            Console.WriteLine("\n The Product Result Without using Linq Aggregate()= {0} ", productResult);

            //Calculatoin of running Product of an array with Aggregate Function-----------------------------------------------
            productResult = numbers1.Aggregate((a,b)=>a*b);
            Console.WriteLine("\n The Product Result With using Linq Aggregate()= {0} ", productResult);

            //Calculatoin of running Product By Using Seed Parameter-----------------------------------------------------------
            productResult = numbers1.Aggregate(10,(a, b) => a * b);
            Console.WriteLine("\n The Product Result With Seed Pazrameter using Linq Aggregate()= {0} ", productResult);
        }
    }
}
