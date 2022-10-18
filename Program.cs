internal class Jogador
    //onde inicia a classe
{
    public int energia=100;
    //se nao estiver nada escrito, será public automaticamente; 

    public bool vivo=true;


    //onde inicia os objetos da classe
    public static void Main(string[] args)
    {
        
        Jogador j1 = new Jogador(); 
        //o new reserva a memorai e retorna o endereço da memoria
        //que ele alocou nesse objeto; 
        Jogador j2 = new Jogador();
        Jogador j3 = new Jogador();

        j1.energia = 50;
        j2.energia = 30; 
        j1.vivo = false;
        j2.vivo = true; 

        Console.WriteLine("energia do jogador 1: {0}", j1.energia);
        Console.WriteLine("energia do jogador 1: {0}", j2.energia);

        Console.WriteLine("o jogador 1 esta vivo? "+ j1.vivo);
        Console.WriteLine("o jogador 2 esta vivo?  "+ j2.vivo);


    }
}