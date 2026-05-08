using Exercicio02.ConsoleApp;

TemperaturaFahrenheit fahrenheit = new TemperaturaFahrenheit();

fahrenheit.graus = 100;

TemperaturaCelsius celsius = fahrenheit.ConverterParaCelsius();

Console.WriteLine($"A conversão de {fahrenheit.graus}°F fahrenheit para Celsius resultou em: {celsius.graus:F1} °C");