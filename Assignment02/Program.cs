using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                try
                {
                    double result = 0;

                    Console.WriteLine("Enter a value to convert:");
                    int input = int.Parse(Console.ReadLine());

                    if (input < 0)
                        throw new Exception("Please only enter numbers greater than 0.");

                    Conversion c = new Conversion(input);

                    Console.WriteLine("1. Convert Celsius to Fahrenheit\n2. Convert Celsius to Kelvin\n3. Convert Fahrenheit to Celsius\n4. Convert Fahrenheit to Kelvin\n5. Convert Kelvin to Celsius\n6. Convert Kelvin to Fahrenheit\n7. Exit");

                    int option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            result = c.ConvertCelciusToFahrenheit();
                            break;
                        case 2:
                            result = c.ConvertCelciusToKelvin();
                            break;
                        case 3:
                            result = c.ConvertFahrenheitToCelsius();
                            break;
                        case 4:
                            result = c.ConvertFahrenheitToKelvin();
                            break;
                        case 5:
                            result = c.ConvertKelvinToCelsius();
                            break;
                        case 6:
                            result = c.ConvertKelvinToFahrenheit();
                            break;
                        case 7:
                            exit = true;
                            break;
                        default:
                            throw new Exception("Incorrect option. Please try again.");
                    }

                    if (!exit)
                        Console.WriteLine("Result: " + result.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e + "\nERROR\nPress ENTER to try again.\n");
                    Console.ReadLine();
                }
            }
            Environment.Exit(1);
        }
    }
}