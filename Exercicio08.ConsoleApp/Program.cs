using Exercicio08.ConsoleApp;

LataDeOleo volume = new LataDeOleo();
volume.altura = 20;
volume.raio = 5;

double resultado = volume.CalcularVolume();

Console.WriteLine($"O volume da lata de oleo é: {resultado}Cm³");