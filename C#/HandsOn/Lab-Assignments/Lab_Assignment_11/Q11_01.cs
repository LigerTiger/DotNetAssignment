using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_11
{
    class Q11_01
    {
        //DEFINE A DELEGATE TO HANDLE THE EVENT
        public delegate void SendSMS(string message);


        public class CreditCard
        {
           

            private string creditCardNo;
            private string cardHolderName;
            private double balanceAmount;
            private double creditLimit;


            
            public CreditCard(string creditCardNo, string cardHolderName, double balanceAmount, double creditLimit)
            {
                this.creditCardNo = creditCardNo;
                this.cardHolderName = cardHolderName;
                this.balanceAmount = balanceAmount;
                this.creditLimit = creditLimit;
            }




            public double GetBalance()
            {
                return balanceAmount;
            }


            public double GetCreditLimit()
            {
                return creditLimit;
            }


            public void MakePayment(double amount)
            {
                if (paymentIsMade != null)
                {
                    if (amount <= creditLimit)
                    {
                        this.balanceAmount -= amount;
                        paymentIsMade(string.Format("{0} has made payment for amount {1}. The balance is {2} now", this.cardHolderName, amount, this.balanceAmount));
                    }
                    else
                    {
                        paymentIsMade(string.Format("The customer wiht credit card no {0} has a credit limit {1}!", this.creditCardNo, creditLimit));
                    }
                }


            }


            //DEFINE AN EVENT WHICH WILL BE RAISED WHENEVER THE PAYMENT IS MADE.
            public event SendSMS paymentIsMade;


        }
       
        public static void Main(string[] args)
        {
            //CREATE A CONSOLE CLIENT APPLICATION, AND TRY THE FUNCTIONALITY.
            CreditCard creditCard = new CreditCard("4654654131", "Ankit Kumar Chaudhary", 1000, 500);
            creditCard.paymentIsMade += ShowSMS;
            creditCard.MakePayment(100);
            creditCard.MakePayment(1000);


            Console.ReadLine();


        }
        
        static void ShowSMS(string message)
        {
            Console.WriteLine(message);
        }
    }
}
