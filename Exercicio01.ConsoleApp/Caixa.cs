using System;

namespace Exercicio01.ConsoleApp;

public class Caixa
{
    public decimal altura;
    public decimal comprimento;
    public decimal largura;

    public decimal CalcularVolume()
    {
        decimal volume = altura * comprimento * largura;

        return volume;
    }
}
