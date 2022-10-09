using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        string frase = Console.ReadLine();
        //abre o terminal para receber a informação do usuário; 
        string x = Console.ReadLine();
        string y = Console.ReadLine();
        string z = Console.ReadLine();

        //comando Split - vetor; abre espaço entre parenteses para colocar palvaras na mesma linha;
        
        string[] v = Console.ReadLine().Split(' ');
        string a = v[0];
        string b = v[1];
        string c = v[2]; 

        Console.WriteLine("voce digitou: " + frase);
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);





    }
}