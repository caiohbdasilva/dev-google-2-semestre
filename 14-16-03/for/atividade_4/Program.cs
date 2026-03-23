Console.WriteLine($"Sequência de 10 números");
int par = 0;
int seq = 0;
int num = 0;
for (int i = 1; i <= 10; i++)
{
    Console.Write($"Informe o {i}º número: ");
    string a = Console.ReadLine();
    num = int.Parse(a); 
    if (num % 2 == 0)
    {
        par = par + 1;
    }
    else
    {
        par = 0;
    }

    if (par >= seq)
    {
        seq = par;
    }

}

Console.WriteLine($"A maior sequência de nº pares são: {seq}");