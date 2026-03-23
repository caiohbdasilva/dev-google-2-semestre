Console.Write("Digite a quantidade de elementos (N): ");
int n = int.Parse(Console.ReadLine());


int[] numeros = new int[n];


for (int i = 0; i < n; i++)
{
    Console.Write($"Digite o elemento {i + 1}: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Elementos na ordem inversa:");

for (int i = n - 1; i >= 0; i--)
{
    Console.WriteLine(numeros[i]);
}