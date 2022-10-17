using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos
{
    internal class Triangulo //a classe tbm é um tipo; tipo double, int, string e etc; tipopersonalizado; 
                             ////o trinagulo tem tres atributos - lado a, b, c;
                             //nome de atributo começa com letra maiuscula;
    {
        private double A;
        private double B;
        private double C;

              class Program
        {
            static void Main(string[] args)
            {
                Triangulo x, y;
                x = new Triangulo();
                y = new Triangulo();

                Console.WriteLine("Entre com as medidas do triângulo X:");
                x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Entre com as medidas do triângulo Y:");

                y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double p = (x.A + x.B + x.C) / 2.0;
                double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));
                p = (y.A + y.B + y.C) / 2.0;

                double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

                Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
                Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

                if (areaX > areaY)
                {
                    Console.WriteLine("Maior área: X");
                }
                else
                {
                    Console.WriteLine("Maior área: Y");
                }
            }
        }
    }




}


