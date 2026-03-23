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
string classificacao_imc;

if (imc>=30)
{
    classificacao_imc = "obesidade";
} else if (imc<30 && imc>= 25)
{
    classificacao_imc = "sobrepeso";    
} else if (imc<25 && imc>=18.5)
{
   classificacao_imc = "normal";
}
else
{
    classificacao_imc = "abaixo do peso";
}

Console.WriteLine($"O seu IMC é de {imc:f2}");
Console.WriteLine($"A sua classificação é de {classificacao_imc}");


