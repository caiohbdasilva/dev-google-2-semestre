Console.Write("Insira o nome da cidade: ");
string nomeCidade = Console.ReadLine();

Console.Write("Insira a temperatura atual da cidade: ");
string a = Console.ReadLine();
double temperatura = double.Parse(a);
// Console.WriteLine($"{precoProduto.GetType()}");

Console.Write("Insira a umidade do ar (em %): ");
string b = Console.ReadLine();
int umidade= int.Parse(b);

Console.WriteLine($"Nome da cidade: {nomeCidade}");
Console.WriteLine($"Temperatura: {temperatura:f2} °C");
Console.WriteLine($"Umidade: {umidade}%");