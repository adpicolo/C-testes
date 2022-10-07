using System.Runtime.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        double saldo = 100.0;
        double valorDoSaque = 10.0;
        saldo -= valorDoSaque; //pode-se utilizar -= para simplificar o codigo, o que seria antes: saldo = saldo - valorDoSaque;
        //operadores += (para	somas),	*=	(para	multiplicações)	e /=	(para	divisões).

        Console.WriteLine(valorDoSaque);

        string mensagem = "Minha	Mensagem";
        Console.WriteLine(mensagem);
        Console.WriteLine("--------------------------------------------------");

        int idadeMaria = 20;
        int idadeJoao = 30;
        int idadeAna = 40;
        int media = 0; 
        int Soma = 0;

        Soma += idadeAna + idadeJoao + idadeMaria;
        media = Soma / 2; 
        
        Console.WriteLine("A média da idade é: " + media);
        Console.WriteLine("--------------------------------------------------");


        double pi = 3.14;
        int piQuebrado = (int)pi;

        Console.WriteLine("piQuebrado	=	" + piQuebrado);
        Console.WriteLine("--------------------------------------------------");

        double saldo2 = 100.0;
        double valorSaque = 10.0;
        if (saldo2 >= valorSaque)
            //ambos são tipo bool - valores V ou F; 
        {
            saldo = saldo2 - valorSaque;

            Console.WriteLine("saque autorizado");
        }

        else; 
            Console.WriteLine("saldo insuficiente");


        // > menor; < mair; == igual; != diferente; ! negar uma condição; && e; || OU;
        // ex: bool	realmentePodeSacar	=	(saldo	>=	valorSaque)	&&	(valorSaque	>	0);
        // ex. OU - essa	condição	é	verdadeira	se	(saldo	>=	valorSaque)	for	true
        //	ou	se	(valorSaque	>	0)	for	verdadeiro.

        Console.WriteLine("----------------------------------");

        double taxa;

        Console.WriteLine(" digite o valor de seu saldo: "); 
        

        if (saldo < 1000)
        {
            taxa = 0.01;
        }
        else if (saldo <= 5000)
        {
            taxa = 0.05;
        }
        else
        {
            taxa = 0.1; 
        }

        double saldo3 = 500.0;
        if (saldo < 0.0)
        {
            Console.WriteLine("você esta no negativo");

        }
        else if (saldo < 1000000.0) ;
        {
            Console.WriteLine("você é um bom cliente");
        }

            
        else
        {
            Console.WriteLine("você é milionário!!!!");
        }






    }
}