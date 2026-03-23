Console.Write($"Informe um número: ");
string a = Console.ReadLine();
int n = int.Parse(a);

int verificacao = n%2;

if (verificacao == 0)
{
    Console.WriteLine($"Número par!");
}
else
{
    Console.WriteLine($"Número ímpar!");
}