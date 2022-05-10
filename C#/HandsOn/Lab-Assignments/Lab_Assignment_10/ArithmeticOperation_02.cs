using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_10
{
    class ArithmeticOperation_02
    {
            delegate int MyDelegate(int num1, int num2);


            static void Main(string[] args)
            {
                MyDelegate arOperation = (int num1, int num2) => num1 + num2;
                
            PerformArithmeticOperation(2, 3, arOperation);
                Console.ReadKey();
            }

            static void PerformArithmeticOperation(int num1, int num2, MyDelegate arOperation)
            {
                var result = arOperation(num1, num2);
                Console.WriteLine(result);
            }
        
    }
}
