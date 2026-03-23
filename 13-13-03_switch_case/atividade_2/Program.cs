Console.Write($"Informe o primeiro número: ");
string a = Console.ReadLine();
int n1 = int.Parse(a);
Console.Write($"Informe o segundo número: ");
string b = Console.ReadLine();
int n2 = int.Parse(b);
Console.Write($"Escolha a operação (+, -, * ou /): ");
string operador = Console.ReadLine();
int resultado;

switch (operador)
{
    case "+":
    resultado = n1+n2;
    Console.WriteLine($"Resultado: {resultado}");
    break;

    case "-":
    resultado = n1-n2;
    Console.WriteLine($"Resultado: {resultado}");
    break;

    case "*":
    resultado = n1*n2;
    Console.WriteLine($"Resultado: {resultado}");
    break;

    case "/":
    resultado = n1/n2;
    Console.WriteLine($"Resultado: {resultado}");
    break; 
}