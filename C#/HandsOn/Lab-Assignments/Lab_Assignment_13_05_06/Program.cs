using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;



namespace Lab_Assignment_13_05_06
{
    class Program
    {
        private static List<Supplier> suppliers = new List<Supplier>();


        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(@"Options:
1. Add supplier
2. Serialize added suppliers to file in JSON format
3. Deserialize suppliers from file in JSON format
4. Serialize student to file in binary format
5. Deserialize student from file in binary format
6. Quit");
                Console.Write("Choose an option (1-6): ");
                var input = Console.ReadLine();


                if (!int.TryParse(input, out var option))
                {
                    Console.WriteLine();
                    continue;
                }


                switch (option)
                {
                    case 1:
                        AddSupplier();
                        break;


                    case 2:
                        SerializeSuppliers();
                        break;


                    case 3:
                        DeserializeSuppliers();
                        break;


                    case 4:
                        SerializeStudent();
                        break;


                    case 5:
                        DeserializeStudent();
                        break;


                    case 6:
                        return;


                    default:
                        break;
                }


                Console.WriteLine();
            }
        }


        private static void AddSupplier()
        {
            var supplier = new Supplier();
            Console.Write("Input supplier no: ");
            supplier.SupplierNo = int.Parse(Console.ReadLine());
            Console.Write("Input supplier name: ");
            supplier.SupplierName = Console.ReadLine();


            suppliers.Add(supplier);
            Console.WriteLine("Supplier has been added");
        }


        private static void SerializeSuppliers()
        {
            Console.Write("Input filename: ");
            var filename = Console.ReadLine();


            var serializer = new ContractSerializer();
            serializer.SerializeSuppliers(filename, suppliers);


            Console.WriteLine($"Suppliers has been serialized to file {filename}");
        }


        private static void DeserializeSuppliers()
        {
            Console.Write("Input filename: ");
            var filename = Console.ReadLine();


            var serializer = new ContractSerializer();
            var deserialized = serializer.DeserializeSuppliers(filename);


            if (deserialized.Count == 0)
            {
                Console.WriteLine("No suppliers");
                return;
            }


            Console.WriteLine("Deserialized suppliers:");
            for (var i = 0; i < deserialized.Count; i++)
                Console.WriteLine($"{i + 1}. {deserialized[i]}");
        }


        private static void SerializeStudent()
        {
            Console.Write("Input filename: ");
            var filename = Console.ReadLine();


            var student = new Student();
            Console.Write("Input roll no: ");
            student.RollNo = int.Parse(Console.ReadLine());
            Console.Write("Input name: ");
            student.Name = Console.ReadLine();
            Console.Write("Input city: ");
            student.City = Console.ReadLine();
            Console.Write("Input degree: ");
            student.Degree = Console.ReadLine();


            var serializer = new ContractSerializer();
            serializer.SerializeStudent(filename, student);


            Console.WriteLine($"Student has been serialized to file {filename}");
        }


        private static void DeserializeStudent()
        {
            Console.Write("Input filename: ");
            var filename = Console.ReadLine();


            var serializer = new ContractSerializer();
            var student = serializer.DeserializeStudent(filename);


            Console.WriteLine(student);
        }
    }


    public class ContractSerializer
    {
        

        public void SerializeSuppliers(string filename, List<Supplier> suppliers)
        {
            var jsonString = JsonSerializer.Serialize(suppliers);
            File.WriteAllText(filename, (string)jsonString);
        }


        public List<Supplier> DeserializeSuppliers(string filename)
        {
            return JsonSerializer.Deserialize<List<Supplier>>(File.ReadAllText(filename));
        }


        public void SerializeStudent(string filename, Student student)
        {
            var binaryFormatter = new BinaryFormatter();


            using (var fs = new FileStream(filename, FileMode.OpenOrCreate))
                binaryFormatter.Serialize(fs, student);
        }


        public Student DeserializeStudent(string filename)
        {
            var binaryFormatter = new BinaryFormatter();


            using (var fs = new FileStream(filename, FileMode.OpenOrCreate))
                return (Student)binaryFormatter.Deserialize(fs);
        }
    }


    [Serializable]
    public class Contract
    {
        public int ContractNo { get; set; }
        public string ContractName { get; set; }
        public string CellNo { get; set; }


        public override string ToString() => $"Contract (No: {ContractNo}, Name: {ContractName}, Cell No: {CellNo})";
    }


    [Serializable]
    public class Supplier
    {
        public int SupplierNo { get; set; }
        public string SupplierName { get; set; }


        public override string ToString() => $"Supplier (No: {SupplierNo}, Name: {SupplierName})";
    }


    [Serializable]
    public class Student : ISerializable
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Degree { get; set; }


        public override string ToString() => $"Student (No: {RollNo}, Name: {Name}, City: {City}, Degree: {Degree})";


        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("AltRollNo", RollNo);
            info.AddValue("AltName", Name);
            info.AddValue("AltCity", City);
            info.AddValue("AltDegree", Degree);
        }


        public Student()
        {
        }


        protected Student(SerializationInfo info, StreamingContext context)
        {
            RollNo = (int)info.GetValue("AltRollNo", typeof(int));
            Name = (string)info.GetValue("AltName", typeof(string));
            City = (string)info.GetValue("AltCity", typeof(string));
            Degree = (string)info.GetValue("AltDegree", typeof(string));
        }
    }
}