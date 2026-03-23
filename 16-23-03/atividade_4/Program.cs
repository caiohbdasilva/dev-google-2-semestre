using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Digite uma frase com espaços nas pontas (ex: '  olá mundo  '): ");
        string entrada = Console.ReadLine();
        string textoLimpo = entrada.Trim();
        string textoPadrao = textoLimpo.ToUpper();

        Console.WriteLine("Texto padronizado: [" + textoPadrao + "]");
    }
}