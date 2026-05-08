// Crie um programa que calcule o volume de uma caixa
using Exercicio01.ConsoleApp;

Caixa caixa = new Caixa();

caixa.altura = 20;
caixa.comprimento = 50;
caixa.largura = 30;

decimal volumeCaixa = caixa.CalcularVolume();

Console.WriteLine($"Volume: {volumeCaixa:F2}Cm³");