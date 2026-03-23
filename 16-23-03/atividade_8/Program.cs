using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Digite uma data (dd/mm/aaaa): ");
        string entrada = Console.ReadLine();

        DateTime data = DateTime.Parse(entrada);

        DayOfWeek diaDaSemana = data.DayOfWeek;

        if (diaDaSemana == DayOfWeek.Saturday || diaDaSemana == DayOfWeek.Sunday)
        {
            Console.WriteLine("A data " + entrada + " cai em um FINAL DE SEMANA!");
            Console.WriteLine("Dia: " + diaDaSemana);
        }
        else
        {
            Console.WriteLine("A data " + entrada + " é um DIA ÚTIL.");
            Console.WriteLine("Dia: " + diaDaSemana);
        }
    }
}