public abstract class Elevador
{
 
    public int AndarAtual { get; private set; } 
    public int TotalAndares { get; private set; }
    public int Capacidade { get; private set; }
    public int Pessoas { get; private set; }

  
    public void Inicializa(int capacidadeMax, int totalAndaresPredio)
    {
        Capacidade = capacidadeMax;
        TotalAndares = totalAndaresPredio;
        AndarAtual = 0; 
        Pessoas = 0;    
    }

    public void Entrar()
    {
        if (Pessoas < Capacidade) 
            Pessoas++; 
        else 
            Console.WriteLine("Elevador lotado!");
    }

    public void Sair()
    {
        if (Pessoas > 0) 
            Pessoas--;
        else 
            Console.WriteLine("O elevador já está vazio!");
    }

    public void Subir()
    {
        if (AndarAtual < TotalAndares) 
            AndarAtual++;
        else 
            Console.WriteLine("Você já está no último andar!");
    }

    public void Descer()
    {
        if (AndarAtual > 0) 
            AndarAtual--;
        else 
            Console.WriteLine("Você já está no térreo!");
    }
}