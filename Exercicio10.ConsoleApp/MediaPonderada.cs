namespace Exercicio10.ConsoleApp;

public class MediaPonderada
{
    public double nota1;
    public double nota2;
    public int peso1;
    public int peso2;
    public double CalcularMediaPonderada()
    {
        double somaPesoNota = (nota1 * peso1) + (nota2 * peso2);

        double somaPeso = peso1 + peso2;

        double mediaPonderada = somaPesoNota / somaPeso;

        return mediaPonderada;
    }
}
