using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTempConverter
{
    public enum TempUnit
    {
        Celsius,
        Fahrenheit,
        Kelvin
    };

    public class Utilities
    {

        public static double FahrenheitToCelsius(double temp)
        {
            return (5.0 / 9.0) * (temp - 32);
        }
        public static double CelsiusToFahrenheit(double temp)
        {
            return (9.0 / 5.0) * temp + 32;
        }
        public static double KelvinToCelsius(double temp)
        {
            return temp - 273.15;
        }
        public static double CelsiusToKelvin(double temp)
        {
            return temp + 273.15;
        }
        public static double FahrenheitToKelvin(double temp)
        {
            return (5.0 / 9.0) * (temp - 32) + 273.15;
        }
        public static double KelvinToFarenheit(double temp)
        {
            return (9.0 / 5.0) * (temp - 273.15) + 32;
        }
        public static double UniversalConversion(double temp, TempUnit from, TempUnit to)
        {
            if (from == TempUnit.Celsius)
            {
                if (to == TempUnit.Celsius)
                {
                    return temp;
                }
                if (to == TempUnit.Fahrenheit)
                {
                    return CelsiusToFahrenheit(temp);
                }
                if (to == TempUnit.Kelvin)
                {
                    return CelsiusToKelvin(temp);
                }
            }
            if (from == TempUnit.Fahrenheit)
            {
                if (to == TempUnit.Celsius)
                {
                    return FahrenheitToCelsius(temp);
                }
                if (to == TempUnit.Fahrenheit)
                {
                    return temp;
                }
                if (to == TempUnit.Kelvin)
                {
                    return FahrenheitToKelvin(temp);
                }
            }
            if (from == TempUnit.Kelvin)
            {
                if (to == TempUnit.Celsius)
                {
                    return KelvinToCelsius(temp);
                }
                if (to == TempUnit.Fahrenheit)
                {
                    return KelvinToFarenheit(temp);
                }
                if (to == TempUnit.Kelvin)
                {
                    return temp;
                }
            }
            return temp;
        }
    }
}

