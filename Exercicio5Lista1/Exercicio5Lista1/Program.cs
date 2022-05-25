using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5Lista1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1, a2, a3, a4, matriz;
            Console.WriteLine("Calcular Matriz");
            Console.WriteLine("Digite 1º Valor");
            a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite 2º Valor");
            a2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite 3º Valor");
            a3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite 4º Valor");
            a4 = double.Parse(Console.ReadLine());
            matriz = a1 * a2 - a3 * a4;
            Console.WriteLine("O  valor do determinante da matriz é: " + matriz );
            Console.ReadKey();

        }
    }
}
