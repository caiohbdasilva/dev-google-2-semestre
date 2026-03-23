Console.WriteLine($"Informe o tipo de veículo (1- Moto // 2- Carro // 3- Caminhão): ");
string a = Console.ReadLine();
int veiculo = int.Parse(a);

Console.WriteLine($"Informe a quantidade de tempo (em min): ");
string b = Console.ReadLine();
float min = int.Parse(b);

double valor = 0;

switch (veiculo)
{
    case 1:
    valor = 3*(min/60);
    break;

    case 2:
    valor = 5*(min/60);
    break;

    case 3:
    valor = 10*(min/60);
    break;
    
    default:
    Console.WriteLine($"Informe um código de 1 a 3");
    break;
}

if (min>=300 && min<600)
{
    valor = valor-((valor/100)*10);
}

if (min>=600)
{
    valor = valor-((valor/100)*20);
}

Console.WriteLine($"O valor total para a corrida será de R$ {valor}");