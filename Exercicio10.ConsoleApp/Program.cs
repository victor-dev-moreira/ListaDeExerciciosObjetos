using Exercicio10.ConsoleApp;

MediaPonderada media = new MediaPonderada();
media.nota1 = 7;
media.nota2 = 9;
media.peso1 = 2;
media.peso2 = 3;

double mediaPonderada = media.CalcularMediaPonderada();

Console.WriteLine($"A media ponderada é: {mediaPonderada}");