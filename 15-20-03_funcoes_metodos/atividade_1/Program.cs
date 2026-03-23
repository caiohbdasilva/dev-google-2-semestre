Console.WriteLine("Informe um número: ");
int n = int.Parse(Console.ReadLine());

void EhPrimo(int num)
{
    if (num < 2) Console.WriteLine($"Não é primo");
    else
    {
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                Console.WriteLine($"Não é primo");
                break;
            }
            else if (i == num)
            {
            Console.WriteLine($"É primo");
            }
    }
}
}

EhPrimo(n);
