using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEntity
{
    public class Student
    {
        private int rollNumber;
        private string studentName;
        private byte age;
        private char gender;
        private DateTime dateOfBirth;
        private string address;
        private float precentage;
        public Student(int rollNumber, string studentName, byte age, char gender, DateTime dateOfBirth, string address, float precentage)
        {
            this.rollNumber = rollNumber;
            this.studentName = studentName;
            this.age = age;
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
            this.precentage = precentage;
        }
        public void Display()
        {
            Console.WriteLine("Roll number: {0}", this.rollNumber);
            Console.WriteLine("Student name: {0}", this.studentName);
            Console.WriteLine("Age: {0}", this.age);
            Console.WriteLine("Gender: {0}", this.gender);
            Console.WriteLine("Date of Birth: {0}", this.dateOfBirth);
            Console.WriteLine("Address: {0}", this.address);
            Console.WriteLine("Precentage: {0}", this.precentage);
        }
    }
}
