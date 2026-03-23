int[] notas = { 5, 7, 8, 3, 10, 6 };
int contador = 0;

for (int i = 0; i < notas.Length; i++)
{
    if (notas[i] >= 7)
    {
        contador++;
    }
}

int[] notasAltas = new int[contador];
int indiceNovo = 0;


for (int i = 0; i < notas.Length; i++)
{
    if (notas[i] >= 7)
    {
        notasAltas[indiceNovo] = notas[i];
        indiceNovo++;
    }
}


Console.WriteLine("Notas maiores ou iguais a 7:");
for (int i = 0; i < notasAltas.Length; i++)
{
    Console.WriteLine(notasAltas[i]);
}