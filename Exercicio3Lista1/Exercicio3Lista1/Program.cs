using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3Lista1
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, a, c, delta;
            Console.WriteLine("Calcule o DELTA: ");
            Console.WriteLine("Digite o valor de A: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("O valor de delta é " + (Math.Pow(b,2) - 4 * a * c));
            Console.ReadKey();

        }
    }
}
