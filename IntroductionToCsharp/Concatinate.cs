using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    internal class Concatinate
    {
        public static void Main()
        {
            Console.WriteLine("Enter your FirstName");
            string fname;
            fname = Console.ReadLine();
            Console.WriteLine("Enter your LastName");
            string lname;
            lname = Console.ReadLine();
            Console.WriteLine("Your Name is :"+ fname+" "+lname);// Concatination
            Console.WriteLine("Your name is: {0} {1}", fname,lname);//placeholder
            Console.ReadLine();

        }
    }
}
