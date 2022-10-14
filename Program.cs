internal class Program
{
    private static void Main(string[] args)
    {

        //Break Point - ponto no programa a partir do qual vc quer executar o debug - executar passo a passo; 
        //debug executa passo a passo - F10;

        Console.WriteLine("Digite 03 numeros: ");
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());//apertar a tecla F9 - break Point


        double resultado = maior(n1, n2, n3);

        Console.WriteLine("Maior = " + resultado);

    }
    //outra função, outro escopo; 
    static int maior(int a, int b, int c)
    {
        int m;
        if (a > b && a > c)
        {
            m = a;
        }
        else if (b > c)
        {
            m = b;
        }
        else
        {
            m = c;
        }
        return m;


    }
}