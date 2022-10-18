using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    internal class Add
    {
        public static void Main()
        {
            Console.WriteLine("Enter the First Number");
            int num1;
            num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int num2;
            num2 = int.Parse(Console.ReadLine());
            int sum;
            sum = num1 + num2;
            Console.WriteLine("Addition result is: {0}",sum);
            Console.ReadLine();
        }
    }
}
