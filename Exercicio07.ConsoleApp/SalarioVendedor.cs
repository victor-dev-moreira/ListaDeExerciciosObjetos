using System;

namespace Exercicio07.ConsoleApp;

public class SalarioVendedor
{

    public double totalVendas;
    public double percentualComissao;
    public double CalcularSalario(double salarioBase)
    {
        double comissao = CalcularComissao();
        return salarioBase + comissao;
    }
    public double CalcularComissao()
    {
        double comissao = totalVendas * (percentualComissao / 100);
        return comissao;
    }
}