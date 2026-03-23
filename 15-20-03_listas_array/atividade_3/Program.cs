List<int> valores = new() { 10, 15, 22, 30, 31, 40 };


for (int i = valores.Count - 1; i >= 0; i--)
{   
    if (valores[i] % 5 == 0)
    {
        valores.RemoveAt(i);
    }
}

Console.WriteLine("Lista após a remoção:");
foreach (int v in valores)
{
    Console.WriteLine(v);
}