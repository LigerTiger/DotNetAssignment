using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountLibrary
{
    public class BankAccount : IBankAccount
    {


        protected double balance;
        public BankAccountTypeEnum AccountType { get; set; }


        public BankAccount(double amount)
        {
            balance = amount;
        }


        public bool Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("The amount has been deposited.");
                return true;
            }
            return false;
        }


        public bool Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("The amount has been withdrawed.");
                return true;
            }
            return false;
        }
        public bool Transfer(IBankAccount toAccount, double amount)
        {
            return (this.Deposit(amount) && toAccount.Withdraw(amount));
        }
        public double GetBalance()
        {
            return balance;
        }
    }
}
