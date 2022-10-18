using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    internal class ObjectsAndClasses
    {
        class Student
        {
            int rollno;
            string name;
            int age;
            int standard;

            public void setStudent(int rollno, string name, int age,int standard)
            {
                this.rollno = rollno;   
                this.name = name;   
                this.age = age; 
                this.standard = standard;   
            }
            public void getStudent()
            {
                Console.WriteLine("Your Roll No is : {0}",this.rollno);
                Console.WriteLine("Your Name is : {0}", this.name);
                Console.WriteLine("Your age is : {0}", this.age);
                Console.WriteLine("Your Class is : {0}", this.standard);
            }
            static void Main()
            {
                Console.WriteLine("Enter the Roll no:");
                int roll = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the age:");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Class:");
                int standard=int.Parse(Console.ReadLine());
                
                Student Anunay = new Student();
                Anunay.setStudent(roll, name, age, standard);
                Anunay.getStudent();

                Console.ReadLine(); 
            }

        }
    }
}
