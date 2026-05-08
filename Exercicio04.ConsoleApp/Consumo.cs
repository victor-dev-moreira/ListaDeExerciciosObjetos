using System;

namespace Exercicio04.ConsoleApp;

public class Consumo
{
    public int kmInicial;
    public int kmFinal;
    public int combustivelConsumido;
    public int CalcularConsumo()
    {
        int consumo = (kmFinal - kmInicial) / combustivelConsumido;

        return consumo;
    }
}
