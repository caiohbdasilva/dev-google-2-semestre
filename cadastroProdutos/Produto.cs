class Produto
{
    public int Codigo { get; set; }
    public decimal Preco { get; set; }
        public string Nome { get; set; }
    public static List<Produto> listaProdutos = new List<Produto>();


    public static void CadastrarProduto()
    {
        Produto produto = new();

        Console.Write($"Digite o código do produto: ");
        produto.Codigo = int.Parse(Console.ReadLine());
        
        Console.Write($"Digite o nome do produto: ");
        produto.Nome = Console.ReadLine();

        Console.Write($"Digite o preço do produto: ");
        produto.Preco = decimal.Parse(Console.ReadLine());

        listaProdutos.Add(produto);
        Console.WriteLine($"\nProduto cadastrado com sucesso!\n");
    }



    public static void listarProdutos()
    {
        Console.ReadLine($"\n === LISA DE PRODUTOS ===")!;

        foreach (var item in listaProdutos)
        {
            Console.WriteLine($"Código: {item.Codigo}");
            Console.WriteLine($"Nome: {item.Nome}");
            Console.WriteLine($"Preco: {item.Preco}");
        }

        
    }




}

