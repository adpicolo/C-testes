using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        string produto1 = "computador";
        string produto2 = "mesa de escritorio";

        byte idade = 30;
        int codigo = 5290;
        char genero = 'M';

        double preco1 = 2100.0;
        double preco2 = 650.50;
        double medida = 53.234567;

        Console.WriteLine("Produtos: ");
        Console.WriteLine(produto1 + " cujo o preço é: " + preco1);
      
        Console.WriteLine(produto2 + " cujo preço é " + preco2);

        Console.WriteLine("Registro: ");
        Console.WriteLine(idade + "anos de idade, código " + codigo + " gênero " + genero);

        Console.WriteLine("Medida com oito casas decimais: " + medida);
        Console.WriteLine("arredondando (tres casas decimais): {0:F3}", medida);
        Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));


        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("Produtos: ");
        Console.WriteLine("{0} cujo preço é $ {1:F2} ", produto1, preco1);
        Console.WriteLine("{0} cujo preço é $ {1:F2} ", produto2, preco2);
        Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero {2} ", idade, codigo, genero);
        Console.WriteLine("Medida com oito casas decimais: {0:F8}", medida);
        Console.WriteLine("Arredondando três casas decimais: {0:F3} ", medida);
        Console.WriteLine("Separador decimal inavriant Culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));

    




        
    }
}