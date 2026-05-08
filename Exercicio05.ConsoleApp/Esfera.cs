using System;

namespace Exercicio05.ConsoleApp;

public class Esfera
{
    public double raio;

    public const double pi = 3.14;

    public double CalcularEsfera()
    {

        double volume = 4.0 / 3.0 * pi * (raio * raio * raio);
        return volume;
    }
}
