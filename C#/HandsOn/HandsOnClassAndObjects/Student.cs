using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassAndObjects
{
    class Student
    {
        //variable
        public int studentId;
        public string studentName;
        public int studentAge;
        //method
        public void Details()
        {
            Console.WriteLine($"ID:{studentId} Name:{studentName} Age:{studentAge}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate Student
            Student s1 = new Student();
            s1.studentId = 324098;
            s1.studentName = "Amith";
            s1.studentAge = 24;
            // Console.WriteLine($"Id:{s1.studentId} Name:{s1.studentName} Age:{s1.studentAge}");
            s1.Details(); //calling method
            Student s2 = new Student();
            s2.studentId = 40984;
            s2.studentName = "Kumar Sing";
            s2.studentAge = 21;
            //Console.WriteLine($"Id:{s2.studentId} Name:{s2.studentName} Age:{s2.studentAge}");
            s2.Details();
            Student s3 = new Student();
            Console.WriteLine("Enter Name");
            s3.studentName = Console.ReadLine();
            s3.studentId = 3240893;
            Console.WriteLine("Enter Age");
            s3.studentAge = Convert.ToInt32(Console.ReadLine());
            s3.Details();
            Student s4 = new Student() { studentId = 3240834, studentName = "Alekya", studentAge = 21 }; //object initializer
            //Student Array
            Student[] students = new Student[5];
            students[0] = s1;
            students[1] = s2;
            students[2] = s3;
            students[3] = new Student();
            students[3].studentId = 342983;
            students[3].studentName = "Ankith";
            students[3].studentAge = 22;
            // students[4] = s4;
            Console.WriteLine();
            foreach (var item in students)
            {
                if (item != null) //to check object reference
                    item.Details();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
