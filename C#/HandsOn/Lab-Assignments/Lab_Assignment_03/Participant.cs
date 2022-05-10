using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_03
{
   class Participant {
       
        private int emloyeeId;


        public int EmployeeId
        {
            get { return emloyeeId; }
            set { emloyeeId = value; }
        }
        private string name;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private static string companyName;


        public static string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
        private int foundationMarks;


        public int FoundationMarks
        {
            get { return foundationMarks; }
            set { foundationMarks = value; }
        }
        private int webBasicMarks;


        public int WebBasicMarks
        {
            get { return webBasicMarks; }
            set { webBasicMarks = value; }
        }
        private int dotNetMarks;


        public int DotNetMarks
        {
            get { return dotNetMarks; }
            set { dotNetMarks = value; }
        }
      

        private const int totalMarks=300;


        public int TotalMarks
        {
            get { return totalMarks; }
        }
        private int obtainedMarks;


        public int ObtainedMarks
        {
            get { return obtainedMarks; }
            set { obtainedMarks = value; }
        }
        private double percentage;


        public double Percentage
        {
            get { return percentage; }
            set { percentage = value; }
        }
       
        public Participant()
        {

        }
        


        public Participant(int empId, string name, int foundationMarks, int webBasicMarks, int dotNetMarks) {
            this.emloyeeId = empId;
            this.name = name;
            this.foundationMarks = foundationMarks;
            this.webBasicMarks = webBasicMarks;
            this.dotNetMarks = dotNetMarks;
        }
        static Participant() {
            companyName = "Corporate Unniversity";
        }
        
        public void CalculateTotalMarks()
        {
            obtainedMarks += foundationMarks + webBasicMarks + dotNetMarks;
        }
       

        public void CalculatePercentage()
        {
            percentage = ((double)obtainedMarks / (double)totalMarks)*100.0;
        }
       
        public double getPercentage()
        {
            return percentage;
        }


    }




    class Test_Participant
    {



        static void Main(string[] args)
        {
            
            Participant participant = new Participant();
            Console.Write("Enter employee Id: ");
            participant.EmployeeId = int.Parse(Console.ReadLine());
            Console.Write("Enter name: ");
            participant.Name = Console.ReadLine();
            Console.Write("Enter foundation marks: ");
            participant.FoundationMarks = int.Parse(Console.ReadLine());
            Console.Write("Enter web basic marks: ");
            participant.WebBasicMarks = int.Parse(Console.ReadLine());
            Console.Write("Enter dot net marks: ");
            participant.DotNetMarks = int.Parse(Console.ReadLine());
           


            participant.CalculateTotalMarks();
            participant.CalculatePercentage();
            Console.WriteLine("\nCompany Name: {0}", Participant.CompanyName);
            Console.WriteLine("Total Marks: {0}", participant.ObtainedMarks);
           

            Console.WriteLine("Percentage: {0} %", participant.getPercentage().ToString("N"));




            Console.ReadKey();
        }
    }
}
