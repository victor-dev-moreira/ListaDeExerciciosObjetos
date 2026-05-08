using Exercicio04.ConsoleApp;

Consumo consumo = new Consumo();
consumo.kmFinal = 20450;
consumo.kmInicial = 20000;
consumo.combustivelConsumido = 50;

int combustivel = consumo.CalcularConsumo();

Console.WriteLine($"Consumo por quilômetro é: {combustivel}Km/Litro");