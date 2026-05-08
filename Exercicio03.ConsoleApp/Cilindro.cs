using System.Security.Cryptography.X509Certificates;

namespace Exercicio03.ConsoleApp;

public class Cilindro
{
    public const double pi = 3.14;
    public double raio;
    public double altura;

    public double calcularVolume()
    {
        double volume = pi * (raio * raio) * altura;

        return volume;
    }
}
