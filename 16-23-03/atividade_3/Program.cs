using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();

        Console.Write("Digite a palavra que deseja encontrar: ");
        string palavra = Console.ReadLine();

        if (frase.Contains(palavra))
        {
            Console.WriteLine("Sim! A palavra '" + palavra + "' existe na frase.");
        }
        else
        {
            Console.WriteLine("Não. A palavra '" + palvavra + "' não foi encontrada.");
        }
    }
}