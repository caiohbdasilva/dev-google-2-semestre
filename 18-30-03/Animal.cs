class Animal
{
    public string Nome;

    public string Tipo;

    public void EmitirSom()
    {
        Console.WriteLine($"O animal {Nome} do tipo {Tipo} está emitindo som.");
    }
}