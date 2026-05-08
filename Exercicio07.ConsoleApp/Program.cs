using Exercicio07.ConsoleApp;

SalarioVendedor salario = new SalarioVendedor();

Console.WriteLine("Calcular Salario Vendedor");
Console.WriteLine("----------------------------");

Console.Write("Qual salario base? ");
double salarioBase = double.Parse(Console.ReadLine());
Console.WriteLine("----------------------------");

Console.Write("Qual total de vendas? ");
salario.totalVendas = double.Parse(Console.ReadLine());
Console.WriteLine("----------------------------");

Console.Write("Qual porcentagem de comissão? ");
salario.percentualComissao = double.Parse(Console.ReadLine());


double salarioTotal = salario.CalcularSalario(salarioBase);

Console.WriteLine($"Salario Total é igual: R${salarioTotal}");

Console.ReadLine();