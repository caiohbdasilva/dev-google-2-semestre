using System;

class Program
{
    static void Main()
    {
        double precoProduto = 250.00;
        double precoFinal1 = AplicarDesconto(precoProduto); 
        double precoFinal2 = AplicarDesconto(precoProduto, 25);
 
        Console.WriteLine($"Preço original: {precoProduto.ToString("C")}");
        Console.WriteLine($"Preço com desconto padrão (10%): {precoFinal1.ToString("C")}");
        Console.WriteLine($"Preço com desconto específico (25%): {precoFinal2.ToString("C")}");
    }

    static double AplicarDesconto(double preco, double percentual = 10)
    {
        double valorDesconto = preco * (percentual / 100);
        return preco - valorDesconto;
    }
}

