using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Digite o dia do seu nascimento (ex: 15): ");
        int dia = int.Parse(Console.ReadLine());

        Console.Write("Digite o mês do seu nascimento (ex: 03): ");
        int mes = int.Parse(Console.ReadLine());

        Console.Write("Digite o ano do seu nascimento (ex: 1995): ");
        int ano = int.Parse(Console.ReadLine());

        DateTime hoje = DateTime.Now;
        DateTime dataNascimento = new DateTime(ano, mes, dia);

        int idade = hoje.Year - dataNascimento.Year;

        if (hoje.Month < dataNascimento.Month || (hoje.Month == dataNascimento.Month && hoje.Day < dataNascimento.Day))
        {
            idade = idade - 1;
        }

        Console.WriteLine("Sua idade exata é: " + idade + " anos.");
    }
}