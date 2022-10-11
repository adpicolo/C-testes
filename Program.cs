using System; 
using System.Globalization;
using System.Runtime.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, 
        o valor que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número 
        e o salário do funcionário, com duas casas decimais.*/

        int numero, horas;
        double valorHora, salario;

        numero = int.Parse(Console.ReadLine());
        horas = int.Parse(Console.ReadLine());
        valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        salario = valorHora * horas;

        Console.WriteLine("NUMBER = " + numero);
        Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        //To.String....serve para colocar pontos ao invez de virgulas nas casas decimais; 










    }
}