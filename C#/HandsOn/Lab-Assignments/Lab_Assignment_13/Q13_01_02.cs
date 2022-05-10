using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab_Assignment_13
{
    class Q13_01_02
    {
        private static List<Contract> contracts = new List<Contract>();

        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(@"Options:
1. Add contract
2. Serialize added contracts to file
3. Deserialize contracts from from file
4. Quit");
                Console.Write("Choose an option (1-4): ");
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
    }


    public class ContractSerializer
    {
        public void Serialize(string filename, List<Contract> contracts)
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, contracts);
            }
        }


        public List<Contract> Deserialize(string filename)
        {
            var formatter = new BinaryFormatter();


            using (var fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                return (List<Contract>)formatter.Deserialize(fs);
            }
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
}
