class Pedido
{
    public int Numero;
    public double ValorTotal;

    public void AdicionarValor()
    {
        Console.WriteLine($"Insira um valor para soma: ");
        double soma = double.Parse(Console.ReadLine());
        double ValorFinal = ValorTotal+soma;

        Console.WriteLine($"O valor final é de R$ {ValorFinal:f2}");
    }
}