using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelcius(double fahrenheit)
        {
            double   val = 5 *1f/9*1f;
            //Console.WriteLine(val);
            return (fahrenheit -32) * (val);

        }

        public static double CelciusToFahrenheit(double celcius)
        {
            double val = 9 * 1f / 5 * 1f;
            //Console.WriteLine(val);
            return (celcius * val) + 32;
        }
    }
}
