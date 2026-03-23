string usuario = "admin";
int senha = 1234;

System.Console.Write("Informe um usuário: ");
string usuario_informado = Console.ReadLine();
Console.Write("Informe a senha: ");
string a = Console.ReadLine();
int senha_informada = int.Parse(a);

if (usuario == usuario_informado)
{
    if (senha == senha_informada)
    {
        Console.WriteLine($"Acesso Liberado!");
    } else
    {
        Console.WriteLine($"Senha Inválida!");
    }    
} else
{
    Console.WriteLine($"Usuário Inválido!");
}