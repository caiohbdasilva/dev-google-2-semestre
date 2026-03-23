List<string> tarefas = new() { "Ler", "Treinar", "Programar" };
string busca = "Estudar";

int indice = tarefas.IndexOf(busca);

if (indice == -1)
{
    tarefas.Insert(0, busca);
    Console.WriteLine($"A tarefa {busca} não existia e foi adicionada ao início.");
}
else
{
    Console.WriteLine($"A tarefa {busca} já existe no índice: {indice}");
}
