internal class Program
{
    private static void Main(string[] args)
    {
        //estrutura for/para
        // for(inicio; condição; incremento){ comandos}
        // costuma ser utilizada quando sabe a quantidade de reptições; se for ocntagem;
        //caso contrário, utiliza while; 


        Console.Write("quantos numeros inteiros voce vai digitar: ");
        int n = int.Parse(Console.ReadLine());
        int soma = 0;

        for(int i =1; i <=n; i++)
        {
            Console.Write("valor #{0}: ", i);
            int valor = int.Parse(Console.ReadLine());
            soma += valor; 
        }

        Console.WriteLine("soma = " + soma);
    }
}