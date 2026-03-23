using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite sua senha: ");
        string senhaDigitada = Console.ReadLine();

        if (SenhaValida(senhaDigitada))
        {
            Console.WriteLine("Senha válida");
        }
        else
        {
            Console.WriteLine("Senha inválida");
        }
    }

    static bool SenhaValida(string senha)
    {
        if (senha == null || senha == "")
        {
            return false;
        }

        if (senha.Length < 6)
        {
            return false;
        }

        bool temDigito = false;
        
        foreach (char c in senha)
        {
            if (char.IsDigit(c))
            {
                temDigito = true;
                break; 
            }
        }

        if (temDigito == false)
        {
            return false;
        }

        return true;
    }
}