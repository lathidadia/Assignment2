using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public class Conversion
    {
        private int x { get; set; }

        public Conversion()
        {
            x = 1;
        }

        public Conversion(int a)
        {
            x = a;

        }

        public double ConvertCelciusToFahrenheit()
        {
            double result = (x * ((double) 9 / 5)) + 32;
            return result;
        }
        public double ConvertCelciusToKelvin()
        {
            return (double)x + 273.15;
        }
        public double ConvertKelvinToFahrenheit()
        {
            return (double)9 / 5 * (x - 273) + 32;
        }
        public double ConvertKelvinToCelsius()
        {
            return x - 273.15;
        }
        public double ConvertFahrenheitToKelvin()
        {
            return (x + 459.67) * (double)5 / 9;
        }
        public double ConvertFahrenheitToCelsius()
        {
            return (x - 32) * (double)5 / 9;
        }
    }
}
