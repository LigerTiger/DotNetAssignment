using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccountLibrary;

namespace BankAccountTest
{
    class BankTest
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount1 = new BankAccount(1000);
            bankAccount1.AccountType = BankAccountTypeEnum.Current;
            BankAccount bankAccount2 = new BankAccount(2000);
            bankAccount2.AccountType = BankAccountTypeEnum.Saving;
            Console.WriteLine("The current balance of the bankAccount1 is: {0}", bankAccount1.GetBalance());
            Console.WriteLine("The current balance of the bankAccount2 is: {0}", bankAccount2.GetBalance());
            bankAccount1.Deposit(400);
            Console.WriteLine("bankAccount1.Deposit(400): {0}", bankAccount1.GetBalance());
            bankAccount2.Deposit(200);
            Console.WriteLine("bankAccount2.Deposit(200): {0}", bankAccount2.GetBalance());


            bankAccount1.Transfer(bankAccount2, 400);
            Console.WriteLine("bankAccount1.Transfer(bankAccount2, 400)");
            Console.WriteLine("The current balance of the bankAccount1 is: {0}", bankAccount1.GetBalance());
            Console.WriteLine("The current balance of the bankAccount2 is: {0}", bankAccount2.GetBalance());
            Console.ReadLine();
        }
    }
    
}
