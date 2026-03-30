class Livro
{
    public string Titulo;
    public string Autor;
    public int NumeroPaginas;

    public void ExibirDados()
    {
        Console.WriteLine($"O livro {Titulo} foi escrito pelo autor {Autor} e contém {NumeroPaginas} páginas. ");
    }
}