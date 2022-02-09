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
            return ((x * 9 / 5) + 32);
        }
        public double ConvertCelciusToKelvin()
        {
            return x + 273.15;
        }
        public double ConvertKelvinToFahrenheit()
        {
            return 9 / 5 * (x - 273) + 32;
        }
        public double ConvertKelvinToCelsius()
        {
            return x - 273.15;
        }
        public double ConvertFahrenheitToKelvin()
        {
            return (x + 459.67) * 5 / 9;
        }
        public double ConvertFahrenheitToCelsius()
        {
            return (x - 32) * 5 / 9;
        }
    }
}
