public class Program
{

    public static void Main()
    {
        Console.WriteLine("Informe a quantidade de açúcar na máquina: ");
        int acucarMaquina = int.Parse(Console.ReadLine());
        MaquinaCafe minhaCafeteira = new MaquinaCafe(acucarMaquina);

        Console.WriteLine("Informe a quantidade de açúcar no café: ");
        string x = Console.ReadLine()!;
        int qtdeAcucar;
        if (x == "")
        {
            qtdeAcucar = 10;
        } else
        {
            qtdeAcucar = int.Parse(x);
        } 

        minhaCafeteira.FazerCafe(qtdeAcucar);
    }
}