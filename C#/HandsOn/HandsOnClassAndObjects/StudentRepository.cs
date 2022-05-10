using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassAndObjects
{
    
    
        class StudentRepository
        {
            Student[] students = new Student[5];
            int idx = 0;
            public void AddStudent(Student student)
            {
                //add student details
                if (idx < students.Length)
                {
                    students[idx] = student;
                    idx++;
                }
                else
                {
                    Console.WriteLine("Class is Full");
                }
            }
            public Student GetStudentById(int studentId) //get student by Id
            {
                foreach (var student in students)
                {
                    if (student != null)
                        if (student.studentId == studentId)
                        {
                            return student;
                        }
                }
                return null; //when studentId is invalid

            }
            public Student[] GetAllStudents() //Get All the students
            {
                return students;
            }
            public void EditStudent(int studentId, string name, int age) //update student details 
            {
                for (int i = 0; i < students.Length; i++)
                {
                    if (students[i].studentId == studentId)
                    {
                        students[i].studentName = name;
                        students[i].studentAge = age;
                        break; //terminate the loop
                    }
                }
            }
            public void DeleteStudent(int studentId)
            {
                for (int i = 0; i < students.Length; i++)
                {
                    if (students[i].studentId == studentId)
                    {
                        students[i] = null;
                        break; //terminate the loop
                    }
                }
            }


            static void Main()
            {
                StudentRepository repository = new StudentRepository();
                do
                {
                    Console.WriteLine("1.AddStudent");
                    Console.WriteLine("2.GetStudentById");
                    Console.WriteLine("3.GetAllStudents");
                    Console.WriteLine("4.EditStudent");
                    Console.WriteLine("5.DeleteStudent");
                    Console.WriteLine("6.Exit");
                    Console.WriteLine("Enter your choice");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Student student = new Student();
                            Console.WriteLine("Enter Name");
                            student.studentName = Console.ReadLine();
                            //Generate Student Id Randomly
                            Random random = new Random();
                            student.studentId = random.Next(); //generate random number
                            Console.WriteLine("Enter Age");
                            student.studentAge = Convert.ToInt32(Console.ReadLine());
                            repository.AddStudent(student);
                            break;
                        case 2:
                            {
                                Console.WriteLine("Enter StudentId");
                                int studentId = int.Parse(Console.ReadLine());
                                Student s = repository.GetStudentById(studentId);
                                if (s != null)
                                {
                                    // Console.WriteLine($"Name:{s.studentName} Age:{s.studentAge}");
                                    s.Details();
                                }
                                else
                                {
                                    Console.WriteLine("Invalid StudentId");
                                }
                            }
                            break;
                        case 3:
                            {
                                Student[] students = repository.GetAllStudents();
                                foreach (Student s in students)
                                {
                                    if (s != null) //before call the Details check the object reference is not null
                                        s.Details();
                                }
                            }
                            break;
                        case 4:
                            {
                                Console.WriteLine("Enter Id");
                                int id = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Name");
                                string name = Console.ReadLine();
                                Console.WriteLine("Enter Age");
                                int age = int.Parse(Console.ReadLine());
                                repository.EditStudent(id, name, age);
                            }
                            break;
                        case 5:
                            {
                                Console.WriteLine("Enter Id");
                                int id = int.Parse(Console.ReadLine());
                                repository.DeleteStudent(id);
                            }
                            break;
                        case 6:
                            {
                                Environment.Exit(0); //exit the app
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;

                    }

                } while (true);


            }

        }
    
}
