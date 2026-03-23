using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Digite a primeira data e hora (dd/mm/aaaa hh:mm): ");
        DateTime data1 = DateTime.Parse(Console.ReadLine());

        Console.Write("Digite a segunda data e hora (dd/mm/aaaa hh:mm): ");
        DateTime data2 = DateTime.Parse(Console.ReadLine());

        TimeSpan intervalo = data2 - data1;
        
        if (intervalo.Ticks < 0) {
            intervalo = intervalo.Duration();
        }

        Console.WriteLine("--- Diferença entre as datas ---");        
        Console.WriteLine(intervalo.Days + " dias, " + intervalo.Hours + " horas e " + intervalo.Minutes + " minutos.");
    }
}