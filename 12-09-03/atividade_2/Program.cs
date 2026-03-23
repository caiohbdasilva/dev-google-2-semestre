Console.Write("Insira o primeiro número:  ");
string a = Console.ReadLine();
double n1 = double.Parse(a);

Console.Write("Insira o segundo número:  ");
string b = Console.ReadLine();
double n2 = double.Parse(b);

Console.Write("Insira o terceiro número:  ");
string c = Console.ReadLine();
double n3 = double.Parse(c);

float media = (float)(n1+n2+n3)/3;

Console.WriteLine($"A média é de {media:f2}");
