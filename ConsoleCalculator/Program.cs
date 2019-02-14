using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double input1;
            double input2;
            string operation;
            double result;

            Console.Write("Enter first number: ");
            double.TryParse(Console.ReadLine(), out input1);

            Console.Write("Enter secnond number: ");
            double.TryParse(Console.ReadLine(), out input2);

            Console.Write("Enter the operation: ");
            operation = Console.ReadLine().ToLower();

            switch (operation)
            {
                case "+":
                case "add":
                    operation = "+";
                    result = input1 + input2;
                    break;
                case "-":
                case "subtract":
                    operation = "-";
                    result = input1 - input2;
                    break;
                case "*":
                case "mulitply":
                    operation = "*";
                    result = input1 * input2;
                    break;
                case "/":
                case "divide":
                    operation = "/";
                    result = 0;
                    if (input2 != 0)
                        result = input1 / input2;
                    else
                        Console.WriteLine("Invalid operation: Cannot divide by zero.");
                    break;
                default:
                    result = 0;
                    Console.WriteLine("Invalid operation: Try again: ");
                    break;

            }

            Console.WriteLine("{0} {1} {2} = {3} ", input1.ToString(), operation, input2.ToString(), result.ToString());
            Console.ReadLine();
        }
    }
}
