Console.Write("Insira o nome do filme: ");
string nomeFilme = Console.ReadLine();

Console.Write("Insira o ano de lançamento do filme: ");
string a = Console.ReadLine();
int anoFilme = int.Parse(a);
// Console.WriteLine($"{precoProduto.GetType()}");

Console.Write("Insira a duração do filme (em min): ");
string b = Console.ReadLine();
int duracao= int.Parse(b);

Console.WriteLine($"Nome do filme: {nomeFilme}");
Console.WriteLine($"Ano de lançamento: {anoFilme}");
Console.WriteLine($"Duração do filme: {duracao} min");