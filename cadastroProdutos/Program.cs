Gerente ger = new Gerente()
{
  Matricula = "FN-001",
  Nome = "Clara",
  Email = "admin@loja.com",
  Senha = "1234"
};

Gerente ger_2 = new Gerente(
"Joao",
"admin2@loja.com",
"1234",
"FN-002"
);

Usuario c = new Cliente("Ana","ana@email.com", "654321", "12345679811");

ger.ExibirPerfil();
c.ExibirPerfil();




// Usuario u = new Usuario();

bool logado = false;

while (!logado)
{
  Console.WriteLine($"=== Login Gerente ===");

  Console.Write($"Email: ");
  string emailInput = Console.ReadLine()!;

  Console.Write($"Senha: ");
  string senhaInput = Console.ReadLine()!;

  if (emailInput == ger.Email && senhaInput == ger.Senha)
  {
    logado = true;
    Console.WriteLine($"Login realizado com sucesso!\n");
  }
  else
  {
    Console.WriteLine($"Login ou senha incorretos. Tente novamente.\n");
  }

}

int opcao = -1;

while (opcao != 0)
{
  Console.WriteLine($"1 - Cadastrar Produto");
  Console.WriteLine($"2 - Listar Produtos");
  Console.WriteLine($"0 - Sair");
  Console.Write($"Escolha uma opção: ");
  opcao = int.Parse(Console.ReadLine()!);

  // Console.Clear();

  switch (opcao)
  {
    case 1:
      Produto.CadastrarProduto();
      break;
    case 2:
      Produto.ListarProdutos();
      break;
    case 0:
      opcao = 0;
      Console.WriteLine($"Encerrando o sistema...");
      break;

    default:
      Console.WriteLine($"Opção invalida");
      break;
  }
}

