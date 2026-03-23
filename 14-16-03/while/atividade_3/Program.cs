int soma = 0;
int qtdeNumeros = 0;
int nC;

do
{
    Console.Write("Informe um número: ");
    string n = Console.ReadLine();
    if (int.TryParse(n, out nC))
    {
        soma = soma + nC;
        qtdeNumeros = qtdeNumeros + 1;
    }
    else
    {
        Console.WriteLine("Número inválido. Informe um número válido.");
    }
} while (qtdeNumeros < 5);

int media = soma / qtdeNumeros;

Console.WriteLine($"Media: {media}");