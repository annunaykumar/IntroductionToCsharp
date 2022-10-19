using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    internal class PrivateConstructor
    {
        class Example
        {


            public static int a;


            private Example()
            {

            }

            public static int getIncrement()
            {
                return ++a;
            }

            public static void getTime()
            {
                Console.WriteLine(DateTime.Now);
            }


        }

        //class Example2 : Example
        //{

        //}

        class Program
        {
            static void Main(string[] args)
            {
               // example e = new example("ali", "khan");
                //Example e = new Example();
                Example.getTime();
                Example.a = 20;
                Console.WriteLine(Example.getIncrement());
                Console.ReadLine();
            }
        }
    }
}
