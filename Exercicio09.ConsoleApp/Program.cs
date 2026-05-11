using Exercicio09.ConsoleApp;

MediaHarmonica mediaHarmonica = new MediaHarmonica();
mediaHarmonica.media1 = 8;
mediaHarmonica.media2 = 6;
mediaHarmonica.media3 = 4;

double resultado = mediaHarmonica.CalcularMediaHarmonica();

Console.WriteLine($"A media harmonica é: {resultado:F2}");