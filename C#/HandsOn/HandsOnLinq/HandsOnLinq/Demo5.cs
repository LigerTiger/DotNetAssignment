using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

    }

    class Demo5
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student(){StudentId=1,StudentName="Rohan",Age=12},
                new Student(){StudentId=2,StudentName="Karan",Age=11},
                new Student(){StudentId=3,StudentName="Amith",Age=10},
                new Student(){StudentId=4,StudentName="Ishwarya",Age=12},
                new Student(){StudentId=5,StudentName="Himanshi",Age=11},
                new Student(){StudentId=6,StudentName="Swathi",Age=10},
                new Student(){StudentId=7,StudentName="Ankit",Age=12},

            };
            //FETCH STUDENT ID 1 DETAILS
            Student student = students.SingleOrDefault(s => s.StudentId == 1);
            var result = students.Where(s => s.Age>10).ToList();
            result = students.Where(s => s.StudentName.StartsWith('A')).ToList();
            result = (from s in students where s.StudentName.StartsWith('A') select s).ToList();
            result = (from s in students orderby s.StudentName select s).ToList();
            result = students.OrderBy(s => s.StudentName).ToList();
            result = students.OrderByDescending(s => s.Age).ToList();
            foreach(var item in result)
            {
                Console.WriteLine("{0} {1} {2} ",item.StudentId,item.StudentName,item.Age);
            }
            student = students.ElementAt(5);
            Console.ReadLine();
        }
    }
}
