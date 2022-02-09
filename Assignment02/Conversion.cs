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
            return Math.Round(result, 2, MidpointRounding.AwayFromZero);
        }
        public double ConvertCelciusToKelvin()
        {
            double result = (double)x + 273.15;
            return Math.Round(result, 2, MidpointRounding.AwayFromZero);
        }
        public double ConvertKelvinToFahrenheit()
        {
            double result = (double)9 / 5 * (x - 273) + 32;
            return Math.Round(result, 2, MidpointRounding.AwayFromZero);
        }
        public double ConvertKelvinToCelsius()
        {
            double result =  x - 273.15;
            return Math.Round(result, 2, MidpointRounding.AwayFromZero);
        }
        public double ConvertFahrenheitToKelvin()
        {
            double result = (x + 459.67) * (double)5 / 9;
            return Math.Round(result, 2, MidpointRounding.AwayFromZero);
        }
        public double ConvertFahrenheitToCelsius()
        {
            double result =  (x - 32) * (double)5 / 9;
            return Math.Round(result, 2, MidpointRounding.AwayFromZero);
        }
    }
}
