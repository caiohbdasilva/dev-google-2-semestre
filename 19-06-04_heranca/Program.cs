Administrador adm = new Administrador();


int opcao = -1;

while (opcao != 0)
{
    Console.WriteLine($"Escolha uma opção: ");
    Console.WriteLine($"1 - Cadastrar Aluno");
    Console.WriteLine($"2 - Listar Alunos");
    Console.WriteLine($"0 - Sair");
    opcao = int.Parse(Console.ReadLine()!);

    Console.Clear();

    switch (opcao)
    {
        case 1:
            Aluno.CadastrarAlunos();
            break;
        case 2:
            Aluno.ListarAlunos();
            break;
        case 0:
            Console.WriteLine($"Encerrando o sistema...");
            break;

        default:
            Console.WriteLine($"Opção invalida");
            break;
    }
}