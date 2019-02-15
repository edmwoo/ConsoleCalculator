using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(double arg1, double arg2, string argOperation)
        {
            double result = 0.0;

            switch(argOperation.ToLower())
            {
                case "+":
                case "add":
                    result = arg1 + arg2;
                    break;
                case "-":
                case "subract":
                    result = arg1 - arg2;
                    break;
                case "*":
                case "multiply":
                    result = arg1 * arg2;
                    break;
                case "/":
                case "divide":
                    if (arg2 != 0)
                        result = arg1 / arg2;
                    else
                        throw new DivideByZeroException("Cannot divide by zero.");
                    break;
                default:
                    throw new ArgumentException("Invalid operation.");
            }

            return result;

        }
    }
}
