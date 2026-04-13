abstract class Usuario
{
  // Modificadores de acesso: estão relacionados a capacidade das classes de realizarem encapsulamento. Niveis de encapsulamento: public, protected, private, internal
  public string? Nome { get; set; }
  protected string? Email { get; set; }
  private string? Senha { get; set; }

  public Usuario()
  {

  }

  public Usuario(string nome, string email, string senha)
  {
    Nome = nome;
    Email = email;
    Senha = senha;
  }

  // Sobrecarga 1
  public bool Logar(string email, string senha)
  {
    // if (Email == email && Senha == senha)
    // {
    //   return true;
    // }
    // else
    // {
    //   return false;
    // }
    return Email == email && Senha == senha;
  }

  // Sobrecarga 2
  public bool Logar()
  {
    Console.Write($"Email: ");
    string emailInput = Console.ReadLine()!;

    Console.Write($"Senha: ");
    string senhaInput = Console.ReadLine()!;

    return Logar(emailInput, senhaInput);
  }

  public virtual void ExibirPerfil()
  {
    Console.WriteLine($"Nome: {Nome}");
    Console.WriteLine($"Email: {Email}");
  }


}