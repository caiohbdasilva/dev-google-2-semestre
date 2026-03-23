using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();

        int contadorDeEspacos = 0;
        for (int i = 0; i < frase.Length; i++)
        {
            if (frase[i] == ' ')
            {
                contadorDeEspacos = contadorDeEspacos + 1;
            }
        }
        int totalPalavras = contadorDeEspacos + 1;

        Console.WriteLine("A frase tem: " + totalPalavras + " palavras.");
    }
}