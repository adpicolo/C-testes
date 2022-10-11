using System.Runtime.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        //Exercício 1:
        //Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
        // mensagem explicativa.


        int numero1 = 10;
        int numero2 = 30;
        int soma = 0;

        soma = numero1 + numero2;
        Console.WriteLine(" A soma dos valores 10 + 30 é: " + soma);

        int numero3 = -30;
        int numero4 = 10;

        soma = numero3 + numero4;
        Console.WriteLine(" A soma dos valores -30 + 10 é: " + soma);





    }
}