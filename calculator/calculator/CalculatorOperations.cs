using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class CalculatorOperations
    {
        public CalculatorOperations()
        {

        }

        public double Addition(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Subtraction(double num1, double num2)
        {
            return (num1 - num2);
        }
        public double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }
        public double Division(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
