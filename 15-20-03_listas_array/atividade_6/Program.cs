List<int> lista1 = new List<int>();
List<int> lista2 = new List<int>();

Console.WriteLine("Digite 3 números para a Lista 1:");
for (int i = 0; i < 3; i++)
{
    lista1.Add(int.Parse(Console.ReadLine()));
}

Console.WriteLine("Digite 3 números para a Lista 2:");
for (int i = 0; i < 3; i++)
{
    lista2.Add(int.Parse(Console.ReadLine()));
}


List<int> listaFinal = new List<int>();
listaFinal.AddRange(lista1);
listaFinal.AddRange(lista2);


List<int> listaSemRepetidos = new List<int>();
for (int i = 0; i < listaFinal.Count; i++)
{
    int itemAtual = listaFinal[i];


    if (!listaSemRepetidos.Contains(itemAtual))
    {
        listaSemRepetidos.Add(itemAtual);
    }
}

listaSemRepetidos.Sort();


Console.WriteLine("Lista Final (Ordenada e sem duplicados):");
for (int i = 0; i < listaSemRepetidos.Count; i++)
{
    Console.Write(listaSemRepetidos[i] + " ");
}