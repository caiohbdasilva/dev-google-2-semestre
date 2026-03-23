Console.WriteLine($"Informe o tipo de acesso (1- Visitante // 2- Funcionário // 3- Administrador): ");
string a = Console.ReadLine();
int tipo_acesso= int.Parse(a);

Console.WriteLine($"Informe o horário (somente h): ");
string b = Console.ReadLine();
int h = int.Parse(b);

string acesso = "";

switch (tipo_acesso)
{
    case 1:
    if (h>=8 && h<=18)
    {
        acesso = "Liberado!";
    } else
    {
        acesso = "Negado!";
    }
    break;

    case 2:
    if (h>=6 && h<=22)
    {
        acesso = "Liberado!";
    } else
    {
        acesso = "Negado!";
    }
    break;

    case 3:
    acesso = "Liberado!";
    break;
    
    default:
    Console.WriteLine($"Informe um código de 1 a 3");
    break;
}


Console.WriteLine($"Acesso {acesso}");