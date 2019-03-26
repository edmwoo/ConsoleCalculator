using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleCalculator.Test.Unit
{
    [TestClass]
    public class StringToNumericTest
    {
        private readonly StringToNumeric _stringToNumeric = new StringToNumeric();
        [TestMethod]
        public void ConvertValidStringInputToDouble()
        {
            string inputNumber = "5";
            double convertedNumber = _stringToNumeric.GetNumber(inputNumber);
            Assert.AreEqual(5, convertedNumber);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertInvalidStringToNumber()
        {
            string inputNumber = "not_num";
            double convertedNumber = _stringToNumeric.GetNumber(inputNumber);
        }

    }
}
