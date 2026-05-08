using Exercicio06.ConsoleApp;

ConverterTemperatura converter = new ConverterTemperatura();
converter.celsius = 20;

double resultado = converter.ConverterParaFahrenheit();

Console.WriteLine($"Resultado da conversão para Fahrenheit: {resultado}°F");