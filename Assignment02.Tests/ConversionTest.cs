using Assignment02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;


namespace Assignment02.Tests
{
    public class ConversionTest
    {
        [Test]
        public void ConvertCelciusToFahrenheitTest1()
        {
            //ARRANGE
            Conversion conversion = new Conversion();
            //ACT
            double result = conversion.ConvertCelciusToFahrenheit();
            //ASSERT
            Assert.AreEqual(33.8, result);
        }
        [Test]
        public void ConvertCelciusToFahrenheitTest2()
        {
            //ARRANGE
            Conversion conversion = new Conversion(5);
            //ACT
            double result = conversion.ConvertCelciusToFahrenheit();
            //ASSERT
            Assert.AreEqual(41, result);
        }

        [Test]
        public void ConvertCelciusToFahrenheitTest3()

        {

            //ARRANGE
            Conversion conversion = new Conversion(10);
            //ACT
            double result = conversion.ConvertCelciusToFahrenheit();
            //ASSERT
            Assert.AreEqual(50, result);

        }
    }
}
