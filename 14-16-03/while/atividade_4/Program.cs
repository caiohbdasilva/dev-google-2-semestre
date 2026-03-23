int numero = 35;
int chute = 0;
Console.Write("Informe um número entre 1-50:  ");
string chute_string = Console.ReadLine();
do
{
    if (int.TryParse(chute_string, out chute) && chute >= 0 && chute <= 50)
    {
        if (chute > numero)
        {
            Console.Write("Muito alto! Tente novamente: ");
            chute_string = Console.ReadLine();
        }
        else if (chute < numero)
        {
            Console.Write("Muito baixo! Tente novamente: ");
            chute_string = Console.ReadLine();
        }
    } else
    {
        Console.WriteLine("Número Inválido. Informe um número válido.");
        chute_string = Console.ReadLine();
    }

} while (numero != chute);

Console.WriteLine("Parabéns! Você acertou!");
