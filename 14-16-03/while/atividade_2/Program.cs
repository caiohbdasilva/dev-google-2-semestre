int soma = 0;
int nC;

do
{
    Console.Write("Informe um número para ser somado ou digite 0 p/ sair:  ");
    string n = Console.ReadLine();
    if (int.TryParse(n, out nC))
    {
        soma = soma + nC;
    }
    else
    {
        Console.WriteLine("Número inválido. Informe um nímero válido.");
    }
} while (nC != 0);

Console.WriteLine($"Soma: {soma}");