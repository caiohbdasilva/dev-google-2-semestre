namespace funcoes_metodos;

class Program
{
    static void Main(string[] args)
    {
        // void DizerOla() // Assinatura da função/método
        // {
        //     Console.WriteLine($"Olá, mundo!");
        // }

        // double peso = 65, altura = 1.75;
        // double imc = peso / (altura*altura);
        // Console.WriteLine($"IMC: {imc:f2}");

        Console.Write("Peso em kg: ");
        double peso = double.Parse(Console.ReadLine()!);
        
        Console.Write("Altura em m: ");
        double altura = double.Parse(Console.ReadLine()!);

        double imc = CalcularIMC(peso, altura);

        Console.WriteLine($"IMC: {imc:f2}");

        double CalcularIMC(double peso, double altura)
        {
            return peso/(altura*altura);
        }
    }
}
