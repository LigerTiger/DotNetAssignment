using System;

namespace HandsOnConstructors
{
    class Student
    {
        public int studentId;
        public string studentName;
        public string schoolName;
        public Student()
        {
            schoolName = "DPS";
        }
        public Student(int sid, string sname , string scname)
        {
            this.studentId=sid;
            this.studentName = sname;
            this.schoolName=scname;
        }
        public void Detatils()
        {
            Console.WriteLine($"ID: ${studentId} Name: {studentName} SchoolName: {studentName}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student() {studentId=4578,studentName="Ankit"};
            Student s2 = new Student() {studentId=4785,studentName="Monica"};
            s1.Detatils();
            s2.Detatils();
            Student s3 = new Student(3425,"Swathi","HPS");
            Student s4 = new Student(3425,"Amith","GPS");
            s3.Detatils();
            s4.Detatils();
        }
            
     
    }
}
