using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    internal class DateTimeFormatEspecifier
    {
        public static void Main()
        {
            //DateTime dt = DateTime.Now;
            //Console.WriteLine("{0:D}", dt);
            //Console.WriteLine("{0:f}", dt);
            //Console.WriteLine("{0:F}", dt);
            //Console.WriteLine("{0:g}", dt);
            //Console.WriteLine("{0:d} {1:D}", dt, dt);

            DateTime date = DateTime.Now;
            Console.WriteLine("Date is {0:ddd MMM dd, yyyy}", date);
            Console.WriteLine("Time is {0:hh:mm tt}", date);
            Console.WriteLine("24 hour time is {0:HH:mm}", date);
            Console.WriteLine("Time with seconds: {0:HH:mm:ss tt}", date);
            Console.WriteLine("Day of month: {0:m}", date);
            Console.WriteLine("Year: {0:yyyy}", date);


            Console.ReadLine();

        }
    }
}
