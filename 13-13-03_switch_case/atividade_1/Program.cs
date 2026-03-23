Console.Write($"Informe um dia da semana (1-7): ");
string a = Console.ReadLine();
int dia = int.Parse(a);

switch (dia)
{
    case 1:
    Console.WriteLine($"O dia da semana é domingo!");
    break;
    case 2:
    Console.WriteLine($"O dia da semana é segunda!");
    break;
    case 3:
    Console.WriteLine($"O dia da semana é terca!");
    break;
    case 4:
    Console.WriteLine($"O dia da semana é quarta!");
    break;
    case 5:
    Console.WriteLine($"O dia da semana é quinta!");
    break;
    case 6:
    Console.WriteLine($"O dia da semana é sexta!");
    break;
    case 7:
    Console.WriteLine($"O dia da semana é sábado!");
    break;
}