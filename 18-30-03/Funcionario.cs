class Funcionario
{
    public string Nome;
    public double Salario;

    public void AumentarSalario()
    {
        Console.WriteLine($"Nome do funcionário: {Nome}");
        Console.WriteLine($"Informe a porcentagem a ser aumentada: ");
        double aumentopercentual = int.Parse(Console.ReadLine());
        Console.WriteLine($"Salário antigo: {Salario}");
        Salario = Salario + ((Salario/100)*aumentopercentual);
        Console.WriteLine($"Salário atual: {Salario}"); 
    }
}