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
            try
            {
                StringToNumeric stringToNumeric = new StringToNumeric();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                // get user input
                Console.Write("Enter a number: ");
                double input1 = stringToNumeric.GetNumber(Console.ReadLine());
                Console.Write("Enter another number: ");
                double input2 = stringToNumeric.GetNumber(Console.ReadLine());
                Console.Write("Enter operation: ");
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(input1, input2, operation);

                Console.WriteLine(result);
                
            
            }
            catch (Exception ex)
            {
                //TODO: change ouput to log
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.Write("Press any key to exit: ");
                Console.ReadLine();
            }


        }
    }
}
