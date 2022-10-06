internal class Program
{
    private static void Main(string[] args)
    {

        bool completo = false; //guarda valor verdade /V ou F; 
        char genero = 'F'; //guarda caracteres; entre aspas simples; 
        char letra = '\u0041'; //codigo unicolde
        byte n1 = 126;// guarda de 0 a 255; 
        int n2 = 1000; //int numeros inteiros; 
        int n3 = 2147483647; //numero máximo do int;
        long n4 = 2147483648L; //após o int, usar o long; recomenda-se usar o L ao final para verificar que é numero Long; 
        float n5 = 4.5f;//precisa colocar o f na frente para saber q é float; 
        double n6 = 4.5; // o double suporta numeros maiores queo float; 
        string nome = "Andrea Del Picolo"; //string são palavras; não é tipo basico da linguagem c#; é cadeia de caractere Unicode; IMUTÁVEL; 
        //não pode mais mudar o valor da string após criada; para deixar o programa mais seguro e livre de erros; 
        object obj1 = "Junior Amor";  //objeto genérico;
        object obj2 = 37.0; //pode também numeros doubles geral;

        int n7 = int.MinValue; //pega o valor minimo do codigo descrito; 
        int n8 = int.MaxValue; // valor máximo do codigo digitado;
        sbyte n9 = sbyte.MinValue; //menor valor do byte; 
        decimal n10 = decimal.MaxValue; 



        Console.WriteLine(completo); 
        Console.WriteLine(genero);
        Console.WriteLine(letra);
        Console.WriteLine(n1);
        Console.WriteLine(n2);
        Console.WriteLine(n3);
        Console.WriteLine(n4);
        Console.WriteLine(n5);
        Console.WriteLine(n6);
        Console.WriteLine(nome);
        Console.WriteLine(obj1);
        Console.WriteLine(obj2); 
        Console.WriteLine(n7);
        Console.WriteLine(n8);
        Console.WriteLine(n9);
        Console.WriteLine(n10);


    }
}