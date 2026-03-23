using System;

public class Program
{
    public static void Main()
    {
        string listaProdutos = "Arroz,Feijão,Macarrão";
        string produtos = "";

        Console.WriteLine("Itens identificados:");
        Console.WriteLine("--------------------");


        for (int i = 0; i < listaProdutos.Length; i++)
        {
            char letraAtual = listaProdutos[i];

            if (letraAtual == ',')
            {
                Console.WriteLine("- " + produtos);
                produtos = "";
            }
            else
            {
                produtos = produtos + letraAtual;
            }
        }

        Console.WriteLine("- " + produtos);
    }
}