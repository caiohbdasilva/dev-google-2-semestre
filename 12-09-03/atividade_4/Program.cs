Console.Write("Insira seu peso (em KG): ");
string a = Console.ReadLine();
if (!double.TryParse(a, out double peso))
{
    Console.WriteLine("Erro: Você não digitou um número válido!");
}
else
{
    Console.WriteLine($"Sucesso! Peso salvo!");
}

Console.Write("Insira sua altura(em m): ");
string b = Console.ReadLine();
if (!double.TryParse(b, out double altura))
{
    Console.WriteLine("Erro: Você não digitou um número válido!");
}
else
{
    Console.WriteLine("Sucesso! Altura salva!");
}

double imc = (peso/(altura*altura));

Console.WriteLine($"O seu IMC é de {imc:f2}");

