Console.Write($"Informe uma temperatura: (em °C)   ");
string a = Console.ReadLine();
double temperatura = double.Parse(a);
string estado;

if (temperatura >= 35)
{
    estado = "muito quente";
}
else if (temperatura < 35 && temperatura >= 25)
{
    estado = "quente";
}
else if (temperatura < 25 && temperatura >= 15)
{
    estado = "agradável";
}
else if (temperatura < 15 && temperatura >= 0)
{
    estado = "frio";
}
else
{
    estado = "congelante";
}

Console.WriteLine($"A classificação de temperatura é de {estado}");