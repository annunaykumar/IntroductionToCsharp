﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    internal class StaticConstructor
    {
        class person
        {
            public static string PersonName;
            public static int PersonAge;

            static person()
            {
                PersonName = "Ali";
                PersonAge = 23;
                Console.WriteLine("Static constructor invoked !!");
            }

            public person()
            {
                Console.WriteLine("default constructor invoked !!");
            }

            public static void GetDetails()
            {
                Console.WriteLine("Person name is: {0}", PersonName);
                Console.WriteLine("Person Age is: {0}", PersonAge);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                person umar = new person();
                person Ali = new person();
                Console.ReadLine();
            }
        }
    }
}
