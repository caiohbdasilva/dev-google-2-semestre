class Cliente :  Usuario
{
  public string? CPF { get; set; }

  public Cliente(string nome, string email, string senha, string cpf) : base(nome, email, senha)
{
  CPF = cpf;
}

  public override void ExibirPerfil()
  {
    Console.WriteLine($"=== PERFIL CLIENTE ===");
    Console.WriteLine($"Nome: {Nome}");
    Console.WriteLine($"Email: {Email}");
    Console.WriteLine($"CPF: {CPF}");
  }
}