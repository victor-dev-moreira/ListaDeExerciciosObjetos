using Exercicio03.ConsoleApp;

Cilindro cilindro = new Cilindro();

cilindro.altura = 10;
cilindro.raio = 3;

double volume = cilindro.calcularVolume();

Console.WriteLine($"O volume do cilindro é: {volume}cm³");
