class Gerente : Usuario
{
  public string? Matricula { get; set; }

  public Gerente()
  {
    
  }

  public Gerente(string nome, string email, string senha, string matricula) : base(nome, email, senha)
  {
    Matricula = matricula;
  }

  public override void ExibirPerfil()
  {
    Console.WriteLine($"\n=== PERFIL GERENTE ===");
    Console.WriteLine($"Nome: {Nome}");
    Console.WriteLine($"Email: {Email}");
    Console.WriteLine($"Matrícula: {Matricula}");
  }
}