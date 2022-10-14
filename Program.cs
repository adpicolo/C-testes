internal class Program
{
    private static void Main(string[] args)
    {
        //Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
        //começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

        string[] valores = Console.ReadLine().Split(' ');
        int horaInicial = int.Parse(valores[0]);
        int horaFinal = int.Parse(valores[1]);

        int duracao;
        if (horaInicial < horaFinal)
        {
            duracao = horaFinal - horaInicial;
        }
        else
        {
            duracao = 24 - horaInicial + horaInicial;

        }
        Console.WriteLine("o jogo durou: " + duracao + "horas(S)");

    }



}
   