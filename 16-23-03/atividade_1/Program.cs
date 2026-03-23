using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Digite seu nome completo: ");
        string nome = Console.ReadLine();

        // 1. Converte a string em um array de caracteres
        char[] caracteres = nome.ToCharArray();

        // 2. Inverte o array "no lugar" (in-place)
        Array.Reverse(caracteres);

        // 3. Cria uma nova string a partir do array invertido
        string nomeInvertido = new string(caracteres);

        Console.WriteLine($"O nome invertido é: {nomeInvertido}");
    }
}