using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperation
{
    public class Calculator
    {
        public int Square(int num)
        {
            return num * num;
        }
       
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
      
        public int Subtract(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1 - num2;
            }

            return num2 - num1;

        }
         
        public double Division(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
