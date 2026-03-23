using System;

public class Program
{
    public static void Main()
    {
        DateTime dataInicial = DateTime.Now;
        Console.WriteLine("Data Inicial: " + dataInicial.ToString("dd/MM/yyyy"));

        DateTime dataComMeses = dataInicial.AddMonths(3);

        DateTime dataFinal = dataComMeses.AddDays(10);

        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Nova data após +3 meses e +10 dias:");
        Console.WriteLine(dataFinal.ToString("dd/MM/yyyy"));
    }
}