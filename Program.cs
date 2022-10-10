internal class Program
{
    private static void Main(string[] args)
    {
       /*Fazer um programa para LER quatro valores inteiros A, B, C e D. A seguir, 
       calcule e mostre a diferença do produto de A e B pelo produto de C e D
       segundo a fórmula: DIFERENCA = (A * B - C * D)*/
        
       int A, B, C, D, diferenca; 
       A = int.Parse(Console.ReadLine());
       B = int.Parse(Console.ReadLine());
       C = int.Parse(Console.ReadLine());
       D = int.Parse(Console.ReadLine()); 

        diferenca = A * B - C * D;

        Console.WriteLine("Diferença = "+ diferenca);


        
    }
}