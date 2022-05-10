using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAssignment_23_04
{
    class CreditCard
    {
        static void Main(string[] args)
        {

			double amount = 915.00;
			Console.Write("Enter the Monthly payment: ");
			double debt = Convert.ToDouble(Console.ReadLine()); ;
			for (int i = 1; i <= 3; i++)
			{
				Console.WriteLine($"Month: {i}  Balance: {amount } total payments: {debt * i}"); 
				amount = (amount + amount / 100 * 1.5 )- debt;
			}
			/*	while(amount>0) {
				amount=amount+(amount/100)*1.5-debt;
				System.out.println(amount);
				} */


			Console.ReadKey();
		}
	}
}
