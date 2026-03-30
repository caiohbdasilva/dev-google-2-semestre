Livro livro = new Livro();

livro.Titulo = "O menino do pijama listrado";
livro.Autor = "John Boyne";
livro.NumeroPaginas = 192;

livro.ExibirDados();

// ============================================================================================

Funcionario funcionario = new Funcionario();

funcionario.Nome = "Samuel";
funcionario.Salario = 1500;

funcionario.AumentarSalario();

// ============================================================================================

Lampada lampada = new Lampada();

lampada.EstaLigada = false;

lampada.Ligar();

// ============================================================================================

Pedido pedido = new Pedido();

pedido.Numero = 10000;
pedido.ValorTotal = 10;
pedido.AdicionarValor();

// ============================================================================================

Animal animal = new Animal();

animal.Nome = "Zubumafu";
animal.Tipo = "Macaco";

animal.EmitirSom();
