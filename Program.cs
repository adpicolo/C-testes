
//IMPRIMIR SAÍDA DE DADOS Csharp


internal class Program
{
    private static void Main(string[] args)
    {
        

        
        int idade = 31;
        double saldo = 10.35784;
        string nome = "Maria"; 

        Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F} reais", nome, idade, saldo); // técnica Placeholders; iniciar contar do zero e colocar entre as chaves; 

        Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");//tecnica interpolação; 

        Console.WriteLine(nome + " tem " +  idade + "anos e tem saldo igual a " + saldo.ToString("F2") + " reais");//concondenação de strings - junção de varias partes; 

    }
}