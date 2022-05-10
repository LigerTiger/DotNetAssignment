using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentEntity;

namespace StudentSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(101, "Ankit Kumar Chauhdary ", 24, 'M', new DateTime(1998, 11, 28), "Pune", 73);
            Student student2 = new Student(1022, "Amit Bhaskar", 25, 'M', new DateTime(1997, 10, 15), "Delhi", 70);
            Student student3 = new Student(1032, "Monica Konthalal", 22, 'F', new DateTime(2000, 05, 20), "Andhra Pradesh", 80);
            student1.Display();
            student2.Display();
            Console.ReadKey();
            
        }
    }
}
