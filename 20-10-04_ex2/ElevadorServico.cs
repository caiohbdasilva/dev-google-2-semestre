public class ElevadorServico : ElevadorAbstract
{
    public int Caixas { get; private set; }

    public void AlterarCaixas(int quantidade)
    {
        if (quantidade >= 0)
        {
            Caixas = quantidade;
            Console.WriteLine($"Quantidade de caixas agora é: {Caixas}");
        }
    }
}