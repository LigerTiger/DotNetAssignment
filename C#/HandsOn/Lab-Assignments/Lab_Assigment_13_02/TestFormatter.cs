using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
//using System.Runtime.Serialization.Formatters.Soap;

using System.Xml.Serialization;

namespace Lab_Assigment_13_03_04
{
    class TestFormatter
    {
        private static List<Contract> contracts = new List<Contract>();


        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(@"Options:
1. Add contract
2. Serialize added contracts to file in SOAP format
3. Deserialize contracts from file in SOAP format
4. Serialize supplier to file in XML format
5. Deserialize supplier from file in XML format
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
                        AddContract();
                        break;


                    case 2:
                        SerializeContracts();
                        break;


                    case 3:
                        DeserializeContracts();
                        break;


                    case 4:
                        SerializeSupplier();
                        break;


                    case 5:
                        DeserializeSupplier();
                        break;


                    case 6:
                        return;


                    default:
                        break;
                }


                Console.WriteLine();
            }
        }


        private static void AddContract()
        {
            var contract = new Contract();


            Console.Write("Input contract no: ");
            contract.ContractNo = int.Parse(Console.ReadLine());


            Console.Write("Input contract name: ");
            contract.ContractName = Console.ReadLine();


            Console.Write("Input cell no: ");
            contract.CellNo = Console.ReadLine();


            contracts.Add(contract);
            Console.WriteLine("Contract has been added");
        }


        private static void SerializeContracts()
        {
            Console.Write("Input filename: ");
            var filename = Console.ReadLine();


            var serializer = new ContractSerializer();
            serializer.Serialize(filename, contracts);


            Console.WriteLine($"Contracts has been serialized to file {filename}");
        }


        private static void DeserializeContracts()
        {
            Console.Write("Input filename: ");
            var filename = Console.ReadLine();


            var serializer = new ContractSerializer();
            var deserialized = serializer.Deserialize(filename);


            if (deserialized.Count == 0)
            {
                Console.WriteLine("No contracts");
                return;
            }


            Console.WriteLine("Deserialized contracts:");
            for (var i = 0; i < deserialized.Count; i++)
                Console.WriteLine($"{i + 1}. {deserialized[i]}");
        }


        private static void SerializeSupplier()
        {
            Console.Write("Input filename: ");
            var filename = Console.ReadLine();


            var supplier = new Supplier();
            Console.Write("Input supplier no: ");
            supplier.SupplierNo = int.Parse(Console.ReadLine());
            Console.Write("Input supplier name: ");
            supplier.SupplierName = Console.ReadLine();


            var serializer = new ContractSerializer();
            serializer.SerializeSupplier(filename, supplier);


            Console.WriteLine($"Supplier has been serialized to file {filename}");
        }


        private static void DeserializeSupplier()
        {
            Console.Write("Input filename: ");
            var filename = Console.ReadLine();


            var serializer = new ContractSerializer();
            var supplier = serializer.DeserializeSupplier(filename);


            Console.WriteLine(supplier);
        }
    }


    public class ContractSerializer
    {
        public void Serialize(string filename, List<Contract> contracts)
        {
            using (MemoryStream xmlStream = new MemoryStream())
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Contract>));
                xmlSerializer.Serialize(xmlStream, contracts);


                using (var fs = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    var soapFormatter = new SoapFormatter();
                    soapFormatter.Serialize(fs, Encoding.Default.GetString(xmlStream.ToArray()));
                }
            }
        }


        public List<Contract> Deserialize(string filename)
        {
            using (var fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                var soapFormatter = new SoapFormatter();
                var deserializedXmlBytes = Encoding.Default.GetBytes((string)soapFormatter.Deserialize(fs));


                using (MemoryStream xmlStream = new MemoryStream())
                {
                    xmlStream.Write(deserializedXmlBytes, 0, deserializedXmlBytes.Length);
                    xmlStream.Seek(0, SeekOrigin.Begin);


                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Contract>));
                    return (List<Contract>)xmlSerializer.Deserialize(xmlStream);
                }
            }
        }


        public void SerializeSupplier(string filename, Supplier supplier)
        {
            var serializer = new XmlSerializer(typeof(Supplier));


            using (var writer = new StreamWriter(filename))
            {
                serializer.Serialize(writer, supplier);
            }
        }


        public Supplier DeserializeSupplier(string filename)
        {
            var serializer = new XmlSerializer(typeof(Supplier));


            using (var fs = new FileStream(filename, FileMode.OpenOrCreate))
                return (Supplier)serializer.Deserialize(fs);
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
}
