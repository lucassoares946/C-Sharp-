using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entradas
            double A, B, C, delta;
            Console.WriteLine("Calculo do discriminante delta de uma equação de segundo grau");
            Console.WriteLine("Ax² + Bx + C = 0");
            Console.WriteLine("Digite o valor de A:");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B:");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C:");
            C = double.Parse(Console.ReadLine());
            //Processamento Math.Pow(B,2) equivale a dizer B²
            delta = Math.Pow(B, 2) - 4 * A * C;
            //Saida
            Console.WriteLine("O valor do discriminante  (DELTA) é" + delta);

            Console.ReadKey();

        }
    }
}
