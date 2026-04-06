class Aluno
{
    public int Matricula { get; set; }
    public string Nome { get; set; }
    public string Curso { get; set; }
    public static List<Aluno> listaAluno = new List<Aluno>();


    public static void CadastrarAlunos()
    {
        Aluno aluno = new();

        Console.Write($"Digite a matrícula do aluno: ");
        aluno.Matricula = int.Parse(Console.ReadLine());
        
        Console.Write($"Digite o nome do aluno: ");
        aluno.Nome = Console.ReadLine();

        Console.Write($"Digite o curso: ");
        aluno.Curso = Console.ReadLine();

        listaAluno.Add(aluno);
        Console.WriteLine($"\nAluno cadastrado com sucesso!\n");
    }



    public static void ListarAlunos()
    {
        Console.WriteLine($"\n === LISTA DE ALUNOS ===");

        foreach (var item in listaAluno)
        {
            Console.WriteLine($"Matricula: {item.Matricula}");
            Console.WriteLine($"Nome: {item.Nome}");
            Console.WriteLine($"Curso: {item.Curso}");
        }        
    }

}

