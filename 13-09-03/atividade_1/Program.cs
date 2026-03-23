Console.Write("Insira o nome do produto: ");
string nomeProduto = Console.ReadLine();

Console.Write("Insira o preço do produto: ");
string a = Console.ReadLine();
decimal precoProduto = decimal.Parse(a);
// Console.WriteLine($"{precoProduto.GetType()}");

Console.Write("Insira a quantidade do produto: ");
string b = Console.ReadLine();
int qtdeProduto = int.Parse(b);

Console.WriteLine($"Nome do produto: {nomeProduto}");
Console.WriteLine($"Preço do produto: R$ {precoProduto:f2}");
Console.WriteLine($"Quantidade: {qtdeProduto}");