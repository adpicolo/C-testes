internal class Jogador
//onde inicia a classe
{
    public int energia;
    //se nao estiver nada escrito, será public automaticamente; 

    public bool vivo;

    public string nome;//escopo global a classe;

    public Jogador(string n)//escopo diferente; local ao metodo
    {
        energia = 100;
        vivo = true;
        nome = n; 
        //metodo Destrutor - deletar o metodo; 


    }
    

        //onde inicia os objetos da classe -INSTANCIAÇÃO
        public static void Main(string[] args)

        //metodo construtor
    {
        string nome1;//metodo construtor; 
        Console.WriteLine("digite o nome do jogador 1: ");
        nome1 = Console.ReadLine(); 
        Jogador j1 = new Jogador(nome1);
        //o new reserva a memorai e retorna o endereço da memoria
        //que ele alocou nesse objeto; 
        Jogador j2 = new Jogador("THEO");
        
        j1.energia = 50;
        j2.energia = 30;


        Console.WriteLine("nome do jogador 1: {0}", j1.nome);
        Console.WriteLine("nome do jogador 2: {0}", j2.nome);

    }
    
    }
    
        
    



