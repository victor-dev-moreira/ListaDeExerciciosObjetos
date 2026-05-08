using System;

namespace Exercicio06.ConsoleApp;

public class ConverterTemperatura
{
    public double celsius;
    public double ConverterParaFahrenheit()
    {
        double fahrenheit = (celsius * (9.0 / 5.0)) + 32;
        return fahrenheit;
    }
}
