using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    public class StringToNumeric
    {
        public double GetNumber(string argText)
        {

            double convertedNumber;

            if (!double.TryParse(argText, out convertedNumber))
            {
                throw new ArgumentException("Invalid argument: input must be a number.");
            }

            return convertedNumber;



        }
    }
}
