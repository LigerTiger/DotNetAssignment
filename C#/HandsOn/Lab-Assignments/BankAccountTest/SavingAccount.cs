using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountTest
{
    


        interface IInterest
        {
            void CalculateInterest();
        }
        class SavingsAccount
        {
            private double annualInterestRate = 0.0;
            private double savingsBalance;


            public SavingsAccount(double initBalance)
            {
                savingsBalance = initBalance;
            }


            public double getBalance() { return savingsBalance; }



            public double getInterestRate()
            {
                return annualInterestRate;
            }
        }


        class ICICI : SavingsAccount, IInterest
        {
            //CONCRETE CLASSES SUCH AS ICICI ACCOUNTS GET 7% 
            private double annualInterestRate = 7.0;


            public ICICI(double initBalance) : base(initBalance)
            {

            }
            public void CalculateInterest()
            {
                double savingsBalance = getBalance();
                savingsBalance *= (1 + (annualInterestRate / 100 / 12));
                Console.WriteLine("Saving balance for ICICI account: {0}", savingsBalance.ToString("C"));
            }
        }
        class HSBC : SavingsAccount, IInterest
        {
            //SBC GIVES 5% INTEREST.
            private double annualInterestRate = 5.0;


            public HSBC(double initBalance)
                : base(initBalance)
            {


            }
            public void CalculateInterest()
            {
                double savingsBalance = getBalance();
                savingsBalance *= (1 + (annualInterestRate / 100 / 12));
                Console.WriteLine("Saving balance for HSBC account: {0}", savingsBalance.ToString("C"));
            }
        }



    class SavingAccount
    {
        static void Main(string[] args)
        {



            IInterest savingsAccountICICI = new ICICI(5000);
            savingsAccountICICI.CalculateInterest();
            IInterest savingsAccountHSBC = new HSBC(5000);
            savingsAccountHSBC.CalculateInterest();




            Console.ReadKey();


        }
    }
}
