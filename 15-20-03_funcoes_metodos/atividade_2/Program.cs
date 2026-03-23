using System;

class Program
{
    static void Main()
    {
        double resultado1 = ConverterCelsiusParaFahrenheit(0);
        double resultado2 = ConverterCelsiusParaFahrenheit(28.5);
        double resultado3 = ConverterCelsiusParaFahrenheit(100);

        Console.WriteLine($"0°C equivale a {resultado1:F1}°F");
        Console.WriteLine($"28.5°C equivale a {resultado2:F1}°F");
        Console.WriteLine($"100°C equivale a {resultado3:F1}°F");
    }

    // Método que realiza o cálculo e retorna o valor
    static double ConverterCelsiusParaFahrenheit(double c)
    {
        return (c * 1.8) + 32;
    }
}