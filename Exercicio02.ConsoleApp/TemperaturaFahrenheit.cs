using System;

namespace Exercicio02.ConsoleApp;

public class TemperaturaFahrenheit
{
    public decimal graus;

    public TemperaturaCelsius ConverterParaCelsius()
    {
        TemperaturaCelsius celsius = new TemperaturaCelsius();
        celsius.graus = (graus - 32) * 5 / 9;

        return celsius;
    }
}
