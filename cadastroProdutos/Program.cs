class Produto
{
  public int Codigo;
  public string? Nome;
  public decimal Preco;

  public static List<Produto> listaProdutos = new List<Produto>();


  public static void CadastrarProduto()
  {
    Produto produto = new Produto();

    Console.Write($"Digite o código do produto: ");
    produto.Codigo = int.Parse(Console.ReadLine()!);

    Console.Write($"Digite o nome do produto: ");
    produto.Nome = Console.ReadLine()!;

    Console.Write($"Digite o preço do produto: ");
    produto.Preco = decimal.Parse(Console.ReadLine()!);

    listaProdutos.Add(produto);

    Console.WriteLine($"\nProduto cadastrado com sucesso!\n");

  }

  public static void ListarProdutos()
  {
    Console.WriteLine($"\n=== LISTA DE PRODUTOS ===");

    if (listaProdutos.Count == 0)
    {
      Console.WriteLine($"Nenhum produto cadastrado.\n");
      return;
    }

    foreach (var item in listaProdutos)
    {
      Console.WriteLine($"Código: {item.Codigo}");
      Console.WriteLine($"Nome: {item.Nome}");
      Console.WriteLine($"Preço: {item.Preco}");
      Console.WriteLine($"------------------");
    }

  }

}