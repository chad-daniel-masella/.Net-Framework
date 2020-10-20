using System;
using System.Security.Cryptography.X509Certificates;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
              this is a multi line comment

             */

            /*
            // declared variables
            // variable types: integer (-2 billion 147 to 2 billion 147)
            int x;
            int y;

            // assign / manipulate varaibles
            // "=" is an assignment operator 
            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            */

            /*
            // variable declaration using camel-case
            // C# is case sensative
            string myFirstName;

            // you need to initialize a var variable with a value, even if it is an empty string
            var myfirstname = "Tom";

            myFirstName = "Bob";

            Console.WriteLine(myFirstName, myfirstname);

            Console.ReadLine();
            */

            // explicit convertion using string and integer
            // explicit conversion means we will have to write the code in order to perform the data conversion
            int x = 7;
            // string y = "Bob";
            string y = "5";
            string myFirstTry = x.ToString() + y;

            // int mySecondTry = x + y;
            int mySecondTry = x + int.Parse(y);


            Console.WriteLine(myFirstTry);
        }
    }
}
