using System.Globalization;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        //A estrutura se repete enquanto a condição for Verdadeira; 
        //V - executa e volta; F - pula fora; parece o If;

        
        Console.Write("digite um numero: ");
        double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        while (x >= 0.0)
        {

            double raiz = Math.Sqrt(x);
            Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("digite outro numero ");
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        Console.WriteLine("numero negativo");

    }
}