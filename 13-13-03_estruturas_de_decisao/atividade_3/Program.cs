Console.WriteLine($"Avaliação do triângulo");
Console.WriteLine("============================================================================================");
Console.Write($"Informe a medida do lado a: ");
string a = Console.ReadLine();
float ladoA= float.Parse(a);

Console.Write($"Informe a medida do lado b: ");
string b = Console.ReadLine();
float ladoB = float.Parse(b);

Console.Write($"Informe a medida do lado c: ");
string c = Console.ReadLine();
float ladoC= float.Parse(c);

string tipo_triangulo = "";

if (ladoA + ladoB > ladoC  && ladoA + ladoC > ladoB && ladoB + ladoC > ladoA)
{
    if (ladoA == ladoB && ladoB == ladoC)
    {
        tipo_triangulo = "Equilátero";
    } else if (ladoA != ladoB && ladoB != ladoC && ladoA != ladoC)
    {
        tipo_triangulo = "Escaleno";    
    } else
    {
        tipo_triangulo = "Isóceles";
    }

    Console.WriteLine($"Triângulo do tipo {tipo_triangulo}");
} else
{
    Console.WriteLine("As medidas informadas não podem formar um triângulo.");
}


