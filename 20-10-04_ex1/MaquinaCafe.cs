public class MaquinaCafe
{
    public int acucarDisponivel;
    public MaquinaCafe(int quantidadeInicial)
    {
        acucarDisponivel = quantidadeInicial;
    }

    public void FazerCafe(int quantidadeAcucar)
    {
        if (acucarDisponivel >= quantidadeAcucar)
        {
            acucarDisponivel -= quantidadeAcucar;
            Console.WriteLine($"Café pronto com {quantidadeAcucar}g de açúcar. Restam {acucarDisponivel}g no reservatório.");
        }
        else
        {
            Console.WriteLine("Saldo de açúcar insuficiente para esta quantidade. Café saindo sem açúcar.");
        }
    }

    public void FazerCafe()
    {
        
    }
}