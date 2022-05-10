using System;

namespace HandsOnProperties
{
    class Student
    {
        private int studentId;
        private string studentName;

        // PROPERTY fOR STUDENT ID

        public int StudentId
        {
            get { return studentId; }       // RETURN studentId values
            set { studentId = value; }      // SET VALUE TO studentId
        }

        // PROPERTY fOR STUDENT ID

        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.StudentId = 2554;
            s1.StudentName = "Ankit ";
            Console.WriteLine($"ID: {s1.StudentId} Name:{s1.StudentName}");

        }
    }
}
