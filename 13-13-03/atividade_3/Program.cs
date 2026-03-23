Console.Write($"Informe o primeiro número: ");
string a = Console.ReadLine();
int n1 = int.Parse(a);
Console.Write($"Informe o segundo número: ");
string b = Console.ReadLine();
int n2 = int.Parse(b);
Console.Write($"Informe o terceiro número: ");
string c = Console.ReadLine();
int n3 = int.Parse(c);

int maior = n1;

if (n3>maior)
{
    maior = n3;
    if (n2>maior)
    {
        maior = n2;
    }
}

Console.WriteLine($"O maior número entre os três é o {maior}.");