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

        [Test]
        public void ConvertCeConvertCelciusToKelvinTest1()

        {

            //ARRANGE
            Conversion conversion = new Conversion();
            //ACT
            double result = conversion.ConvertCelciusToKelvin();
            //ASSERT
            Assert.AreEqual(274.15, result);

        }
        [Test]
        public void ConvertCeConvertCelciusToKelvinTest2()

        {

            //ARRANGE
            Conversion conversion = new Conversion(10);
            //ACT
            double result = conversion.ConvertCelciusToKelvin();
            //ASSERT
            Assert.AreEqual(283.15, result);

        }
        [Test]
        public void ConvertCeConvertCelciusToKelvinTest3()

        {

            //ARRANGE
            Conversion conversion = new Conversion(-15);
            //ACT
            double result = conversion.ConvertCelciusToKelvin();
            //ASSERT
            Assert.AreEqual(258.15, result);

        }

        [Test]
        public void ConvertFahrenheitToCelsiusTest1()

        {

            //ARRANGE
            Conversion conversion = new Conversion(0);
            //ACT
            double result = conversion.ConvertFahrenheitToCelsius();
            //ASSERT
            Assert.AreEqual(-17.78, result);

        }
        [Test]
        public void ConvertFahrenheitToCelsiusTest2()

        {

            //ARRANGE
            Conversion conversion = new Conversion(2000);
            //ACT
            double result = conversion.ConvertFahrenheitToCelsius();
            //ASSERT
            Assert.AreEqual(1093.33, result);

        }
        [Test]
        public void ConvertFahrenheitToCelsiusTest3()

        {

            //ARRANGE
            Conversion conversion = new Conversion(50);
            //ACT
            double result = conversion.ConvertFahrenheitToCelsius();
            //ASSERT
            Assert.AreEqual(10, result);

        }

        [Test]
        public void ConvertFahrenheitToKelvinTest1()

        {

            //ARRANGE
            Conversion conversion = new Conversion();
            //ACT
            double result = conversion.ConvertFahrenheitToKelvin();
            //ASSERT
            Assert.AreEqual(255.93, result);

        }

        [Test]
        public void ConvertFahrenheitToKelvinTest2()

        {

            //ARRANGE
            Conversion conversion = new Conversion(-7);
            //ACT
            double result = conversion.ConvertFahrenheitToKelvin();
            //ASSERT
            Assert.AreEqual(251.48, result);

        }

        [Test]
        public void ConvertFahrenheitToKelvinTest3()

        {

            //ARRANGE
            Conversion conversion = new Conversion(270);
            //ACT
            double result = conversion.ConvertFahrenheitToKelvin();
            //ASSERT
            Assert.AreEqual(405.37, result);

        }

        [Test]
        public void ConvertKelvinToCelsiusTest1()

        {

            //ARRANGE
            Conversion conversion = new Conversion(25);
            //ACT
            double result = conversion.ConvertKelvinToCelsius();
            //ASSERT
            Assert.AreEqual(-248.15, result);

        }

        [Test]
        public void ConvertKelvinToCelsiusTest2()

        {

            //ARRANGE
            Conversion conversion = new Conversion(-25);
            //ACT
            double result = conversion.ConvertKelvinToCelsius();
            //ASSERT
            Assert.AreEqual(-298.15, result);

        }

        [Test]
        public void ConvertKelvinToCelsiusTest3()

        {

            //ARRANGE
            Conversion conversion = new Conversion(50);
            //ACT
            double result = conversion.ConvertKelvinToCelsius();
            //ASSERT
            Assert.AreEqual(-223.15, result);

        }

        [Test]
        public void ConvertKelvinToFahrenheitTest1()

        {

            //ARRANGE
            Conversion conversion = new Conversion(8);
            //ACT
            double result = conversion.ConvertKelvinToFahrenheit();
            //ASSERT
            Assert.AreEqual(-445, result);

        }

        [Test]
        public void ConvertKelvinToFahrenheitTest2()

        {

            //ARRANGE
            Conversion conversion = new Conversion(6);
            //ACT
            double result = conversion.ConvertKelvinToFahrenheit();
            //ASSERT
            Assert.AreEqual(-448.6, result);

        }

        [Test]
        public void ConvertKelvinToFahrenheitTest3()

        {

            //ARRANGE
            Conversion conversion = new Conversion(56);
            //ACT
            double result = conversion.ConvertKelvinToFahrenheit();
            //ASSERT
            Assert.AreEqual(-358.6, result);

        }


    }
}
