class Cachorro
{
    public string Nome { get; set; }

    public string Raca { get; set; }

    public void latir()
    {
        Console.WriteLine($"{Nome}, da raça {Raca}, está latindo!");
    }
}