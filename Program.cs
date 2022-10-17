using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        //USO DO PROBLEMA SEM ORIENTAÇÃO A OBJETOS; 
        /*Fazer um programa para ler as medidas dos lados de dois triângulos X e Y (suponha medidas
        válidas). Em seguida, mostrar o valor das áreas dos dois triângulos e dizer qual dos dois triângulos
        possui a maior área.
        A fórmula para calcular a área de um triângulo a partir das medidas de seus lados a, b e c é a
        seguinte (fórmula de Heron):
        area  p( p  a)( p  b)( p  c) 2
        a b c
        */


double xA, xB, xC, yA, yB, yC;
Console.WriteLine("entre com as medidas do triangulo X: ");
xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("entre com as medidas do triangulo Y: ");
yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double p = (xA + xB + xC )/ 2.0;
double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

p = (yA + yB + yC) / 2.0;
double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

Console.WriteLine("Area de x =  " + areaX.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Area de Y =  " + areaY.ToString("F4", CultureInfo.InvariantCulture));

if (areaX > areaY)
{
    Console.WriteLine("Maior area: X");

}
else
{
    Console.WriteLine("maior area: Y");
}

}
}