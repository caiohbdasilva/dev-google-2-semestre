int[] array1 = new int[6];
int[] array2 = new int[6];


Console.WriteLine("Preencha o primeiro array (6 números):");
for (int i = 0; i < 6; i++) array1[i] = int.Parse(Console.ReadLine());

Console.WriteLine("Preencha o segundo array (6 números):");
for (int i = 0; i < 6; i++) array2[i] = int.Parse(Console.ReadLine());


int[] intersecao = new int[6];
int contadorIntersecao = 0;


for (int i = 0; i < array1.Length; i++)
{
    for (int j = 0; j < array2.Length; j++)
    {

        if (array1[i] == array2[j])
        {
            bool jaExiste = false;
            for (int k = 0; k < contadorIntersecao; k++)
            {
                if (intersecao[k] == array1[i])
                {
                    jaExiste = true;
                    break;
                }
            }

            if (!jaExiste)
            {
                intersecao[contadorIntersecao] = array1[i];
                contadorIntersecao++;
            }
            break;
        }
    }
}


Console.WriteLine("Valores que aparecem nos dois (Interseção):");
if (contadorIntersecao == 0)
{
    Console.WriteLine("Nenhum valor em comum encontrado.");
}
else
{
    for (int i = 0; i < contadorIntersecao; i++)
    {
        Console.Write(intersecao[i] + " ");
    }
}
