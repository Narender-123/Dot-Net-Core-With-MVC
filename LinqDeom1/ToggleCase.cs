using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinqDeom1
{
    public class ToggleCase
    {
        static void main() {
            String name = "Narender";

            //Here we understand what is the Extension method and to make them Extension Method we had to make use of HelperClass(Wrapper Class) that we create 
            String result = name.ChangeFirstLetterCase();

            //Wrapper Class(HelperClass) is Used to get the Desired output
            //String result = StringHelper.ChangeFirstLetterCase(name);

            Console.Write(result);
        }
    }
}