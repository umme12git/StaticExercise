using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahren;
            double celcius;

            fahren = 85;
            celcius = TempConverter.FahrenheitToCelcius(fahren);
            Console.WriteLine($"Temparature in celcius is  {Math.Round(celcius,2)}");

            celcius = 20;
            fahren = TempConverter.CelciusToFahrenheit(celcius);
            Console.WriteLine($"Temparature in fahrenheit is {Math.Round(fahren,2)}");

        }
    }
}
