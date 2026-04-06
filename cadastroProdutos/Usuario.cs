abstract class Usuario
{
  public string? Nome { get; set; }
  public string? Email { get; set; }
  public string? Senha { get; set; }


public Usuario(){ }
  public Usuario(string nome, string email, string senha)
  {
    Nome = nome;
    Email = email;
    Senha = senha;
  }

public virtual void ExibirPerfil()
  {
    Console.WriteLine($"Nome: {Nome}");
    Console.WriteLine($"Email: {Email}");
  }

}