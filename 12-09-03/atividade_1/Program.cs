Console.Write("Insira a largura:  ");
string a = Console.ReadLine();
double largura = double.Parse(a);

Console.Write("Insira a altura:  ");
string b = Console.ReadLine();
double altura = double.Parse(b);

double area = largura * altura;

Console.WriteLine($"A área total é de {area:f2} m2");
