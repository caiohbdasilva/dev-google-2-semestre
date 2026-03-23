using System;

public class Program
{
    public static void Main()
    {
        DateTime hoje = DateTime.Now;

        Console.WriteLine("Data de hoje: " + hoje.ToShortDateString());
        Console.WriteLine("--------------------------------------");
        Console.Write("Digite a data do evento (dia/mês/ano): ");

        string entrada = Console.ReadLine();
        DateTime dataEvento = DateTime.Parse(entrada);
        TimeSpan diferenca = dataEvento - hoje;
        int diasQueFaltam = (int)diferenca.TotalDays;

        if (diasQueFaltam > 0)
        {
            Console.WriteLine("Faltam " + diasQueFaltam + " dias para o evento!");
        }
        else if (diasQueFaltam == 0)
        {
            Console.WriteLine("O evento é hoje!");
        }
        else
        {
            Console.WriteLine("Esse evento já aconteceu há " + Math.Abs(diasQueFaltam) + " dias.");
        }
    }
}