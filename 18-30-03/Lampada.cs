class Lampada
{
    public bool EstaLigada;

    public void Ligar()
    {
        if (EstaLigada)
        {
            Console.WriteLine($"Já está ligada!");
        } else
        {
            EstaLigada = true;
            Console.WriteLine($"Está ligada!");
        }
    }
    public void Desligar()
    {
        if (!EstaLigada)
        {
            Console.WriteLine($"Já está desligada!");
        } else
        {
            EstaLigada = false;
            Console.WriteLine($"Está desligada!");
        }
    }
}