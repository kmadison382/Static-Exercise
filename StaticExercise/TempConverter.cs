using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaticExercise
{
    public class TempConverter
    {
        public static double FahrenheitToCelsius(double tempF)
        {
            var tempC = (tempF - 32) * (5.0 / 9.0);
            return tempC;
        }

        public static double CelsiusToFahrenheit(double tempC)
        {
            var tempF = (tempC * (9.0 / 5.0)) + 32;
            return tempF;
        }

        public static double FahrenheitToKelvin(double tempF)
        {
            var tempK = (tempF - 32) * (5.0 / 9.0) + 273.15;
            return tempK;
        }

        public static double CelsiusToKelvin(double tempC)
        {
            var tempK = tempC + 273.15;
            return tempK;
        }

        public static double KelvinToFahrenheit(double tempK)
        {
            var tempF = (tempK - 273.15) * (9.0 / 5.0) + 32;
            return tempF;
        }

        public static double KelvinToCelsius(double tempK)
        {
            var tempC = tempK - 273.15;
            return tempC;
        }
    }
}