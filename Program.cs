internal class Program
{
    private static void Main(string[] args)
    {
        //tabela verdade -e xemplos

        bool c1 = 2 > 3 && 4 != 5; // como 2 não é maior do q 3 e precisaria de mambos para ser verdadeira, dará falso;
        //condição && (E) será verdadeira somente quando ambas forem V;

        Console.WriteLine(c1);

        //na condição OU || - ao menos uma tem que ser V;
        bool c2 = 2 > 3 || 4 != 5; // TRUE
        Console.WriteLine(c2); //pelo menos uma das duas~é V então, o resultado sera verdadeiro; ! significa NÃO; 

        bool c3 = !(2 > 3) && 4 != 5; //! negao resultado, inverte; /TRUE por conta da negação !; 
        Console.WriteLine(c3);
        Console.WriteLine("------------------------------");

        bool c4 = 10 < 5;

        bool c5 = c1 || c2 && c3;
        Console.WriteLine(c5);
        // C2 EE C3 = Precede = V + V = V;
        //C1 é falso + V DO c2 E c3 = V; pois OU exige que somente uma seja V; 
        



    }
}